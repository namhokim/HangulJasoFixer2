using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
            if (backgroundWorkerSeaching.IsBusy)
            {
                backgroundWorkerSeaching.CancelAsync();
            }
            buttonCancel.Enabled = false;
        }

        private void FormSearching_Shown(object sender, EventArgs e)
        {
            backgroundWorkerSeaching.RunWorkerAsync(searchArguments);
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
                args.AddRow(fi.FullName, fi.FullName, "파일");
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
                // add current directory
                args.SetCurrentFileLable(di.Name);
                args.AddRow(di.FullName, di.FullName, "폴더");
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

        
    }
}
