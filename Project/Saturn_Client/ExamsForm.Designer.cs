﻿namespace Saturn_Client
{
    partial class ExamsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            HelpButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 9F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(33, 16);
            label1.Name = "label1";
            label1.Size = new Size(40, 17);
            label1.TabIndex = 0;
            label1.Text = "Tárgy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(77, 16);
            label2.Name = "label2";
            label2.Size = new Size(58, 17);
            label2.TabIndex = 1;
            label2.Text = "Tárgykód";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(143, 16);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 2;
            label3.Text = "Kurzus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(193, 16);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 3;
            label4.Text = "Típus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 9F);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(237, 16);
            label5.Name = "label5";
            label5.Size = new Size(45, 17);
            label5.TabIndex = 4;
            label5.Text = "Kezdés";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 9F);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(291, 16);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 5;
            label6.Text = "Fő/Limit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Comic Sans MS", 9F);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(353, 16);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 6;
            label7.Text = "Terem";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Comic Sans MS", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(402, 16);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 7;
            label8.Text = "Oktató";
            // 
            // HelpButton
            // 
            HelpButton.BackColor = Color.Transparent;
            HelpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            HelpButton.Location = new Point(874, 12);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(27, 27);
            HelpButton.TabIndex = 12;
            HelpButton.Text = "?";
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // ExamsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBack;
            ClientSize = new Size(913, 340);
            Controls.Add(HelpButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExamsForm";
            Text = "ExamsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button HelpButton;
    }
}