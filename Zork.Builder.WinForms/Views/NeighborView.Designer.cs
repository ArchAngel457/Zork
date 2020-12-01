namespace Zork.Builder.WinForms
{
    partial class NeighborView
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
            this.neighborLabel = new System.Windows.Forms.Label();
            this.selectNeighborButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // neighborLabel
            // 
            this.neighborLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.neighborLabel.Location = new System.Drawing.Point(0, 53);
            this.neighborLabel.Name = "neighborLabel";
            this.neighborLabel.Size = new System.Drawing.Size(93, 23);
            this.neighborLabel.TabIndex = 1;
            this.neighborLabel.Text = "Room Name";
            this.neighborLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectNeighborButton
            // 
            this.selectNeighborButton.Location = new System.Drawing.Point(18, 3);
            this.selectNeighborButton.Name = "selectNeighborButton";
            this.selectNeighborButton.Size = new System.Drawing.Size(56, 49);
            this.selectNeighborButton.TabIndex = 0;
            this.selectNeighborButton.Tag = "";
            this.selectNeighborButton.Text = "Dir";
            this.selectNeighborButton.UseVisualStyleBackColor = true;
            this.selectNeighborButton.Click += new System.EventHandler(this.SelectNeighborButton_Click);
            // 
            // NeighborView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborLabel);
            this.Controls.Add(this.selectNeighborButton);
            this.Name = "NeighborView";
            this.Size = new System.Drawing.Size(93, 76);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label neighborLabel;
        private System.Windows.Forms.Button selectNeighborButton;
    }
}
