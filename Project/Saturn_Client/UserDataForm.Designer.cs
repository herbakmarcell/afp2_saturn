﻿namespace Saturn_Client
{
    partial class UserDataForm
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
            saturnCodeLabel = new Label();
            familyNameLabel = new Label();
            givenNameLabel = new Label();
            SuspendLayout();
            // 
            // saturnCodeLabel
            // 
            saturnCodeLabel.AutoSize = true;
            saturnCodeLabel.Location = new Point(50, 26);
            saturnCodeLabel.Name = "saturnCodeLabel";
            saturnCodeLabel.Size = new Size(83, 20);
            saturnCodeLabel.TabIndex = 0;
            saturnCodeLabel.Text = "Saturn kód:";
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.Location = new Point(50, 79);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new Size(86, 20);
            familyNameLabel.TabIndex = 1;
            familyNameLabel.Text = "Vezetéknév:";
            // 
            // givenNameLabel
            // 
            givenNameLabel.AutoSize = true;
            givenNameLabel.Location = new Point(50, 128);
            givenNameLabel.Name = "givenNameLabel";
            givenNameLabel.Size = new Size(59, 20);
            givenNameLabel.TabIndex = 2;
            givenNameLabel.Text = "Utónév:";
            // 
            // UserDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(givenNameLabel);
            Controls.Add(familyNameLabel);
            Controls.Add(saturnCodeLabel);
            Name = "UserDataForm";
            Text = "UserData";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label saturnCodeLabel;
        private Label familyNameLabel;
        private Label givenNameLabel;
    }
}