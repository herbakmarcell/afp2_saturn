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
            HelpButton = new Button();
            inboxButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            regButton = new Button();
            SuspendLayout();
            // 
            // userDataButton
            // 
            userDataButton.BackColor = Color.Transparent;
            userDataButton.BackgroundImage = Properties.Resources.userDataButton;
            userDataButton.FlatAppearance.BorderSize = 0;
            userDataButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            userDataButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            userDataButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            userDataButton.FlatStyle = FlatStyle.Flat;
            userDataButton.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold);
            userDataButton.ForeColor = SystemColors.ActiveCaptionText;
            userDataButton.Location = new Point(66, 27);
            userDataButton.Margin = new Padding(3, 2, 3, 2);
            userDataButton.Name = "userDataButton";
            userDataButton.Size = new Size(152, 52);
            userDataButton.TabIndex = 0;
            userDataButton.UseVisualStyleBackColor = false;
            userDataButton.Click += userDataButton_Click;
            // 
            // studiesButton
            // 
            studiesButton.BackColor = Color.Transparent;
            studiesButton.BackgroundImage = Properties.Resources.studiesButton;
            studiesButton.FlatAppearance.BorderSize = 0;
            studiesButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            studiesButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            studiesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            studiesButton.FlatStyle = FlatStyle.Flat;
            studiesButton.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold);
            studiesButton.ForeColor = SystemColors.ActiveCaptionText;
            studiesButton.Location = new Point(230, 27);
            studiesButton.Margin = new Padding(3, 2, 3, 2);
            studiesButton.Name = "studiesButton";
            studiesButton.Size = new Size(152, 52);
            studiesButton.TabIndex = 1;
            studiesButton.UseVisualStyleBackColor = false;
            studiesButton.Click += studiesButton_Click;
            // 
            // subjectsButton
            // 
            subjectsButton.BackColor = Color.Transparent;
            subjectsButton.BackgroundImage = Properties.Resources.subjectsButton;
            subjectsButton.FlatAppearance.BorderSize = 0;
            subjectsButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            subjectsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            subjectsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            subjectsButton.FlatStyle = FlatStyle.Flat;
            subjectsButton.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold);
            subjectsButton.ForeColor = SystemColors.ActiveCaptionText;
            subjectsButton.Location = new Point(393, 27);
            subjectsButton.Margin = new Padding(3, 2, 3, 2);
            subjectsButton.Name = "subjectsButton";
            subjectsButton.Size = new Size(152, 52);
            subjectsButton.TabIndex = 2;
            subjectsButton.UseVisualStyleBackColor = false;
            subjectsButton.Click += subjectsButton_Click;
            // 
            // examsButton
            // 
            examsButton.BackColor = Color.Transparent;
            examsButton.BackgroundImage = Properties.Resources.examsButton;
            examsButton.FlatAppearance.BorderSize = 0;
            examsButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            examsButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            examsButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            examsButton.FlatStyle = FlatStyle.Flat;
            examsButton.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold);
            examsButton.ForeColor = SystemColors.ActiveCaptionText;
            examsButton.Location = new Point(556, 27);
            examsButton.Margin = new Padding(3, 2, 3, 2);
            examsButton.Name = "examsButton";
            examsButton.Size = new Size(152, 52);
            examsButton.TabIndex = 3;
            examsButton.UseVisualStyleBackColor = false;
            examsButton.Click += examsButton_Click;
            // 
            // financesButton
            // 
            financesButton.BackColor = Color.Transparent;
            financesButton.BackgroundImage = Properties.Resources.financesButton;
            financesButton.FlatAppearance.BorderSize = 0;
            financesButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            financesButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            financesButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            financesButton.FlatStyle = FlatStyle.Flat;
            financesButton.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold);
            financesButton.ForeColor = SystemColors.ActiveCaptionText;
            financesButton.Location = new Point(720, 25);
            financesButton.Margin = new Padding(3, 2, 3, 2);
            financesButton.Name = "financesButton";
            financesButton.Size = new Size(152, 52);
            financesButton.TabIndex = 4;
            financesButton.UseVisualStyleBackColor = false;
            financesButton.Click += financesButton_Click;
            // 
            // visibleDataPanel
            // 
            visibleDataPanel.Location = new Point(66, 81);
            visibleDataPanel.Margin = new Padding(3, 2, 3, 2);
            visibleDataPanel.Name = "visibleDataPanel";
            visibleDataPanel.Size = new Size(970, 382);
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
            exitButton.Location = new Point(1068, 9);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(30, 30);
            exitButton.TabIndex = 7;
            toolTip1.SetToolTip(exitButton, "Kilépés");
            exitButton.UseVisualStyleBackColor = false;
            exitButton.MouseClick += exitButton_MouseClick;
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
            HelpButton.Location = new Point(12, 9);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(27, 27);
            HelpButton.TabIndex = 11;
            HelpButton.Text = "?";
            toolTip1.SetToolTip(HelpButton, "Használati útmutató");
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // inboxButton
            // 
            inboxButton.BackColor = Color.Transparent;
            inboxButton.BackgroundImage = Properties.Resources.inboxButton;
            inboxButton.FlatAppearance.BorderSize = 0;
            inboxButton.FlatAppearance.CheckedBackColor = Color.Transparent;
            inboxButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            inboxButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            inboxButton.FlatStyle = FlatStyle.Flat;
            inboxButton.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold);
            inboxButton.ForeColor = SystemColors.ActiveCaptionText;
            inboxButton.Location = new Point(884, 27);
            inboxButton.Margin = new Padding(3, 2, 3, 2);
            inboxButton.Name = "inboxButton";
            inboxButton.Size = new Size(152, 52);
            inboxButton.TabIndex = 8;
            inboxButton.UseVisualStyleBackColor = false;
            inboxButton.Click += inboxButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1600;
            timer1.Tick += timer1_Tick;
            // 
            // regButton
            // 
            regButton.BackColor = Color.Transparent;
            regButton.BackgroundImage = Properties.Resources.regbuttontemp;
            regButton.FlatAppearance.BorderSize = 0;
            regButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            regButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            regButton.FlatStyle = FlatStyle.Flat;
            regButton.Location = new Point(884, 468);
            regButton.Name = "regButton";
            regButton.Size = new Size(152, 52);
            regButton.TabIndex = 12;
            regButton.UseVisualStyleBackColor = false;
            regButton.Click += regButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mainBack;
            ClientSize = new Size(1104, 531);
            Controls.Add(regButton);
            Controls.Add(HelpButton);
            Controls.Add(inboxButton);
            Controls.Add(exitButton);
            Controls.Add(visibleDataPanel);
            Controls.Add(financesButton);
            Controls.Add(examsButton);
            Controls.Add(subjectsButton);
            Controls.Add(studiesButton);
            Controls.Add(userDataButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Opacity = 0D;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
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
        private Button HelpButton;
        private System.Windows.Forms.Timer timer1;
        private Button regButton;
    }
}