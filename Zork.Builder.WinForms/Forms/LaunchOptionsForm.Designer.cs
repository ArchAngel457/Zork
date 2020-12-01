namespace Zork.Builder.WinForms
{
    partial class LaunchOptionsForm
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
            System.Windows.Forms.Button cancelButton;
            System.Windows.Forms.Button okButton;
            System.Windows.Forms.Label executableLabel;
            System.Windows.Forms.Button browseButton;
            System.Windows.Forms.Label argumentsLabel;
            this.executableTextBox = new System.Windows.Forms.TextBox();
            this.argumentsTextBox = new System.Windows.Forms.TextBox();
            cancelButton = new System.Windows.Forms.Button();
            okButton = new System.Windows.Forms.Button();
            executableLabel = new System.Windows.Forms.Label();
            browseButton = new System.Windows.Forms.Button();
            argumentsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(373, 152);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Location = new System.Drawing.Point(292, 152);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 5;
            okButton.Text = "&Ok";
            okButton.UseVisualStyleBackColor = true;
            // 
            // executableLabel
            // 
            executableLabel.AutoSize = true;
            executableLabel.Location = new System.Drawing.Point(12, 9);
            executableLabel.Name = "executableLabel";
            executableLabel.Size = new System.Drawing.Size(63, 13);
            executableLabel.TabIndex = 0;
            executableLabel.Text = "&Executable:";
            // 
            // executableTextBox
            // 
            this.executableTextBox.Location = new System.Drawing.Point(15, 25);
            this.executableTextBox.Name = "executableTextBox";
            this.executableTextBox.Size = new System.Drawing.Size(360, 20);
            this.executableTextBox.TabIndex = 1;
            // 
            // browseButton
            // 
            browseButton.Location = new System.Drawing.Point(381, 24);
            browseButton.Name = "browseButton";
            browseButton.Size = new System.Drawing.Size(67, 23);
            browseButton.TabIndex = 2;
            browseButton.Text = "&Browse...";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // argumentsTextBox
            // 
            this.argumentsTextBox.Location = new System.Drawing.Point(15, 74);
            this.argumentsTextBox.Multiline = true;
            this.argumentsTextBox.Name = "argumentsTextBox";
            this.argumentsTextBox.Size = new System.Drawing.Size(360, 67);
            this.argumentsTextBox.TabIndex = 4;
            // 
            // argumentsLabel
            // 
            argumentsLabel.AutoSize = true;
            argumentsLabel.Location = new System.Drawing.Point(12, 58);
            argumentsLabel.Name = "argumentsLabel";
            argumentsLabel.Size = new System.Drawing.Size(60, 13);
            argumentsLabel.TabIndex = 3;
            argumentsLabel.Text = "&Arguments:";
            // 
            // LaunchOptionsForm
            // 
            this.AcceptButton = okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelButton;
            this.ClientSize = new System.Drawing.Size(458, 187);
            this.Controls.Add(argumentsLabel);
            this.Controls.Add(this.argumentsTextBox);
            this.Controls.Add(browseButton);
            this.Controls.Add(this.executableTextBox);
            this.Controls.Add(executableLabel);
            this.Controls.Add(cancelButton);
            this.Controls.Add(okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LaunchOptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zork Console Launch Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox executableTextBox;
        private System.Windows.Forms.TextBox argumentsTextBox;
    }
}