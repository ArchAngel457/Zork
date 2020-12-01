using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Zork.Builder.WinForms
{
    internal partial class MainForm : Form
    {
        public bool IsWorldLoaded
        {
            get => mIsWorldLoaded;
            private set
            {
                mIsWorldLoaded = value;
                foreach (var control in mControlsRequiringLoadedWorld)
                {
                    control.Enabled = value;
                }

                foreach (var menuItem in mToolStripMenuItemsRequiringLoadedWorld)
                {
                    menuItem.Enabled = value;
                }
            }
        }

        public static string AssemblyTitle => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        public MainForm()
        {
            InitializeComponent();
            InitializeViewModels();

            mControlsRequiringLoadedWorld = new List<Control>(new Control[] { gameView, worldView });
            mToolStripMenuItemsRequiringLoadedWorld = new List<ToolStripMenuItem>(new ToolStripMenuItem[] { closeWorldToolStripMenuItem, saveWorldToolStripMenuItem, saveWorldAsToolStripMenuItem });
            IsWorldLoaded = false;

            recentlyUsedFiles.Load();
            recentWorldsSeperator.Visible = recentWorldsToolStripMenuItem.Visible = recentlyUsedFiles.Files.Count > 0;

            launchZorkConsoleToolStripMenuItem.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.ZorkConsoleExecutable);
        }

        private void InitializeViewModels()
        {
            mGameViewModel = new GameViewModel();
            mGameViewModel.PropertyChanged += (sender, e) => isModifiedToolStripStatusLabel.Text = mGameViewModel.IsModified ? "Yes" : "No";
            gameView.ViewModel = mGameViewModel;
            worldView.ViewModel = mGameViewModel;
        }

        private void NewWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mGameViewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified world?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveWorld() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            mGameViewModel.Game = new Game
            {
                World = new World()
            };
            mGameViewModel.FullPath = null;
            mGameViewModel.IsModified = true;
            IsWorldLoaded = true;
            worldView.RefreshData();
            UpdateTitle();
        }

        private void OpenWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mGameViewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified world?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveWorld() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Zork files (*.json)|*.json";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    OpenWorld(dialog.FileName);
                }
            }
        }

        private void CloseWorldToolStripMenuItem_Click(object sender, EventArgs e) => CloseWorld();

        private void SaveWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveWorld();
            UpdateTitle();
        }

        private void SaveWorldAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Zork files (*.json)|*.json";
                dialog.Title = "Save World As";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    mGameViewModel.FullPath = dialog.FileName;
                    SaveWorld();
                    UpdateTitle();
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutBox = new AboutBox())
            {
                aboutBox.ShowDialog();
            }
        }

        private void RecentlyUsedFiles_MenuItemClicked(object sender, EventArgs e) => OpenWorld(((FileInfo)((ToolStripMenuItem)sender).Tag).FullName);

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mGameViewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified world?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveWorld() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }

            recentlyUsedFiles.Save();
        }

        private void LaunchZorkConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = Properties.Settings.Default.ZorkConsoleExecutable,
                    Arguments = Properties.Settings.Default.ZorkConsoleArguments,
                    WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.ZorkConsoleExecutable),
                    UseShellExecute = false
                };

                Process.Start(processStartInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Launching Zork Console");
            }
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var launchOptionsForm = new LaunchOptionsForm())
            {
                if (launchOptionsForm.ShowDialog() == DialogResult.OK)
                {
                    launchOptionsForm.Save();
                    launchZorkConsoleToolStripMenuItem.Enabled = !string.IsNullOrEmpty(Properties.Settings.Default.ZorkConsoleExecutable);
                }
            }
        }

        private void OpenWorld(string filename)
        {
            Assert.ArgumentIsNotNull(filename, nameof(filename));

            try
            {
                Cursor = Cursors.WaitCursor;

                mGameViewModel.Game = Game.Load(filename);
                mGameViewModel.FullPath = filename;
                mGameViewModel.IsModified = false;
                worldView.RefreshData();
                recentlyUsedFiles.AddFile(filename);
                recentWorldsSeperator.Visible = recentWorldsToolStripMenuItem.Visible = recentlyUsedFiles.Files.Count > 0;
                Cursor = Cursors.Default;
                IsWorldLoaded = true;
                UpdateTitle();
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Error Opening World");
                CloseWorld(false);
            }
        }

        private void CloseWorld(bool promptForSave = true)
        {
            if (promptForSave && mGameViewModel.IsModified)
            {
                DialogResult result = MessageBox.Show("Save modified world?", AssemblyTitle, MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (SaveWorld() == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    return;   
                }
            }

            mGameViewModel.Game = null;
            mGameViewModel.FullPath = null;
            mGameViewModel.IsModified = false;
            IsWorldLoaded = false;
            worldView.RefreshData();
            UpdateTitle();
        }

        private DialogResult SaveWorld()
        {
            Assert.IsTrue(IsWorldLoaded);

            if (string.IsNullOrEmpty(mGameViewModel.FullPath))
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "Zork files (*.json)|*.json";
                    dialog.Title = "Save World As";

                    DialogResult result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        mGameViewModel.FullPath = dialog.FileName;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return result;
                    }
                }
            }

            Assert.IsTrue(!string.IsNullOrEmpty(mGameViewModel.FullPath));
            mGameViewModel.Game.Save(mGameViewModel.FullPath);
            mGameViewModel.IsModified = false;
            recentlyUsedFiles.AddFile(mGameViewModel.FullPath);
            return DialogResult.OK;
        }

        private void UpdateTitle()
        {
            string filename = IsWorldLoaded ? $"- {mGameViewModel.Filename}" : null;
            Text = $"{AssemblyTitle}{filename}";
        }

        private GameViewModel mGameViewModel;
        private readonly List<Control> mControlsRequiringLoadedWorld;
        private readonly List<ToolStripMenuItem> mToolStripMenuItemsRequiringLoadedWorld;
        private bool mIsWorldLoaded;
    }
}