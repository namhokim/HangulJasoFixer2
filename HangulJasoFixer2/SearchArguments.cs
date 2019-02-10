using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HangulJasoFixer2
{
    class SearchArguments : SearchCriteria
    {
        private Label currentDisplayLabel;
        public SearchArguments(SearchCriteria searchCriteria, Label currentDisplayLabel) : base(searchCriteria.ListView())
        {
            this.RootPath = searchCriteria.RootPath;
            this.IsIncludeDirectory = searchCriteria.IsIncludeDirectory;
            this.IsIncludeSubDirectory = searchCriteria.IsIncludeSubDirectory;
            this.currentDisplayLabel = currentDisplayLabel;
        }

        public SearchArguments Clone(string rootPath)
        {
            return new SearchArguments(this, this.currentDisplayLabel)
            {
                RootPath = rootPath,
                IsIncludeDirectory = this.IsIncludeDirectory,
                IsIncludeSubDirectory = this.IsIncludeSubDirectory,
            };
        }

        public void SetCurrentFileLable(string name)
        {
            currentDisplayLabel.Text = name;
        }
    }
}
