using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Zork.Builder.WinForms
{
    public partial class RecentlyUsedFiles : Component
    {
        public event EventHandler MenuItemClicked;

        public ToolStripMenuItem Menu { get; set; }

        public List<ToolStripMenuItem> MenuItems { get; private set; }

        public List<FileInfo> Files { get; set; }

        public int MaxFileCount { get; set; }

        public RecentlyUsedFiles(IContainer container = null) 
        {
            container.Add(this);
            InitializeComponent();

            MenuItems = new List<ToolStripMenuItem>();
            Files = new List<FileInfo>();
            MaxFileCount = DefaultMaxFileCount;
        }

        public void Load()
        {
            Files.Clear();
            var recentlyUsedFiles = Properties.Settings.Default.RecentlyUsedFiles;
            if (recentlyUsedFiles != null)
            {
                foreach (var filename in recentlyUsedFiles)
                {
                    Files.Add(new FileInfo(filename));
                }
            }

            UpdateMenuItems();
        }

        public void Save()
        {
            Properties.Settings.Default.RecentlyUsedFiles = new StringCollection();
            Properties.Settings.Default.RecentlyUsedFiles.AddRange(Files.Select(file => file.FullName).ToArray());
            Properties.Settings.Default.Save();
        }

        public void AddFile(string filename)
        {
            var file = Files.FirstOrDefault(f => f.FullName == filename);
            if (file != null)
            {
                Files.Remove(file);
            }

            Files.Insert(0, new FileInfo(filename));

            if (Files.Count > MaxFileCount)
            {
                Files.RemoveAt(Files.Count - 1);
            }

            UpdateMenuItems();
        }

        public void RemoveFile(string filename)
        {
            var file = Files.FirstOrDefault(f => f.FullName == filename);
            if (file != null)
            {
                Files.Remove(file);
                UpdateMenuItems();
            }
        }

        private void UpdateMenuItems()
        {
            foreach (ToolStripMenuItem menuItem in MenuItems)
            {
                Menu.DropDownItems.Remove(menuItem);
            }

            if (Files.Count > 0)
            {
                int counter = 1;
                MenuItems = (from file in Files
                             select new ToolStripMenuItem
                             {
                                 Text = $"&{counter++} {file.Name}",
                                 Visible = true,
                                 Tag = file,
                             }
                                ).ToList();

                foreach (var menuItem in MenuItems)
                {
                    menuItem.Click += MenuItem_Click;
                }

                Menu.DropDownItems.AddRange(MenuItems.ToArray());
            }
        }

        private void MenuItem_Click(object sender, EventArgs e) => MenuItemClicked?.Invoke(sender, e);

        private const int DefaultMaxFileCount = 4;
    }
}