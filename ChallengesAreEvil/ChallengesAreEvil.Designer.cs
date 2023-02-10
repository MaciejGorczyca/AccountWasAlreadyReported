﻿namespace ChallengesAreEvil
{
    partial class ChallengesAreEvilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChallengesAreEvilForm));
            this.removeTokensButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearPrintButton = new System.Windows.Forms.Button();
            this.nickTextBox = new System.Windows.Forms.TextBox();
            this.printTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // removeTokensButton
            // 
            this.removeTokensButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeTokensButton.Location = new System.Drawing.Point(0, 0);
            this.removeTokensButton.Margin = new System.Windows.Forms.Padding(0);
            this.removeTokensButton.Name = "removeTokensButton";
            this.removeTokensButton.Size = new System.Drawing.Size(632, 66);
            this.removeTokensButton.TabIndex = 0;
            this.removeTokensButton.Text = "Ban";
            this.removeTokensButton.UseVisualStyleBackColor = true;
            this.removeTokensButton.Click += new System.EventHandler(this.removeTokensButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.messageLabel.Location = new System.Drawing.Point(0, 92);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(632, 28);
            this.messageLabel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearPrintButton);
            this.panel1.Controls.Add(this.nickTextBox);
            this.panel1.Controls.Add(this.printTextBox);
            this.panel1.Controls.Add(this.removeTokensButton);
            this.panel1.Controls.Add(this.messageLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 609);
            this.panel1.TabIndex = 3;
            // 
            // clearPrintButton
            // 
            this.clearPrintButton.Location = new System.Drawing.Point(12, 568);
            this.clearPrintButton.Name = "clearPrintButton";
            this.clearPrintButton.Size = new System.Drawing.Size(608, 29);
            this.clearPrintButton.TabIndex = 4;
            this.clearPrintButton.Text = "Clear log";
            this.clearPrintButton.UseVisualStyleBackColor = true;
            this.clearPrintButton.Click += new System.EventHandler(this.clearPrintButton_Click);
            // 
            // nickTextBox
            // 
            this.nickTextBox.Location = new System.Drawing.Point(12, 69);
            this.nickTextBox.Name = "nickTextBox";
            this.nickTextBox.Size = new System.Drawing.Size(608, 20);
            this.nickTextBox.TabIndex = 3;
            // 
            // printTextBox
            // 
            this.printTextBox.Location = new System.Drawing.Point(12, 123);
            this.printTextBox.Multiline = true;
            this.printTextBox.Name = "printTextBox";
            this.printTextBox.Size = new System.Drawing.Size(608, 439);
            this.printTextBox.TabIndex = 2;
            // 
            // ChallengesAreEvilForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 609);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ChallengesAreEvilForm";
            this.Load += new System.EventHandler(this.ChallengesAreEvilForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button clearPrintButton;

        private System.Windows.Forms.TextBox printTextBox;
        private System.Windows.Forms.TextBox nickTextBox;

        #endregion

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removeTokensButton;
    }
}