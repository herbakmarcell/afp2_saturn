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
            loginButton = new Button();
            logoBox = new PictureBox();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            userPic = new PictureBox();
            passPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passPic).BeginInit();
            SuspendLayout();
            // 
            // usernameField
            // 
            usernameField.Location = new Point(231, 150);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(339, 27);
            usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(231, 199);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(339, 27);
            passwordField.TabIndex = 1;
            // 
            // loginButton
            // 
            loginButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            loginButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Image = Properties.Resources.loginButtonpic;
            loginButton.Location = new Point(337, 251);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(120, 35);
            loginButton.TabIndex = 4;
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // logoBox
            // 
            logoBox.BackColor = Color.Transparent;
            logoBox.Image = Properties.Resources.saturnbeta;
            logoBox.Location = new Point(324, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(177, 120);
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
            exitButton.Location = new Point(699, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.TabIndex = 6;
            toolTip1.SetToolTip(exitButton, "Kilépés");
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // userPic
            // 
            userPic.BackColor = Color.Transparent;
            userPic.Image = Properties.Resources.user;
            userPic.Location = new Point(195, 150);
            userPic.Name = "userPic";
            userPic.Size = new Size(27, 27);
            userPic.TabIndex = 7;
            userPic.TabStop = false;
            // 
            // passPic
            // 
            passPic.BackColor = Color.Transparent;
            passPic.Image = Properties.Resources.passkey;
            passPic.Location = new Point(195, 199);
            passPic.Name = "passPic";
            passPic.Size = new Size(27, 27);
            passPic.TabIndex = 8;
            passPic.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 366);
            Controls.Add(passPic);
            Controls.Add(userPic);
            Controls.Add(exitButton);
            Controls.Add(logoBox);
            Controls.Add(loginButton);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "Saturn";
            MouseDown += LoginForm_MouseDown;
            MouseMove += LoginForm_MouseMove;
            MouseUp += LoginForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)userPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)passPic).EndInit();
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
    }
}
