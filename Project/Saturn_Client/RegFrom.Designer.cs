namespace Saturn_Client
{
    partial class RegFrom
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
            regButton = new Button();
            label1 = new Label();
            FirstName_tbox = new TextBox();
            LastName_tbox = new TextBox();
            label3 = new Label();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            Email_tbox = new TextBox();
            PhoneNumber_tbox = new TextBox();
            Password_tbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            HelpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // regButton
            // 
            regButton.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            regButton.Location = new Point(115, 448);
            regButton.Margin = new Padding(3, 4, 3, 4);
            regButton.Name = "regButton";
            regButton.Size = new Size(194, 56);
            regButton.TabIndex = 0;
            regButton.Text = "Regisztráció";
            regButton.UseVisualStyleBackColor = true;
            regButton.Click += regButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(79, 91);
            label1.Name = "label1";
            label1.Size = new Size(0, 41);
            label1.TabIndex = 1;
            // 
            // FirstName_tbox
            // 
            FirstName_tbox.Location = new Point(66, 143);
            FirstName_tbox.Margin = new Padding(3, 4, 3, 4);
            FirstName_tbox.Name = "FirstName_tbox";
            FirstName_tbox.Size = new Size(305, 27);
            FirstName_tbox.TabIndex = 3;
            FirstName_tbox.TextChanged += FirstName_tbox_TextChanged;
            // 
            // LastName_tbox
            // 
            LastName_tbox.Location = new Point(66, 208);
            LastName_tbox.Margin = new Padding(3, 4, 3, 4);
            LastName_tbox.Name = "LastName_tbox";
            LastName_tbox.Size = new Size(305, 27);
            LastName_tbox.TabIndex = 4;
            LastName_tbox.TextChanged += LastName_tbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(66, 52);
            label3.Name = "label3";
            label3.Size = new Size(335, 38);
            label3.TabIndex = 5;
            label3.Text = "Felhasználó regisztrálása";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Image = Properties.Resources.exiticon;
            exitButton.Location = new Point(367, 15);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(34, 40);
            exitButton.TabIndex = 6;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.Location = new Point(25, 143);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 36);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.passkey;
            pictureBox2.Location = new Point(25, 396);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 36);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(66, 11);
            label2.Name = "label2";
            label2.Size = new Size(190, 38);
            label2.TabIndex = 9;
            label2.Text = "Admin Felület";
            // 
            // Email_tbox
            // 
            Email_tbox.Location = new Point(66, 271);
            Email_tbox.Margin = new Padding(3, 4, 3, 4);
            Email_tbox.Name = "Email_tbox";
            Email_tbox.Size = new Size(305, 27);
            Email_tbox.TabIndex = 10;
            Email_tbox.TextChanged += Email_tbox_TextChanged;
            // 
            // PhoneNumber_tbox
            // 
            PhoneNumber_tbox.Location = new Point(66, 335);
            PhoneNumber_tbox.Margin = new Padding(3, 4, 3, 4);
            PhoneNumber_tbox.Name = "PhoneNumber_tbox";
            PhoneNumber_tbox.Size = new Size(305, 27);
            PhoneNumber_tbox.TabIndex = 11;
            PhoneNumber_tbox.TextChanged += PhoneNumber_tbox_TextChanged;
            // 
            // Password_tbox
            // 
            Password_tbox.Location = new Point(66, 401);
            Password_tbox.Margin = new Padding(3, 4, 3, 4);
            Password_tbox.Name = "Password_tbox";
            Password_tbox.PasswordChar = '*';
            Password_tbox.Size = new Size(305, 27);
            Password_tbox.TabIndex = 12;
            Password_tbox.TextChanged += Password_tbox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 119);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 13;
            label4.Text = "Utónév";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 184);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 14;
            label5.Text = "Vezetéknév";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 247);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 15;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 311);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 16;
            label7.Text = "Telefonszám";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 377);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 17;
            label8.Text = "Jelszó";
            // 
            // HelpButton
            // 
            HelpButton.BackColor = Color.Transparent;
            HelpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            HelpButton.Location = new Point(25, 11);
            HelpButton.Margin = new Padding(3, 4, 3, 4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(31, 36);
            HelpButton.TabIndex = 18;
            HelpButton.Text = "?";
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // RegFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 520);
            Controls.Add(HelpButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Password_tbox);
            Controls.Add(PhoneNumber_tbox);
            Controls.Add(Email_tbox);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(label3);
            Controls.Add(LastName_tbox);
            Controls.Add(FirstName_tbox);
            Controls.Add(label1);
            Controls.Add(regButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegFrom";
            Text = "RegFrom";
            MouseDown += RegFrom_MouseDown;
            MouseMove += RegFrom_MouseMove;
            MouseUp += RegFrom_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button regButton;
        private Label label1;
        private TextBox FirstName_tbox;
        private TextBox LastName_tbox;
        private Label label3;
        private Button exitButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox Email_tbox;
        private TextBox PhoneNumber_tbox;
        private TextBox Password_tbox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button HelpButton;
    }
}