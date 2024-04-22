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
            FirstName_tbox = new TextBox();
            LastName_tbox = new TextBox();
            label3 = new Label();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Email_tbox = new TextBox();
            PhoneNumber_tbox = new TextBox();
            Password_tbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            HelpButton = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            logoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // regButton
            // 
            regButton.BackColor = Color.Transparent;
            regButton.BackgroundImage = Properties.Resources.regbuttontemp;
            regButton.FlatAppearance.BorderSize = 0;
            regButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            regButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            regButton.FlatStyle = FlatStyle.Flat;
            regButton.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            regButton.ForeColor = SystemColors.ControlText;
            regButton.Location = new Point(112, 290);
            regButton.Name = "regButton";
            regButton.Size = new Size(153, 49);
            regButton.TabIndex = 0;
            regButton.UseVisualStyleBackColor = false;
            regButton.Click += regButton_Click;
            // 
            // FirstName_tbox
            // 
            FirstName_tbox.Location = new Point(87, 68);
            FirstName_tbox.Name = "FirstName_tbox";
            FirstName_tbox.Size = new Size(201, 23);
            FirstName_tbox.TabIndex = 3;
            FirstName_tbox.TextChanged += FirstName_tbox_TextChanged;
            // 
            // LastName_tbox
            // 
            LastName_tbox.Location = new Point(87, 114);
            LastName_tbox.Name = "LastName_tbox";
            LastName_tbox.Size = new Size(201, 23);
            LastName_tbox.TabIndex = 4;
            LastName_tbox.TextChanged += LastName_tbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(56, 8);
            label3.Name = "label3";
            label3.Size = new Size(259, 29);
            label3.TabIndex = 5;
            label3.Text = "Felhasználó regisztrálása";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Image = Properties.Resources.exiticon;
            exitButton.Location = new Point(913, 7);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.TabIndex = 6;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.user;
            pictureBox1.Location = new Point(20, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.passkey;
            pictureBox2.Location = new Point(20, 252);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Email_tbox
            // 
            Email_tbox.Location = new Point(87, 167);
            Email_tbox.Name = "Email_tbox";
            Email_tbox.Size = new Size(201, 23);
            Email_tbox.TabIndex = 10;
            Email_tbox.TextChanged += Email_tbox_TextChanged;
            // 
            // PhoneNumber_tbox
            // 
            PhoneNumber_tbox.Location = new Point(87, 216);
            PhoneNumber_tbox.Name = "PhoneNumber_tbox";
            PhoneNumber_tbox.Size = new Size(201, 23);
            PhoneNumber_tbox.TabIndex = 11;
            PhoneNumber_tbox.TextChanged += PhoneNumber_tbox_TextChanged;
            // 
            // Password_tbox
            // 
            Password_tbox.Location = new Point(87, 262);
            Password_tbox.Name = "Password_tbox";
            Password_tbox.PasswordChar = '*';
            Password_tbox.Size = new Size(201, 23);
            Password_tbox.TabIndex = 12;
            Password_tbox.TextChanged += Password_tbox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.DarkOrange;
            label4.Location = new Point(56, 44);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 13;
            label4.Text = "Utónév";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.DarkOrange;
            label5.Location = new Point(56, 93);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 14;
            label5.Text = "Vezetéknév";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(56, 140);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 15;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.DarkOrange;
            label7.Location = new Point(56, 188);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 16;
            label7.Text = "Telefonszám";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.ForeColor = Color.DarkOrange;
            label8.Location = new Point(56, 238);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 17;
            label8.Text = "Jelszó";
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
            HelpButton.Location = new Point(916, 303);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(27, 27);
            HelpButton.TabIndex = 18;
            HelpButton.Text = "?";
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.fieldBack;
            pictureBox3.Location = new Point(56, 58);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(243, 33);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.fieldBack;
            pictureBox4.Location = new Point(56, 105);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(243, 33);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources.fieldBack;
            pictureBox5.Location = new Point(56, 157);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(243, 33);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources.fieldBack;
            pictureBox6.Location = new Point(56, 206);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(243, 33);
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources.fieldBack;
            pictureBox7.Location = new Point(56, 252);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(243, 33);
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.Image = Properties.Resources.saturnbeta;
            logoBox.Location = new Point(736, 44);
            logoBox.Margin = new Padding(3, 2, 3, 2);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(161, 120);
            logoBox.TabIndex = 24;
            logoBox.TabStop = false;
            // 
            // RegFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(955, 346);
            Controls.Add(logoBox);
            Controls.Add(HelpButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Password_tbox);
            Controls.Add(PhoneNumber_tbox);
            Controls.Add(Email_tbox);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(label3);
            Controls.Add(LastName_tbox);
            Controls.Add(FirstName_tbox);
            Controls.Add(regButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Name = "RegFrom";
            Text = "RegFrom";
            MouseDown += RegFrom_MouseDown;
            MouseMove += RegFrom_MouseMove;
            MouseUp += RegFrom_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button regButton;
        private TextBox FirstName_tbox;
        private TextBox LastName_tbox;
        private Label label3;
        private Button exitButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox Email_tbox;
        private TextBox PhoneNumber_tbox;
        private TextBox Password_tbox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button HelpButton;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox logoBox;
    }
}