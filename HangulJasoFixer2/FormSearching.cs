using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace HangulJasoFixer2
{
    public partial class FormSearching : Form
    {
        private SearchArguments searchArguments;

        public FormSearching()
        {
            InitializeComponent();
        }

        public void SetCriteria(SearchCriteria searchCriteria)
        {
            searchArguments = new SearchArguments(searchCriteria, labelCurrentFile);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            StopSignalToBackgroundWorker();
            buttonCancel.Enabled = false;
        }

        private void StopSignalToBackgroundWorker()
        {
            if (backgroundWorkerSearch.IsBusy)
            {
                backgroundWorkerSearch.CancelAsync();
            }
        }

        private void FormSearching_Shown(object sender, EventArgs e)
        {
            backgroundWorkerSearch.RunWorkerAsync(searchArguments);
        }

        private void BackgroundWorkerSeaching_DoWork(object sender, DoWorkEventArgs e)
        {
            var searchArgs = e.Argument as SearchArguments;
            searchArgs.ClearRows();
            SearchWork(sender as BackgroundWorker, searchArgs);
        }

        private void SearchWork(BackgroundWorker worker, SearchArguments args)
        {
            var directoryInfo = new DirectoryInfo(args.RootPath);
            foreach (var fi in directoryInfo.GetFiles())
            {
                args.SetCurrentFileLable(fi.Name);
                if (worker.CancellationPending)
                {
                    return;
                }
                if (!fi.Name.IsNormalized())
                {
                    string fixedFullName = Path.Combine(fi.DirectoryName, fi.Name.Normalize());
                    args.AddRow(fi.FullName, fixedFullName, "파일");
                }
            }

            if (!args.IsIncludeDirectory)
            {
                return;
            }

            foreach (var di in directoryInfo.GetDirectories())
            {
                if (worker.CancellationPending)
                {
                    return;
                }
                if (args.IsIncludeSubDirectory)
                {
                    SearchWork(worker, args.Clone(di.FullName));
                }
                args.SetCurrentFileLable(di.Name);
                if (!di.FullName.IsNormalized())
                {
                    // 디렉토리를 나중에 넣는 이유는 서브 디렉토리의 변경이 먼저 되어야 하기 때문이다.
                    args.AddRow(di.FullName, di.FullName.Normalize(), "폴더");
                }
                
            }
        }

        private void BackgroundWorkerSeaching_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarSearching.Value = e.ProgressPercentage;
        }

        private void BackgroundWorkerSeaching_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void FormSearching_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSignalToBackgroundWorker();
        }
    }
}
