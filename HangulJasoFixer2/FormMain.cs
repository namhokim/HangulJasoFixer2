using System;
using System.Windows.Forms;

namespace HangulJasoFixer2
{
    public partial class FormMain : Form
    {
        private SearchCriteria searchCriteria;

        public FormMain()
        {
            InitializeComponent();
            searchCriteria = new SearchCriteria(listViewFiles);
        }

        /// <summary>
        /// 탐색 다이얼로그를 표시합니다.
        /// </summary>
        /// <returns>취소를 눌렀는지 여부</returns>
        private bool ShowBrowserDialog()
        {
            FormBrowserDialog formBrowser = new FormBrowserDialog();
            DialogResult result = formBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                searchCriteria.RootPath = formBrowser.RootPath;
                searchCriteria.IsIncludeSubDirectory = formBrowser.IsIncludeSubDirectory;
                searchCriteria.IsIncludeDirectory = formBrowser.IsIncludeDirectory;
            }
            return result == DialogResult.Cancel;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (ShowBrowserDialog())
            {
                this.Close();
            }
            Search(searchCriteria);
        }

        private void ToolStripButtonBrowser_Click(object sender, EventArgs e)
        {
            if (!ShowBrowserDialog())
            {
                Search(searchCriteria);
            }
        }

        private void Search(SearchCriteria searchCriteria)
        {
            FormSearching formSearching = new FormSearching();
            formSearching.SetCriteria(searchCriteria);
            formSearching.ShowDialog();
        }

        private void ToolStripButtonExecute_Click(object sender, EventArgs e)
        {
            if (NoItemsInListViewFiles())
            {
                return;
            }
            if (NoCheckedItemInListViewFiles())
            {
                var result = MessageBox.Show("아무것도 선택하지 않았습니다. 목록 전체에 대해 수행하시겠습니까?",
                    "미선택: 질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
                SetCheckAll();
            }
            FormChanging formChanging = new FormChanging();
            formChanging.StartPosition = FormStartPosition.CenterParent;
            formChanging.SetCriteria(listViewFiles);
            formChanging.ShowDialog();
        }

        private bool NoItemsInListViewFiles()
        {
            return listViewFiles.Items.Count == 0;
        }

        private bool NoCheckedItemInListViewFiles()
        {
            return listViewFiles.CheckedItems.Count == 0;
        }

        private void SetCheckAll()
        {
            foreach (ListViewItem item in listViewFiles.Items)
            {
                item.Checked = true;
            }
        }

        private void ToolStripButtonInfo_Click(object sender, EventArgs e)
        {
            var formInfo = new FormInfo();
            formInfo.ShowDialog();
        }
    }
}
