using System;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    internal partial class LaunchOptionsForm : Form
    {
        public string Executable
        {
            get => executableTextBox.Text; 
            set => executableTextBox.Text = value;
        }

        public string Arguments
        {
            get => argumentsTextBox.Text;
            set => argumentsTextBox.Text = value;
        }

        public LaunchOptionsForm()
        {
            InitializeComponent();
            RefreshData();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Executable files (*.exe)|*.exe";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Executable = dialog.FileName;
                }
            }
        }

        public void RefreshData()
        {
            Executable = Properties.Settings.Default.ZorkConsoleExecutable;
            Arguments = Properties.Settings.Default.ZorkConsoleArguments;
        }

        public void Save()
        {
            Properties.Settings.Default.ZorkConsoleExecutable = Executable;
            Properties.Settings.Default.ZorkConsoleArguments = Arguments;
        }
    }
}
