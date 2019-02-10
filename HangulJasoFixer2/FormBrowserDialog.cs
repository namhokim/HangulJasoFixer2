using System;
using System.IO;
using System.Windows.Forms;

namespace HangulJasoFixer2
{
    public partial class FormBrowserDialog : Form
    {
        public string RootPath { get { return textBoxPath.Text; } }
        public bool IsIncludeSubDirectory { get { return checkBoxSearchAlsoSubdirectories.Checked; } }
        public bool IsIncludeDirectory { get { return checkBoxIncludeDir.Checked; } }

        // fixed size: https://stackoverflow.com/questions/2910537/how-can-i-fix-the-form-size-in-a-c-sharp-windows-forms-application-and-not-to-le
        // Default button: https://stackoverflow.com/questions/4280221/default-button-property-in-winform-app
        public FormBrowserDialog()
        {
            InitializeComponent();
        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        // Drag event: https://stackoverflow.com/questions/26628492/drag-and-drop-not-working-in-c-sharp-winforms-application
        private void FormBegin_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        // https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.control.allowdrop?view=netframework-4.7.2
        private void FormBegin_DragDrop(object sender, DragEventArgs e)
        {
            // Handle FileDrop data.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Assign the file names to a string array, in 
                // case the user has selected multiple files.
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                try
                {
                    // https://stackoverflow.com/questions/3812289/is-there-any-way-to-get-a-file-name-from-a-path
                    string path = Path.GetDirectoryName(files[0]);
                    textBoxPath.Text = path;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void TextBoxPath_TextChanged(object sender, EventArgs e)
        {
            // cast & sender: https://stackoverflow.com/questions/14337057/how-to-get-the-new-text-in-textchanged
            TextBox textBox = sender as TextBox;
            buttonSearch.Enabled = Directory.Exists(textBox.Text);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            // https://docs.microsoft.com/ko-kr/dotnet/api/system.windows.forms.folderbrowserdialog?view=netframework-4.7.2
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
 
}
