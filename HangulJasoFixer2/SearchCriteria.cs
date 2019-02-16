using System;
using System.Windows.Forms;

namespace HangulJasoFixer2
{
    public class SearchCriteria
    {
        private readonly ListView listView;

        public string RootPath { get; set; }
        public bool IsIncludeSubDirectory { get; set; }
        public bool IsIncludeDirectory { get; set; }

        public ListView ListView()
        {
            return this.listView;
        }

        public SearchCriteria(ListView listview)
        {
            this.listView = listview;
        }

        public void AddRow(string originalFile, string outputFile, string type)
        {
            string[] row = { originalFile, outputFile, type };
            if (this.listView.InvokeRequired)
            {
                this.listView.Invoke(new Action(() => { this.listView.Items.Add(new ListViewItem(row)); }));
            }
            else
            {
                this.listView.Items.Add(new ListViewItem(row));
            }
        }

        public void ClearRows()
        {
            if (this.listView.InvokeRequired)
            {
                this.listView.Invoke(new Action(() => { this.listView.Items.Clear(); }));
            } else
            {
                this.listView.Items.Clear();
            }
        }
    }
}
