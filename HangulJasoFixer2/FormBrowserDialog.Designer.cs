namespace HangulJasoFixer2
{
    partial class FormBrowserDialog
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBrowserDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.checkBoxSearchAlsoSubdirectories = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeDir = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.groupBoxSearching = new System.Windows.Forms.GroupBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxSearching.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "자소가 분리되어 있는 파일이 들어있는 폴더 경로를 입력하십시오.";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(12, 68);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(33, 12);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "경로:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(54, 65);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(437, 21);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.TextChanged += new System.EventHandler(this.TextBoxPath_TextChanged);
            // 
            // checkBoxSearchAlsoSubdirectories
            // 
            this.checkBoxSearchAlsoSubdirectories.AutoSize = true;
            this.checkBoxSearchAlsoSubdirectories.Checked = true;
            this.checkBoxSearchAlsoSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSearchAlsoSubdirectories.Location = new System.Drawing.Point(20, 20);
            this.checkBoxSearchAlsoSubdirectories.Name = "checkBoxSearchAlsoSubdirectories";
            this.checkBoxSearchAlsoSubdirectories.Size = new System.Drawing.Size(104, 16);
            this.checkBoxSearchAlsoSubdirectories.TabIndex = 2;
            this.checkBoxSearchAlsoSubdirectories.Text = "하위 폴더 검색";
            this.checkBoxSearchAlsoSubdirectories.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeDir
            // 
            this.checkBoxIncludeDir.AutoSize = true;
            this.checkBoxIncludeDir.Checked = true;
            this.checkBoxIncludeDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeDir.Location = new System.Drawing.Point(147, 20);
            this.checkBoxIncludeDir.Name = "checkBoxIncludeDir";
            this.checkBoxIncludeDir.Size = new System.Drawing.Size(112, 16);
            this.checkBoxIncludeDir.TabIndex = 3;
            this.checkBoxIncludeDir.Text = "디렉토리도 찾기";
            this.checkBoxIncludeDir.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(416, 152);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "검색(&S)";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(375, 16);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(96, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "찾아보기(&B)...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // groupBoxSearching
            // 
            this.groupBoxSearching.Controls.Add(this.checkBoxSearchAlsoSubdirectories);
            this.groupBoxSearching.Controls.Add(this.buttonBrowse);
            this.groupBoxSearching.Controls.Add(this.checkBoxIncludeDir);
            this.groupBoxSearching.Location = new System.Drawing.Point(14, 92);
            this.groupBoxSearching.Name = "groupBoxSearching";
            this.groupBoxSearching.Size = new System.Drawing.Size(477, 54);
            this.groupBoxSearching.TabIndex = 9;
            this.groupBoxSearching.TabStop = false;
            this.groupBoxSearching.Text = "검색";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = global::HangulJasoFixer2.Properties.Resources.Jaso48px;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogo.Location = new System.Drawing.Point(14, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(49, 48);
            this.panelLogo.TabIndex = 10;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // FormBrowserDialog
            // 
            this.AcceptButton = this.buttonSearch;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 187);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.groupBoxSearching);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(519, 226);
            this.Name = "FormBrowserDialog";
            this.ShowIcon = false;
            this.Text = "자소 합치기2 (Mac OS X → Windows)";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormBegin_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormBegin_DragEnter);
            this.groupBoxSearching.ResumeLayout(false);
            this.groupBoxSearching.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.CheckBox checkBoxSearchAlsoSubdirectories;
        private System.Windows.Forms.CheckBox checkBoxIncludeDir;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.GroupBox groupBoxSearching;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

