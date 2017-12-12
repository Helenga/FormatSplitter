using System;
using System.Windows.Forms;
using FormatSplitterCore;

namespace FormatSplitter
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void button_GoBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            HelpProviderFS helpProvider = new HelpProviderFS();
            textBox_Help.Text = helpProvider.HelpInfo;
        }
    }
}
