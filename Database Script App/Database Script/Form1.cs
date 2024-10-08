using System.Text;

namespace Database_Script
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    txtFilePath.Text = selectedPath;
                }
            }
        }

        private void btnCreateScript_Click(object sender, EventArgs e)
        {
            MergeFiles();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        void MergeFiles()
        {
             string selectedPath = txtFilePath.Text;
             string[] sqlFiles = Directory.GetFiles(selectedPath, "*.sql", SearchOption.AllDirectories);
             StringBuilder mergedContent = new StringBuilder();

             foreach (string file in sqlFiles)
             {
                 mergedContent.AppendLine(File.ReadAllText(file));
             }

             txtMergedFile.Clear();
             txtMergedFile.Text = mergedContent.ToString();
        }

        void SaveFile()
        {
            string fileContent = txtMergedFile.Text; ;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "sql";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, fileContent);
                    MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

       
    }
}
