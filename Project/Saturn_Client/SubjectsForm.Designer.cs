namespace Saturn_Client
{
    partial class SubjectsForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            HelpButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 9F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Tárgy neve";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(117, 21);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 1;
            label2.Text = "Tárgy kódja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(207, 21);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "Tárgycsoport neve";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(342, 21);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Sorszám";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Comic Sans MS", 9F);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(413, 21);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 4;
            label5.Text = "Ajánlott félév";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Comic Sans MS", 9F);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(517, 21);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 5;
            label6.Text = "Kredit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Comic Sans MS", 9F);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(571, 21);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 6;
            label7.Text = "Tárgytípus";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Comic Sans MS", 9F);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(654, 21);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 7;
            label8.Text = "Teljesített";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Comic Sans MS", 9F);
            label9.ForeColor = Color.Maroon;
            label9.Location = new Point(733, 21);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 8;
            label9.Text = "Felvett";
            // 
            // HelpButton
            // 
            HelpButton.BackColor = Color.Transparent;
            HelpButton.FlatAppearance.BorderSize = 0;
            HelpButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            HelpButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            HelpButton.FlatStyle = FlatStyle.Flat;
            HelpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            HelpButton.ForeColor = Color.DarkOrange;
            HelpButton.Location = new Point(999, 12);
            HelpButton.Margin = new Padding(3, 4, 3, 4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(31, 36);
            HelpButton.TabIndex = 12;
            HelpButton.Text = "?";
            toolTip1.SetToolTip(HelpButton, "Használati útmutató");
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // SubjectsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBack;
            ClientSize = new Size(1091, 462);
            Controls.Add(HelpButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SubjectsForm";
            Text = "SubjectForm";
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
        private Label label9;
        private Button HelpButton;
        private ToolTip toolTip1;
    }
}