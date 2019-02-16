using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace HangulJasoFixer2
{
    public partial class FormChanging : Form
    {
        class WorkerArgument
        {
            public WorkerArgument(ListView listview, Label currentFileDisplayLabel)
            {
                this.Listview = listview;
                this.CurrentFileDisplayLabel = currentFileDisplayLabel;
            }
            public ListView Listview { get; }
            public Label CurrentFileDisplayLabel { get; }
        }

        private ListView listview;

        public FormChanging()
        {
            InitializeComponent();
        }

        public void SetCriteria(ListView listview)
        {
            this.listview = listview;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            StopSignalToBackgroundWorker();
            buttonCancel.Enabled = false;
        }

        private void StopSignalToBackgroundWorker()
        {
            if (backgroundWorkerRename.IsBusy)
            {
                backgroundWorkerRename.CancelAsync();
            }
        }

        private void FormChanging_Shown(object sender, EventArgs e)
        {
            WorkerArgument args = new WorkerArgument(listview, labelCurrentFile);
            backgroundWorkerRename.RunWorkerAsync(args);
        }

        private void BackgroundWorkerRename_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var arg = e.Argument as WorkerArgument;
            var currentFileDisplayLabel = arg.CurrentFileDisplayLabel;

            var listview = arg.Listview as ListView;
            var totalFileCount = listview.CheckedItems.Count;
            ChangeFiles(worker, listview.Items, totalFileCount, currentFileDisplayLabel);
        }

        private void ChangeFiles(BackgroundWorker worker, ListView.ListViewItemCollection items, int totalFileCount, Label currentFileDisplayLabel)
        {
            int processedCount = 0;
            foreach (ListViewItem item in items)
            {
                if (worker.CancellationPending)
                {
                    return;
                }
                if (!item.Checked)
                {
                    continue;
                }
                processedCount++;
                worker.ReportProgress(processedCount * 100 / totalFileCount);

                var original = item.SubItems[0].Text;
                var destination = item.SubItems[1].Text;

                currentFileDisplayLabel.Text = original;

                try
                {
                    Rename(original, destination);
                    items.Remove(item);
                }
                catch (Exception ex)
                {
                    item.SubItems[2].Text = ex.Message;
                }
            }
        }

        private void Rename(string original, string destination, bool isOverwrite = false)
        {
            if (isOverwrite)
            {
                var dfi = new FileInfo(destination);
                if (dfi.Exists)
                {
                    dfi.Delete();
                }
            }

            var ofi = new FileInfo(original);
            try
            {
                ofi.MoveTo(destination);
            }
            catch (IOException ex)
            {
                var dfi = new FileInfo(destination);
                if (dfi.Exists)
                {
                    var result = MessageBox.Show("이미 동일한 바뀔 파일명이 있습니다. 덮어쓰시겠습니까?",
                        "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        throw new IOException("바뀔 파일명과 동일한 파일이 존재합니다.");
                    }
                    Rename(original, destination, true);
                }
                throw ex;
            }
        }

        private void BackgroundWorkerRename_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarSearching.Value = e.ProgressPercentage;
        }

        private void BackgroundWorkerRename_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();
        }

        private void FormChanging_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopSignalToBackgroundWorker();
        }
    }
}
