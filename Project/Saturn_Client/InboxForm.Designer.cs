namespace Saturn_Client
{
    partial class InboxForm
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
            HelpButton = new Button();
            toolTip1 = new ToolTip(components);
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            HelpButton.Location = new Point(999, 16);
            HelpButton.Margin = new Padding(3, 4, 3, 4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(31, 36);
            HelpButton.TabIndex = 19;
            HelpButton.Text = "?";
            toolTip1.SetToolTip(HelpButton, "Használati útmutató");
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(936, 355);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Comic Sans MS", 9.2F);
            linkLabel1.LinkColor = Color.DarkOrange;
            linkLabel1.Location = new Point(834, 27);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 23);
            linkLabel1.TabIndex = 21;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Üzenet küldése";
            linkLabel1.VisitedLinkColor = Color.DarkOrange;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 13.8F);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(46, 86);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 22;
            label1.Text = "Címzett: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 13.8F);
            label2.ForeColor = Color.DarkOrange;
            label2.Location = new Point(46, 132);
            label2.Name = "label2";
            label2.Size = new Size(91, 31);
            label2.TabIndex = 23;
            label2.Text = "Tárgy: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 13.8F);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(46, 188);
            label3.Name = "label3";
            label3.Size = new Size(98, 31);
            label3.TabIndex = 24;
            label3.Text = "Üzenet:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 27);
            textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 27);
            textBox2.TabIndex = 26;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(46, 222);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(892, 164);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.sendMessageButton;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(726, 132);
            button1.Name = "button1";
            button1.Size = new Size(152, 56);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Font = new Font("Comic Sans MS", 9.2F);
            linkLabel2.LinkColor = Color.DarkOrange;
            linkLabel2.Location = new Point(612, 27);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(62, 23);
            linkLabel2.TabIndex = 29;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "<Vissza";
            linkLabel2.Visible = false;
            linkLabel2.VisitedLinkColor = Color.DarkOrange;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BackColor = Color.Transparent;
            linkLabel3.Font = new Font("Comic Sans MS", 9.2F);
            linkLabel3.LinkColor = Color.DarkOrange;
            linkLabel3.Location = new Point(680, 27);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(148, 23);
            linkLabel3.TabIndex = 30;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Elküldött üzenetek";
            linkLabel3.VisitedLinkColor = Color.DarkOrange;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(32, 32);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 32;
            label4.Text = "Üzenetek";
            label4.Visible = false;
            // 
            // InboxForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(1091, 462);
            Controls.Add(label4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(HelpButton);
            Name = "InboxForm";
            Text = "Inbox";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button HelpButton;
        private ToolTip toolTip1;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        public Label label1;
        public Label label2;
        public Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label4;
    }
}