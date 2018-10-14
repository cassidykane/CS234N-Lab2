namespace CustomerMaintenance
{
    partial class frmCloneCustomer
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
            this.customerLabel = new System.Windows.Forms.Label();
            this.copiesLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.clonesListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.copiesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerLabel
            // 
            this.customerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerLabel.Location = new System.Drawing.Point(38, 27);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(256, 42);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "label1";
            this.customerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copiesLabel
            // 
            this.copiesLabel.AutoSize = true;
            this.copiesLabel.Location = new System.Drawing.Point(71, 93);
            this.copiesLabel.Name = "copiesLabel";
            this.copiesLabel.Size = new System.Drawing.Size(55, 17);
            this.copiesLabel.TabIndex = 2;
            this.copiesLabel.Text = "Copies:";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(189, 89);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(79, 35);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Clone";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // clonesListBox
            // 
            this.clonesListBox.FormattingEnabled = true;
            this.clonesListBox.ItemHeight = 16;
            this.clonesListBox.Location = new System.Drawing.Point(38, 150);
            this.clonesListBox.Name = "clonesListBox";
            this.clonesListBox.Size = new System.Drawing.Size(256, 196);
            this.clonesListBox.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(335, 295);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // copiesTextBox
            // 
            this.copiesTextBox.Location = new System.Drawing.Point(132, 95);
            this.copiesTextBox.Name = "copiesTextBox";
            this.copiesTextBox.Size = new System.Drawing.Size(46, 22);
            this.copiesTextBox.TabIndex = 6;
            // 
            // frmCloneCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 366);
            this.Controls.Add(this.copiesTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clonesListBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.copiesLabel);
            this.Controls.Add(this.customerLabel);
            this.Name = "frmCloneCustomer";
            this.Text = "frmCloneCustomer";
            this.Load += new System.EventHandler(this.frmCloneCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label copiesLabel;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.ListBox clonesListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox copiesTextBox;
    }
}