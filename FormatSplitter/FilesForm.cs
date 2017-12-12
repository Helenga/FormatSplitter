using System;
using System.Windows.Forms;
using FormatSplitterCore;
using System.Diagnostics;

namespace FormatSplitter
{
    public partial class FilesForm : Form
    {
        public FilesForm(string extension)
        {
            _extension = extension;
            InitializeComponent();
        }

        private string _extension;
        private OriginatedDirectoriesTree originatedDirectoriesTree = new OriginatedDirectoriesTree();

        private void button_GoBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FilesForm_Load(object sender, EventArgs e)
        {
            var files = originatedDirectoriesTree.GetFilesWithExtension(_extension);
            listBox_SelectedFiles.Items.Clear();
            foreach (var file in files)
            {
                listBox_SelectedFiles.Items.Add(file);
            }
        }

        private void listBox_SelectedFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //menuStrip_actions.Visible = true;
            }
        }

        private void listBox_SelectedFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var fileToOpen = listBox_SelectedFiles.Items[listBox_SelectedFiles.SelectedIndex];
            var path = listBox_SelectedFiles.GetItemText(fileToOpen);
            Process.Start(path);
        }
    }
}
