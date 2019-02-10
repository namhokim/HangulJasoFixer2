namespace HangulJasoFixer2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.colHeaderOriginal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderMigration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHeaderFileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBrowser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExecute = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewFiles
            // 
            this.listViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFiles.CheckBoxes = true;
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeaderOriginal,
            this.colHeaderMigration,
            this.colHeaderFileType});
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.Location = new System.Drawing.Point(12, 28);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(810, 421);
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.Details;
            // 
            // colHeaderOriginal
            // 
            this.colHeaderOriginal.Text = "기존 이름";
            this.colHeaderOriginal.Width = 385;
            // 
            // colHeaderMigration
            // 
            this.colHeaderMigration.Text = "바꿀 이름";
            this.colHeaderMigration.Width = 359;
            // 
            // colHeaderFileType
            // 
            this.colHeaderFileType.Text = "타입";
            this.colHeaderFileType.Width = 39;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBrowser,
            this.toolStripButtonExecute,
            this.toolStripButtonInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(834, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonBrowser
            // 
            this.toolStripButtonBrowser.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButtonBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBrowser.Image = global::HangulJasoFixer2.Properties.Resources.toolbar;
            this.toolStripButtonBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBrowser.Name = "toolStripButtonBrowser";
            this.toolStripButtonBrowser.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBrowser.Text = "검색할 폴더를 변경합니다";
            this.toolStripButtonBrowser.Click += new System.EventHandler(this.ToolStripButtonBrowser_Click);
            // 
            // toolStripButtonExecute
            // 
            this.toolStripButtonExecute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExecute.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExecute.Image")));
            this.toolStripButtonExecute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExecute.Name = "toolStripButtonExecute";
            this.toolStripButtonExecute.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExecute.Text = "파일 이름을 변경합니다";
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfo.Image")));
            this.toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfo.Name = "toolStripButtonInfo";
            this.toolStripButtonInfo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInfo.Text = "프로그램 정보(버전 정보 등)를 표시합니다.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listViewFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "한글 자소 교정기2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader colHeaderOriginal;
        private System.Windows.Forms.ColumnHeader colHeaderMigration;
        private System.Windows.Forms.ColumnHeader colHeaderFileType;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBrowser;
        private System.Windows.Forms.ToolStripButton toolStripButtonExecute;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
    }
}