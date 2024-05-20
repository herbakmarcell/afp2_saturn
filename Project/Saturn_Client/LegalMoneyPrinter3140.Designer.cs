namespace Saturn_Client
{
    partial class LegalMoneyPrinter3140
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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label4 = new Label();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(57, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 16);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.fieldBack;
            pictureBox1.Location = new Point(12, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 47);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.uploadButton;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(69, 176);
            button1.Name = "button1";
            button1.Size = new Size(152, 56);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(48, 64);
            label4.Name = "label4";
            label4.Size = new Size(221, 23);
            label4.TabIndex = 33;
            label4.Text = "Mennyit szeretne feltölteni?";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Comic Sans MS", 9.2F);
            linkLabel2.LinkColor = Color.DarkOrange;
            linkLabel2.Location = new Point(12, 9);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(51, 18);
            linkLabel2.TabIndex = 34;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "<Vissza";
            linkLabel2.VisitedLinkColor = Color.DarkOrange;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // LegalMoneyPrinter3140
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainBack;
            ClientSize = new Size(302, 262);
            Controls.Add(linkLabel2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "LegalMoneyPrinter3140";
            Text = "LegalMoneyPrinter3140";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label4;
        private LinkLabel linkLabel2;
    }
}