namespace Zork.Builder.WinForms
{
    partial class GameView
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
            System.Windows.Forms.Label welcomeMessageLabel;
            System.Windows.Forms.Label filenameLabel;
            System.Windows.Forms.Label nameLabel;
            this.welcomeMessageTextBox = new System.Windows.Forms.TextBox();
            this.gameViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filenameTextbox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            welcomeMessageLabel = new System.Windows.Forms.Label();
            filenameLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeMessageLabel
            // 
            welcomeMessageLabel.AutoSize = true;
            welcomeMessageLabel.Location = new System.Drawing.Point(3, 88);
            welcomeMessageLabel.Name = "welcomeMessageLabel";
            welcomeMessageLabel.Size = new System.Drawing.Size(101, 13);
            welcomeMessageLabel.TabIndex = 4;
            welcomeMessageLabel.Text = "Welcome &Message:";
            // 
            // filenameLabel
            // 
            filenameLabel.AutoSize = true;
            filenameLabel.Location = new System.Drawing.Point(3, 10);
            filenameLabel.Name = "filenameLabel";
            filenameLabel.Size = new System.Drawing.Size(52, 13);
            filenameLabel.TabIndex = 0;
            filenameLabel.Text = "Fi&lename:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(3, 49);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "&Name:";
            // 
            // welcomeMessageTextBox
            // 
            this.welcomeMessageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeMessageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "Game.WelcomeMessage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.welcomeMessageTextBox.Location = new System.Drawing.Point(6, 104);
            this.welcomeMessageTextBox.Name = "welcomeMessageTextBox";
            this.welcomeMessageTextBox.Size = new System.Drawing.Size(373, 20);
            this.welcomeMessageTextBox.TabIndex = 5;
            // 
            // gameViewModelBindingSource
            // 
            this.gameViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.GameViewModel);
            // 
            // filenameTextbox
            // 
            this.filenameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filenameTextbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "FullPath", true));
            this.filenameTextbox.Location = new System.Drawing.Point(6, 26);
            this.filenameTextbox.Name = "filenameTextbox";
            this.filenameTextbox.ReadOnly = true;
            this.filenameTextbox.Size = new System.Drawing.Size(373, 20);
            this.filenameTextbox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameViewModelBindingSource, "Game.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.Location = new System.Drawing.Point(6, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(373, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.welcomeMessageTextBox);
            this.Controls.Add(welcomeMessageLabel);
            this.Controls.Add(this.filenameTextbox);
            this.Controls.Add(filenameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(nameLabel);
            this.Name = "GameView";
            this.Size = new System.Drawing.Size(392, 146);
            ((System.ComponentModel.ISupportInitialize)(this.gameViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox welcomeMessageTextBox;
        private System.Windows.Forms.TextBox filenameTextbox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource gameViewModelBindingSource;
    }
}
