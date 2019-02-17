namespace HangulJasoFixer2
{
    partial class FormSearching
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBarSearching = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerSearch = new System.ComponentModel.BackgroundWorker();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(396, 76);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "취소(&C)";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // progressBarSearching
            // 
            this.progressBarSearching.Location = new System.Drawing.Point(74, 52);
            this.progressBarSearching.MarqueeAnimationSpeed = 10;
            this.progressBarSearching.Name = "progressBarSearching";
            this.progressBarSearching.Size = new System.Drawing.Size(369, 18);
            this.progressBarSearching.Step = 30;
            this.progressBarSearching.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarSearching.TabIndex = 1;
            this.progressBarSearching.Value = 50;
            // 
            // backgroundWorkerSearch
            // 
            this.backgroundWorkerSearch.WorkerReportsProgress = true;
            this.backgroundWorkerSearch.WorkerSupportsCancellation = true;
            this.backgroundWorkerSearch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerSeaching_DoWork);
            this.backgroundWorkerSearch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerSeaching_ProgressChanged);
            this.backgroundWorkerSearch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorkerSeaching_RunWorkerCompleted);
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Location = new System.Drawing.Point(72, 19);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(153, 12);
            this.labelCurrentFile.TabIndex = 2;
            this.labelCurrentFile.Text = "{current file display zone}";
            // 
            // FormSearching
            // 
            this.AcceptButton = this.buttonCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.progressBarSearching);
            this.Controls.Add(this.buttonCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearching";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "검색중...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearching_FormClosing);
            this.Shown += new System.EventHandler(this.FormSearching_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar progressBarSearching;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSearch;
        private System.Windows.Forms.Label labelCurrentFile;
    }
}