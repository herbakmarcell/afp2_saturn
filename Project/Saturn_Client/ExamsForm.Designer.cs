namespace Saturn_Client
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 22);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Tárgy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 22);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Tárgykód";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 22);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Kurzus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 22);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "Típus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 22);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Kezdés";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 22);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 5;
            label6.Text = "Fő/Limit";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 22);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 6;
            label7.Text = "Terem";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(459, 22);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 7;
            label8.Text = "Oktató";
            // 
            // ExamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}