namespace Saturn_Client
{
    partial class UserDataForm
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
            saturnCodeLabel = new Label();
            familyNameLabel = new Label();
            givenNameLabel = new Label();
            HelpButton = new Button();
            toolTip1 = new ToolTip(components);
            emailLabel = new Label();
            phoneLabel = new Label();
            SuspendLayout();
            // 
            // saturnCodeLabel
            // 
            saturnCodeLabel.AutoSize = true;
            saturnCodeLabel.BackColor = Color.Transparent;
            saturnCodeLabel.Font = new Font("Comic Sans MS", 13.8F);
            saturnCodeLabel.ForeColor = Color.DarkOrange;
            saturnCodeLabel.Location = new Point(50, 31);
            saturnCodeLabel.Name = "saturnCodeLabel";
            saturnCodeLabel.Size = new Size(140, 31);
            saturnCodeLabel.TabIndex = 0;
            saturnCodeLabel.Text = "Saturn kód:";
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.BackColor = Color.Transparent;
            familyNameLabel.Font = new Font("Comic Sans MS", 13.8F);
            familyNameLabel.ForeColor = Color.DarkOrange;
            familyNameLabel.Location = new Point(50, 101);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new Size(146, 31);
            familyNameLabel.TabIndex = 1;
            familyNameLabel.Text = "Vezetéknév:";
            // 
            // givenNameLabel
            // 
            givenNameLabel.AutoSize = true;
            givenNameLabel.BackColor = Color.Transparent;
            givenNameLabel.Font = new Font("Comic Sans MS", 13.8F);
            givenNameLabel.ForeColor = Color.DarkOrange;
            givenNameLabel.Location = new Point(50, 175);
            givenNameLabel.Name = "givenNameLabel";
            givenNameLabel.Size = new Size(96, 31);
            givenNameLabel.TabIndex = 2;
            givenNameLabel.Text = "Utónév:";
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
            HelpButton.Location = new Point(999, 13);
            HelpButton.Margin = new Padding(3, 4, 3, 4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(31, 36);
            HelpButton.TabIndex = 12;
            HelpButton.Text = "?";
            toolTip1.SetToolTip(HelpButton, "Használati útmutató");
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.Font = new Font("Comic Sans MS", 13.8F);
            emailLabel.ForeColor = Color.DarkOrange;
            emailLabel.Location = new Point(50, 258);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(86, 31);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "E-mail:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Comic Sans MS", 13.8F);
            phoneLabel.ForeColor = Color.DarkOrange;
            phoneLabel.Location = new Point(50, 339);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(158, 31);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Telefonszám:";
            // 
            // UserDataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(1091, 462);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(HelpButton);
            Controls.Add(givenNameLabel);
            Controls.Add(familyNameLabel);
            Controls.Add(saturnCodeLabel);
            Name = "UserDataForm";
            Text = "UserData";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label familyNameLabel;
        private Label givenNameLabel;
        private Button HelpButton;
        private ToolTip toolTip1;
        private Label emailLabel;
        private Label phoneLabel;
        public Label saturnCodeLabel;
    }
}