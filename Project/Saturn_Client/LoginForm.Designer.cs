namespace Saturn_Client
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameField = new TextBox();
            passwordField = new TextBox();
            logoBox = new PictureBox();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            HelpButton = new Button();
            userPic = new PictureBox();
            passPic = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            loginButton = new Button();
            regformButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // usernameField
            // 
            usernameField.BackColor = Color.White;
            usernameField.BorderStyle = BorderStyle.None;
            usernameField.Font = new Font("Comic Sans MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameField.Location = new Point(76, 68);
            usernameField.MaxLength = 6;
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(204, 19);
            usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.BackColor = Color.White;
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.Location = new Point(76, 116);
            passwordField.MaxLength = 16;
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(204, 20);
            passwordField.TabIndex = 1;
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.Image = Properties.Resources.saturnbeta;
            logoBox.Location = new Point(553, 55);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(184, 160);
            logoBox.TabIndex = 5;
            logoBox.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Image = Properties.Resources.exiticon;
            exitButton.Location = new Point(13, 10);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(34, 40);
            exitButton.TabIndex = 6;
            toolTip1.SetToolTip(exitButton, "Kilépés");
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
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
            HelpButton.Location = new Point(701, 321);
            HelpButton.Margin = new Padding(3, 4, 3, 4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(31, 36);
            HelpButton.TabIndex = 10;
            HelpButton.Text = "?";
            toolTip1.SetToolTip(HelpButton, "Használati útmutató");
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // userPic
            // 
            userPic.BackColor = Color.Transparent;
            userPic.Image = Properties.Resources.user;
            userPic.Location = new Point(13, 61);
            userPic.Name = "userPic";
            userPic.Size = new Size(30, 27);
            userPic.TabIndex = 7;
            userPic.TabStop = false;
            // 
            // passPic
            // 
            passPic.BackColor = Color.Transparent;
            passPic.Image = Properties.Resources.passkey;
            passPic.Location = new Point(13, 116);
            passPic.Name = "passPic";
            passPic.Size = new Size(30, 27);
            passPic.TabIndex = 8;
            passPic.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.fieldBack;
            pictureBox1.Location = new Point(39, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 44);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.fieldBack;
            pictureBox2.Location = new Point(39, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(278, 44);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Transparent;
            loginButton.BackgroundImage = Properties.Resources.fideszLogin;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(76, 156);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 70);
            loginButton.TabIndex = 4;
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // regformButton
            // 
            regformButton.BackColor = Color.Transparent;
            regformButton.ForeColor = SystemColors.ControlText;
            regformButton.Location = new Point(631, 321);
            regformButton.Name = "regformButton";
            regformButton.Size = new Size(101, 33);
            regformButton.TabIndex = 9;
            regformButton.Text = "Regisztráció";
            regformButton.UseVisualStyleBackColor = false;
            regformButton.Click += regformButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.loginback;
            ClientSize = new Size(749, 366);
            Controls.Add(passwordField);
            Controls.Add(pictureBox2);
            Controls.Add(usernameField);
            Controls.Add(pictureBox1);
            Controls.Add(HelpButton);
            Controls.Add(regformButton);
            Controls.Add(passPic);
            Controls.Add(userPic);
            Controls.Add(exitButton);
            Controls.Add(logoBox);
            Controls.Add(loginButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Saturn";
            Load += LoginForm_Load;
            MouseDown += LoginForm_MouseDown;
            MouseMove += LoginForm_MouseMove;
            MouseUp += LoginForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)passPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameField;
        private TextBox passwordField;
        private Button loginButton;
        private PictureBox logoBox;
        private Button exitButton;
        private ToolTip toolTip1;
        private PictureBox userPic;
        private PictureBox passPic;
        private Button HelpButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button regformButton;
    }
}
