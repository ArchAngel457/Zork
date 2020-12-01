namespace Zork.Builder.WinForms
{
    partial class SelectNeighborForm
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
            System.Windows.Forms.Label roomLabel;
            System.Windows.Forms.Button cancelButton;
            System.Windows.Forms.Button okButton;
            System.Windows.Forms.Label directionLabel;
            this.roomsComboBox = new System.Windows.Forms.ComboBox();
            this.directionTextBox = new System.Windows.Forms.TextBox();
            roomLabel = new System.Windows.Forms.Label();
            cancelButton = new System.Windows.Forms.Button();
            okButton = new System.Windows.Forms.Button();
            directionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Location = new System.Drawing.Point(9, 49);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new System.Drawing.Size(38, 13);
            roomLabel.TabIndex = 2;
            roomLabel.Text = "&Room:";
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Location = new System.Drawing.Point(189, 92);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Location = new System.Drawing.Point(108, 92);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.TabIndex = 4;
            okButton.Text = "&Ok";
            okButton.UseVisualStyleBackColor = true;
            // 
            // directionLabel
            // 
            directionLabel.AutoSize = true;
            directionLabel.Location = new System.Drawing.Point(9, 9);
            directionLabel.Name = "directionLabel";
            directionLabel.Size = new System.Drawing.Size(52, 13);
            directionLabel.TabIndex = 0;
            directionLabel.Text = "&Direction:";
            // 
            // roomsComboBox
            // 
            this.roomsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomsComboBox.FormattingEnabled = true;
            this.roomsComboBox.Location = new System.Drawing.Point(12, 65);
            this.roomsComboBox.Name = "roomsComboBox";
            this.roomsComboBox.Size = new System.Drawing.Size(252, 21);
            this.roomsComboBox.TabIndex = 3;
            // 
            // directionTextBox
            // 
            this.directionTextBox.Location = new System.Drawing.Point(12, 26);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.ReadOnly = true;
            this.directionTextBox.Size = new System.Drawing.Size(109, 20);
            this.directionTextBox.TabIndex = 1;
            this.directionTextBox.TabStop = false;
            // 
            // SelectNeighborForm
            // 
            this.AcceptButton = okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = cancelButton;
            this.ClientSize = new System.Drawing.Size(286, 126);
            this.Controls.Add(this.directionTextBox);
            this.Controls.Add(directionLabel);
            this.Controls.Add(roomLabel);
            this.Controls.Add(this.roomsComboBox);
            this.Controls.Add(cancelButton);
            this.Controls.Add(okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectNeighborForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Neighbor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox roomsComboBox;
        private System.Windows.Forms.TextBox directionTextBox;
    }
}