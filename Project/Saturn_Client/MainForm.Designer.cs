namespace Saturn_Client
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            userDataButton = new Button();
            studiesButton = new Button();
            subjectsButton = new Button();
            examsButton = new Button();
            financesButton = new Button();
            visibleDataPanel = new Panel();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            inboxButton = new Button();
            SuspendLayout();
            // 
            // userDataButton
            // 
            userDataButton.BackColor = Color.Transparent;
            userDataButton.BackgroundImage = Properties.Resources.buttonBack;
            userDataButton.FlatAppearance.BorderSize = 0;
            userDataButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            userDataButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            userDataButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            userDataButton.FlatStyle = FlatStyle.Flat;
            userDataButton.Font = new Font("Snacker Comic Personal Use Only", 16.1999989F, FontStyle.Bold);
            userDataButton.ForeColor = SystemColors.ActiveCaptionText;
            userDataButton.Location = new Point(75, 36);
            userDataButton.Name = "userDataButton";
            userDataButton.Size = new Size(152, 56);
            userDataButton.TabIndex = 0;
            userDataButton.Text = "Saját adatok";
            userDataButton.UseVisualStyleBackColor = false;
            userDataButton.Click += userDataButton_Click;
            // 
            // studiesButton
            // 
            studiesButton.BackColor = Color.Transparent;
            studiesButton.BackgroundImage = Properties.Resources.buttonBack;
            studiesButton.FlatAppearance.BorderSize = 0;
            studiesButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            studiesButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            studiesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            studiesButton.FlatStyle = FlatStyle.Flat;
            studiesButton.Font = new Font("Snacker Comic Personal Use Only", 16.1999989F, FontStyle.Bold);
            studiesButton.ForeColor = SystemColors.ActiveCaptionText;
            studiesButton.Location = new Point(251, 36);
            studiesButton.Name = "studiesButton";
            studiesButton.Size = new Size(152, 56);
            studiesButton.TabIndex = 1;
            studiesButton.Text = "Tanulmányok";
            studiesButton.UseVisualStyleBackColor = false;
            studiesButton.Click += studiesButton_Click;
            // 
            // subjectsButton
            // 
            subjectsButton.BackColor = Color.Transparent;
            subjectsButton.BackgroundImage = Properties.Resources.buttonBack;
            subjectsButton.FlatAppearance.BorderSize = 0;
            subjectsButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            subjectsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            subjectsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            subjectsButton.FlatStyle = FlatStyle.Flat;
            subjectsButton.Font = new Font("Snacker Comic Personal Use Only", 16.1999989F, FontStyle.Bold);
            subjectsButton.ForeColor = SystemColors.ActiveCaptionText;
            subjectsButton.Location = new Point(423, 36);
            subjectsButton.Name = "subjectsButton";
            subjectsButton.Size = new Size(152, 56);
            subjectsButton.TabIndex = 2;
            subjectsButton.Text = "Tárgyak";
            subjectsButton.UseVisualStyleBackColor = false;
            subjectsButton.Click += subjectsButton_Click;
            // 
            // examsButton
            // 
            examsButton.BackColor = Color.Transparent;
            examsButton.BackgroundImage = Properties.Resources.buttonBack;
            examsButton.FlatAppearance.BorderSize = 0;
            examsButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            examsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            examsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            examsButton.FlatStyle = FlatStyle.Flat;
            examsButton.Font = new Font("Snacker Comic Personal Use Only", 16.1999989F, FontStyle.Bold);
            examsButton.ForeColor = SystemColors.ActiveCaptionText;
            examsButton.Location = new Point(604, 36);
            examsButton.Name = "examsButton";
            examsButton.Size = new Size(152, 56);
            examsButton.TabIndex = 3;
            examsButton.Text = "Vizsgázás";
            examsButton.UseVisualStyleBackColor = false;
            examsButton.Click += examsButton_Click;
            // 
            // financesButton
            // 
            financesButton.BackColor = Color.Transparent;
            financesButton.BackgroundImage = Properties.Resources.buttonBack;
            financesButton.FlatAppearance.BorderSize = 0;
            financesButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            financesButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            financesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            financesButton.FlatStyle = FlatStyle.Flat;
            financesButton.Font = new Font("Snacker Comic Personal Use Only", 16.1999989F, FontStyle.Bold);
            financesButton.ForeColor = SystemColors.ActiveCaptionText;
            financesButton.Location = new Point(779, 36);
            financesButton.Name = "financesButton";
            financesButton.Size = new Size(152, 56);
            financesButton.TabIndex = 4;
            financesButton.Text = "Pénzügyek";
            financesButton.UseVisualStyleBackColor = false;
            financesButton.Click += financesButton_Click;
            // 
            // visibleDataPanel
            // 
            visibleDataPanel.Location = new Point(75, 108);
            visibleDataPanel.Name = "visibleDataPanel";
            visibleDataPanel.Size = new Size(1044, 438);
            visibleDataPanel.TabIndex = 5;
            visibleDataPanel.Visible = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.BackgroundImageLayout = ImageLayout.None;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Image = Properties.Resources.exiticon;
            exitButton.Location = new Point(1220, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.TabIndex = 7;
            toolTip1.SetToolTip(exitButton, "Kilépés");
            exitButton.UseVisualStyleBackColor = false;
            exitButton.MouseClick += exitButton_MouseClick;
            // 
            // inboxButton
            // 
            inboxButton.BackColor = Color.Transparent;
            inboxButton.BackgroundImage = Properties.Resources.buttonBack;
            inboxButton.FlatAppearance.BorderSize = 0;
            inboxButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            inboxButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            inboxButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            inboxButton.FlatStyle = FlatStyle.Flat;
            inboxButton.Font = new Font("Snacker Comic Personal Use Only", 16.1999989F, FontStyle.Bold);
            inboxButton.ForeColor = SystemColors.ActiveCaptionText;
            inboxButton.Location = new Point(962, 36);
            inboxButton.Name = "inboxButton";
            inboxButton.Size = new Size(152, 56);
            inboxButton.TabIndex = 8;
            inboxButton.Text = "Postaláda";
            inboxButton.UseVisualStyleBackColor = false;
            inboxButton.Click += inboxButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainBack;
            ClientSize = new Size(1262, 673);
            Controls.Add(inboxButton);
            Controls.Add(exitButton);
            Controls.Add(visibleDataPanel);
            Controls.Add(financesButton);
            Controls.Add(examsButton);
            Controls.Add(subjectsButton);
            Controls.Add(studiesButton);
            Controls.Add(userDataButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            MouseDown += MainForm_MouseDown;
            MouseMove += MainForm_MouseMove;
            MouseUp += MainForm_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Button userDataButton;
        private Button studiesButton;
        private Button subjectsButton;
        private Button examsButton;
        private Button financesButton;
        private Panel visibleDataPanel;
        private Button exitButton;
        private ToolTip toolTip1;
        private Button inboxButton;
    }
}