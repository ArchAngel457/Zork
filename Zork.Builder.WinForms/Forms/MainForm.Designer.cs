namespace Zork.Builder.WinForms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator separator1ToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorldAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentWorldsSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.recentWorldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchZorkConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.modifiedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.isModifiedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameTabPage = new System.Windows.Forms.TabPage();
            this.gameView = new Zork.Builder.WinForms.GameView();
            this.worldTabPage = new System.Windows.Forms.TabPage();
            this.worldView = new Zork.Builder.WinForms.WorldView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.recentlyUsedFiles = new Zork.Builder.WinForms.RecentlyUsedFiles(this.components);
            newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            separator1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gameTabPage.SuspendLayout();
            this.worldTabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newWorldToolStripMenuItem
            // 
            newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            newWorldToolStripMenuItem.Text = "&New World...";
            newWorldToolStripMenuItem.Click += new System.EventHandler(this.NewWorldToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            openWorldToolStripMenuItem.Text = "&Open World...";
            openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // separator1ToolStripMenuItem
            // 
            separator1ToolStripMenuItem.Name = "separator1ToolStripMenuItem";
            separator1ToolStripMenuItem.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            aboutToolStripMenuItem});
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newWorldToolStripMenuItem,
            openWorldToolStripMenuItem,
            this.closeWorldToolStripMenuItem,
            separator1ToolStripMenuItem,
            this.saveWorldToolStripMenuItem,
            this.saveWorldAsToolStripMenuItem,
            this.recentWorldsSeperator,
            this.recentWorldsToolStripMenuItem,
            this.separator2ToolStripMenuItem,
            exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.closeWorldToolStripMenuItem.Text = "&Close World";
            this.closeWorldToolStripMenuItem.Click += new System.EventHandler(this.CloseWorldToolStripMenuItem_Click);
            // 
            // saveWorldToolStripMenuItem
            // 
            this.saveWorldToolStripMenuItem.Name = "saveWorldToolStripMenuItem";
            this.saveWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveWorldToolStripMenuItem.Text = "&Save World";
            this.saveWorldToolStripMenuItem.Click += new System.EventHandler(this.SaveWorldToolStripMenuItem_Click);
            // 
            // saveWorldAsToolStripMenuItem
            // 
            this.saveWorldAsToolStripMenuItem.Name = "saveWorldAsToolStripMenuItem";
            this.saveWorldAsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveWorldAsToolStripMenuItem.Text = "Save World &As...";
            this.saveWorldAsToolStripMenuItem.Click += new System.EventHandler(this.SaveWorldAsToolStripMenuItem_Click);
            // 
            // recentWorldsSeperator
            // 
            this.recentWorldsSeperator.Name = "recentWorldsSeperator";
            this.recentWorldsSeperator.Size = new System.Drawing.Size(187, 6);
            // 
            // recentWorldsToolStripMenuItem
            // 
            this.recentWorldsToolStripMenuItem.Name = "recentWorldsToolStripMenuItem";
            this.recentWorldsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.recentWorldsToolStripMenuItem.Text = "&Recent Worlds";
            // 
            // separator2ToolStripMenuItem
            // 
            this.separator2ToolStripMenuItem.Name = "separator2ToolStripMenuItem";
            this.separator2ToolStripMenuItem.Size = new System.Drawing.Size(187, 6);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.runToolStripMenuItem,
            helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(528, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchZorkConsoleToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.runToolStripMenuItem.Text = "&Run";
            // 
            // launchZorkConsoleToolStripMenuItem
            // 
            this.launchZorkConsoleToolStripMenuItem.Name = "launchZorkConsoleToolStripMenuItem";
            this.launchZorkConsoleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.launchZorkConsoleToolStripMenuItem.Text = "&Launch Zork Console...";
            this.launchZorkConsoleToolStripMenuItem.Click += new System.EventHandler(this.LaunchZorkConsoleToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.optionsToolStripMenuItem.Text = "&Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OptionsToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifiedToolStripStatusLabel,
            this.isModifiedToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 506);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(528, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            // 
            // modifiedToolStripStatusLabel
            // 
            this.modifiedToolStripStatusLabel.Name = "modifiedToolStripStatusLabel";
            this.modifiedToolStripStatusLabel.Size = new System.Drawing.Size(58, 17);
            this.modifiedToolStripStatusLabel.Text = "Modified:";
            // 
            // isModifiedToolStripStatusLabel
            // 
            this.isModifiedToolStripStatusLabel.Name = "isModifiedToolStripStatusLabel";
            this.isModifiedToolStripStatusLabel.Size = new System.Drawing.Size(23, 17);
            this.isModifiedToolStripStatusLabel.Text = "No";
            // 
            // gameTabPage
            // 
            this.gameTabPage.Controls.Add(this.gameView);
            this.gameTabPage.Location = new System.Drawing.Point(4, 22);
            this.gameTabPage.Name = "gameTabPage";
            this.gameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameTabPage.Size = new System.Drawing.Size(520, 456);
            this.gameTabPage.TabIndex = 1;
            this.gameTabPage.Text = "Game";
            this.gameTabPage.UseVisualStyleBackColor = true;
            // 
            // gameView
            // 
            this.gameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameView.Enabled = false;
            this.gameView.Location = new System.Drawing.Point(3, 3);
            this.gameView.Name = "gameView";
            this.gameView.Size = new System.Drawing.Size(514, 450);
            this.gameView.TabIndex = 0;
            this.gameView.ViewModel = null;
            // 
            // worldTabPage
            // 
            this.worldTabPage.Controls.Add(this.worldView);
            this.worldTabPage.Location = new System.Drawing.Point(4, 22);
            this.worldTabPage.Name = "worldTabPage";
            this.worldTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.worldTabPage.Size = new System.Drawing.Size(520, 456);
            this.worldTabPage.TabIndex = 0;
            this.worldTabPage.Text = "World";
            this.worldTabPage.UseVisualStyleBackColor = true;
            // 
            // worldView
            // 
            this.worldView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worldView.Enabled = false;
            this.worldView.Location = new System.Drawing.Point(3, 3);
            this.worldView.Name = "worldView";
            this.worldView.SelectedRoom = null;
            this.worldView.Size = new System.Drawing.Size(514, 450);
            this.worldView.StartingLocation = null;
            this.worldView.TabIndex = 0;
            this.worldView.ViewModel = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.worldTabPage);
            this.tabControl1.Controls.Add(this.gameTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(528, 482);
            this.tabControl1.TabIndex = 1;
            // 
            // recentlyUsedFiles
            // 
            this.recentlyUsedFiles.Files = ((System.Collections.Generic.List<System.IO.FileInfo>)(resources.GetObject("recentlyUsedFiles.Files")));
            this.recentlyUsedFiles.MaxFileCount = 4;
            this.recentlyUsedFiles.Menu = this.recentWorldsToolStripMenuItem;
            this.recentlyUsedFiles.MenuItemClicked += new System.EventHandler(this.RecentlyUsedFiles_MenuItemClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 528);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gameTabPage.ResumeLayout(false);
            this.worldTabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveWorldAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator2ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabPage gameTabPage;
        private System.Windows.Forms.TabPage worldTabPage;
        private System.Windows.Forms.TabControl tabControl1;
        private GameView gameView;
        private System.Windows.Forms.ToolStripStatusLabel modifiedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel isModifiedToolStripStatusLabel;
        private WorldView worldView;
        private System.Windows.Forms.ToolStripMenuItem closeWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator recentWorldsSeperator;
        private System.Windows.Forms.ToolStripMenuItem recentWorldsToolStripMenuItem;
        private RecentlyUsedFiles recentlyUsedFiles;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchZorkConsoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

