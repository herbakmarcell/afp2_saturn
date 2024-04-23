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
            updateUserDataButton = new Button();
            saturncodeTB = new TextBox();
            lastnameTB = new TextBox();
            firstnameTB = new TextBox();
            emailTB = new TextBox();
            phonenumberTB = new TextBox();
            saveChangesButton = new Button();
            SuspendLayout();
            // 
            // saturnCodeLabel
            // 
            saturnCodeLabel.AutoSize = true;
            saturnCodeLabel.BackColor = Color.Transparent;
            saturnCodeLabel.Font = new Font("Comic Sans MS", 13.8F);
            saturnCodeLabel.ForeColor = Color.DarkOrange;
            saturnCodeLabel.Location = new Point(44, 23);
            saturnCodeLabel.Name = "saturnCodeLabel";
            saturnCodeLabel.Size = new Size(121, 26);
            saturnCodeLabel.TabIndex = 0;
            saturnCodeLabel.Text = "Saturn kód: ";
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.BackColor = Color.Transparent;
            familyNameLabel.Font = new Font("Comic Sans MS", 13.8F);
            familyNameLabel.ForeColor = Color.DarkOrange;
            familyNameLabel.Location = new Point(44, 76);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new Size(124, 26);
            familyNameLabel.TabIndex = 1;
            familyNameLabel.Text = "Vezetéknév: ";
            // 
            // givenNameLabel
            // 
            givenNameLabel.AutoSize = true;
            givenNameLabel.BackColor = Color.Transparent;
            givenNameLabel.Font = new Font("Comic Sans MS", 13.8F);
            givenNameLabel.ForeColor = Color.DarkOrange;
            givenNameLabel.Location = new Point(44, 131);
            givenNameLabel.Name = "givenNameLabel";
            givenNameLabel.Size = new Size(85, 26);
            givenNameLabel.TabIndex = 2;
            givenNameLabel.Text = "Utónév: ";
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
            HelpButton.Location = new Point(874, 10);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(27, 27);
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
            emailLabel.Location = new Point(44, 194);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(78, 26);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "E-mail: ";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = Color.Transparent;
            phoneLabel.Font = new Font("Comic Sans MS", 13.8F);
            phoneLabel.ForeColor = Color.DarkOrange;
            phoneLabel.Location = new Point(44, 254);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(137, 26);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Telefonszám: ";
            // 
            // updateUserDataButton
            // 
            updateUserDataButton.BackColor = Color.Transparent;
            updateUserDataButton.BackgroundImage = Properties.Resources.updatebuttontemp;
            updateUserDataButton.FlatAppearance.BorderSize = 0;
            updateUserDataButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            updateUserDataButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            updateUserDataButton.FlatStyle = FlatStyle.Flat;
            updateUserDataButton.ForeColor = SystemColors.ControlText;
            updateUserDataButton.Location = new Point(780, 282);
            updateUserDataButton.Name = "updateUserDataButton";
            updateUserDataButton.Size = new Size(153, 52);
            updateUserDataButton.TabIndex = 15;
            updateUserDataButton.UseVisualStyleBackColor = false;
            updateUserDataButton.Click += updateUserDataButton_Click;
            // 
            // saturncodeTB
            // 
            saturncodeTB.Location = new Point(185, 26);
            saturncodeTB.Name = "saturncodeTB";
            saturncodeTB.Size = new Size(100, 23);
            saturncodeTB.TabIndex = 16;
            // 
            // lastnameTB
            // 
            lastnameTB.Location = new Point(185, 80);
            lastnameTB.Name = "lastnameTB";
            lastnameTB.Size = new Size(100, 23);
            lastnameTB.TabIndex = 17;
            // 
            // firstnameTB
            // 
            firstnameTB.Location = new Point(185, 135);
            firstnameTB.Name = "firstnameTB";
            firstnameTB.Size = new Size(100, 23);
            firstnameTB.TabIndex = 18;
            // 
            // emailTB
            // 
            emailTB.Location = new Point(185, 198);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(100, 23);
            emailTB.TabIndex = 19;
            // 
            // phonenumberTB
            // 
            phonenumberTB.Location = new Point(185, 258);
            phonenumberTB.Name = "phonenumberTB";
            phonenumberTB.Size = new Size(100, 23);
            phonenumberTB.TabIndex = 20;
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.Transparent;
            saveChangesButton.BackgroundImage = Properties.Resources.savebuttontemp;
            saveChangesButton.FlatAppearance.BorderSize = 0;
            saveChangesButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            saveChangesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            saveChangesButton.FlatStyle = FlatStyle.Flat;
            saveChangesButton.Location = new Point(605, 282);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(152, 52);
            saveChangesButton.TabIndex = 21;
            saveChangesButton.UseVisualStyleBackColor = false;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // UserDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(955, 346);
            Controls.Add(saveChangesButton);
            Controls.Add(phonenumberTB);
            Controls.Add(emailTB);
            Controls.Add(firstnameTB);
            Controls.Add(lastnameTB);
            Controls.Add(saturncodeTB);
            Controls.Add(updateUserDataButton);
            Controls.Add(phoneLabel);
            Controls.Add(emailLabel);
            Controls.Add(HelpButton);
            Controls.Add(givenNameLabel);
            Controls.Add(familyNameLabel);
            Controls.Add(saturnCodeLabel);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button updateUserDataButton;
        private TextBox saturncodeTB;
        private TextBox lastnameTB;
        private TextBox firstnameTB;
        private TextBox emailTB;
        private TextBox phonenumberTB;
        private Button saveChangesButton;
    }
}