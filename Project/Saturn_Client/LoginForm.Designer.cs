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
            usernameField = new TextBox();
            passwordField = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            logoBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // usernameField
            // 
            usernameField.Location = new Point(318, 150);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(339, 27);
            usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(318, 199);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(339, 27);
            passwordField.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(203, 150);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Felhasználónév";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(233, 199);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(48, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Jelszó";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(424, 251);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(124, 45);
            loginButton.TabIndex = 4;
            loginButton.Text = "Bejelentkezés";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // logoBox
            // 
            logoBox.Location = new Point(411, 12);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(177, 120);
            logoBox.TabIndex = 5;
            logoBox.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 366);
            Controls.Add(logoBox);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Name = "LoginForm";
            Text = "Saturn";
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameField;
        private TextBox passwordField;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private PictureBox logoBox;
    }
}
