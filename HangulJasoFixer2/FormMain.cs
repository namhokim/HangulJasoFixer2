using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
