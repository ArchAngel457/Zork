namespace Zork.Builder.WinForms
{
    partial class WorldView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label startingLocationLabel;
            System.Windows.Forms.Label roomsLabel;
            System.Windows.Forms.Label roomNameLabel;
            System.Windows.Forms.Label roomDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldView));
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.selectedRoomGroupBox = new System.Windows.Forms.GroupBox();
            this.roomNeighborsGroupBox = new System.Windows.Forms.GroupBox();
            this.northNeighborView = new Zork.Builder.WinForms.NeighborView();
            this.southNeighborView = new Zork.Builder.WinForms.NeighborView();
            this.eastNeighborView = new Zork.Builder.WinForms.NeighborView();
            this.westNeighborView = new Zork.Builder.WinForms.NeighborView();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.selectedRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recentlyUsedFiles = new Zork.Builder.WinForms.RecentlyUsedFiles(this.components);
            this.startingLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            startingLocationLabel = new System.Windows.Forms.Label();
            roomsLabel = new System.Windows.Forms.Label();
            roomNameLabel = new System.Windows.Forms.Label();
            roomDescriptionLabel = new System.Windows.Forms.Label();
            this.selectedRoomGroupBox.SuspendLayout();
            this.roomNeighborsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingLocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startingLocationLabel
            // 
            startingLocationLabel.AutoSize = true;
            startingLocationLabel.Location = new System.Drawing.Point(3, 10);
            startingLocationLabel.Name = "startingLocationLabel";
            startingLocationLabel.Size = new System.Drawing.Size(90, 13);
            startingLocationLabel.TabIndex = 0;
            startingLocationLabel.Text = "&Starting Location:";
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Location = new System.Drawing.Point(3, 49);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new System.Drawing.Size(43, 13);
            roomsLabel.TabIndex = 2;
            roomsLabel.Text = "&Rooms:";
            // 
            // roomNameLabel
            // 
            roomNameLabel.AutoSize = true;
            roomNameLabel.Location = new System.Drawing.Point(6, 16);
            roomNameLabel.Name = "roomNameLabel";
            roomNameLabel.Size = new System.Drawing.Size(38, 13);
            roomNameLabel.TabIndex = 0;
            roomNameLabel.Text = "&Name:";
            // 
            // roomDescriptionLabel
            // 
            roomDescriptionLabel.AutoSize = true;
            roomDescriptionLabel.Location = new System.Drawing.Point(6, 55);
            roomDescriptionLabel.Name = "roomDescriptionLabel";
            roomDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            roomDescriptionLabel.TabIndex = 2;
            roomDescriptionLabel.Text = "&Description:";
            // 
            // roomsListBox
            // 
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.Location = new System.Drawing.Point(6, 66);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.Size = new System.Drawing.Size(156, 342);
            this.roomsListBox.TabIndex = 3;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(7, 420);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(88, 420);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // selectedRoomGroupBox
            // 
            this.selectedRoomGroupBox.Controls.Add(this.roomNeighborsGroupBox);
            this.selectedRoomGroupBox.Controls.Add(this.roomDescriptionTextBox);
            this.selectedRoomGroupBox.Controls.Add(roomDescriptionLabel);
            this.selectedRoomGroupBox.Controls.Add(this.roomNameTextBox);
            this.selectedRoomGroupBox.Controls.Add(roomNameLabel);
            this.selectedRoomGroupBox.Location = new System.Drawing.Point(169, 66);
            this.selectedRoomGroupBox.Name = "selectedRoomGroupBox";
            this.selectedRoomGroupBox.Size = new System.Drawing.Size(340, 377);
            this.selectedRoomGroupBox.TabIndex = 6;
            this.selectedRoomGroupBox.TabStop = false;
            // 
            // roomNeighborsGroupBox
            // 
            this.roomNeighborsGroupBox.Controls.Add(this.northNeighborView);
            this.roomNeighborsGroupBox.Controls.Add(this.southNeighborView);
            this.roomNeighborsGroupBox.Controls.Add(this.eastNeighborView);
            this.roomNeighborsGroupBox.Controls.Add(this.westNeighborView);
            this.roomNeighborsGroupBox.Location = new System.Drawing.Point(9, 150);
            this.roomNeighborsGroupBox.Name = "roomNeighborsGroupBox";
            this.roomNeighborsGroupBox.Size = new System.Drawing.Size(319, 218);
            this.roomNeighborsGroupBox.TabIndex = 4;
            this.roomNeighborsGroupBox.TabStop = false;
            this.roomNeighborsGroupBox.Text = "&Neighbors";
            // 
            // northNeighborView
            // 
            this.northNeighborView.Direction = Zork.Directions.North;
            this.northNeighborView.Location = new System.Drawing.Point(113, 19);
            this.northNeighborView.Name = "northNeighborView";
            this.northNeighborView.Neighbor = null;
            this.northNeighborView.Room = null;
            this.northNeighborView.Size = new System.Drawing.Size(93, 76);
            this.northNeighborView.TabIndex = 0;
            this.northNeighborView.ViewModel = null;
            // 
            // southNeighborView
            // 
            this.southNeighborView.Direction = Zork.Directions.South;
            this.southNeighborView.Location = new System.Drawing.Point(113, 136);
            this.southNeighborView.Name = "southNeighborView";
            this.southNeighborView.Neighbor = null;
            this.southNeighborView.Room = null;
            this.southNeighborView.Size = new System.Drawing.Size(93, 76);
            this.southNeighborView.TabIndex = 2;
            this.southNeighborView.ViewModel = null;
            // 
            // eastNeighborView
            // 
            this.eastNeighborView.Direction = Zork.Directions.East;
            this.eastNeighborView.Location = new System.Drawing.Point(220, 71);
            this.eastNeighborView.Name = "eastNeighborView";
            this.eastNeighborView.Neighbor = null;
            this.eastNeighborView.Room = null;
            this.eastNeighborView.Size = new System.Drawing.Size(93, 76);
            this.eastNeighborView.TabIndex = 1;
            this.eastNeighborView.ViewModel = null;
            // 
            // westNeighborView
            // 
            this.westNeighborView.Direction = Zork.Directions.West;
            this.westNeighborView.Location = new System.Drawing.Point(6, 71);
            this.westNeighborView.Name = "westNeighborView";
            this.westNeighborView.Neighbor = null;
            this.westNeighborView.Room = null;
            this.westNeighborView.Size = new System.Drawing.Size(93, 76);
            this.westNeighborView.TabIndex = 3;
            this.westNeighborView.ViewModel = null;
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedRoomBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(9, 71);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(319, 73);
            this.roomDescriptionTextBox.TabIndex = 3;
            // 
            // selectedRoomBindingSource
            // 
            this.selectedRoomBindingSource.DataSource = typeof(Zork.Room);
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.selectedRoomBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(319, 20);
            this.roomNameTextBox.TabIndex = 1;
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.startingLocationBindingSource, "Name", true));
            this.startingLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(7, 26);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(156, 21);
            this.startingLocationComboBox.TabIndex = 1;
            this.startingLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.StartingLocationComboBox_SelectedIndexChanged);
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.GameViewModel);
            // 
            // recentlyUsedFiles
            // 
            this.recentlyUsedFiles.Files = ((System.Collections.Generic.List<System.IO.FileInfo>)(resources.GetObject("recentlyUsedFiles.Files")));
            this.recentlyUsedFiles.MaxFileCount = 0;
            this.recentlyUsedFiles.Menu = null;
            // 
            // startingLocationBindingSource
            // 
            this.startingLocationBindingSource.DataSource = typeof(Zork.Room);
            // 
            // WorldView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startingLocationComboBox);
            this.Controls.Add(this.selectedRoomGroupBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.roomsListBox);
            this.Controls.Add(roomsLabel);
            this.Controls.Add(startingLocationLabel);
            this.Name = "WorldView";
            this.Size = new System.Drawing.Size(526, 455);
            this.selectedRoomGroupBox.ResumeLayout(false);
            this.selectedRoomGroupBox.PerformLayout();
            this.roomNeighborsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingLocationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox selectedRoomGroupBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private System.Windows.Forms.BindingSource selectedRoomBindingSource;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.GroupBox roomNeighborsGroupBox;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private NeighborView northNeighborView;
        private NeighborView southNeighborView;
        private NeighborView eastNeighborView;
        private NeighborView westNeighborView;
        private RecentlyUsedFiles recentlyUsedFiles;
        private System.Windows.Forms.BindingSource startingLocationBindingSource;
    }
}
