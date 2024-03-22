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
            userDataPanel = new Panel();
            exitButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // userDataButton
            // 
            userDataButton.Location = new Point(75, 36);
            userDataButton.Name = "userDataButton";
            userDataButton.Size = new Size(152, 56);
            userDataButton.TabIndex = 0;
            userDataButton.Text = "Saját adatok";
            userDataButton.UseVisualStyleBackColor = true;
            userDataButton.Click += userDataButton_Click;
            // 
            // studiesButton
            // 
            studiesButton.Location = new Point(289, 36);
            studiesButton.Name = "studiesButton";
            studiesButton.Size = new Size(152, 56);
            studiesButton.TabIndex = 1;
            studiesButton.Text = "Tanulmányok";
            studiesButton.UseVisualStyleBackColor = true;
            // 
            // subjectsButton
            // 
            subjectsButton.Location = new Point(511, 36);
            subjectsButton.Name = "subjectsButton";
            subjectsButton.Size = new Size(152, 56);
            subjectsButton.TabIndex = 2;
            subjectsButton.Text = "Tárgyak";
            subjectsButton.UseVisualStyleBackColor = true;
            // 
            // examsButton
            // 
            examsButton.Location = new Point(740, 36);
            examsButton.Name = "examsButton";
            examsButton.Size = new Size(152, 56);
            examsButton.TabIndex = 3;
            examsButton.Text = "Vizsgázás";
            examsButton.UseVisualStyleBackColor = true;
            // 
            // financesButton
            // 
            financesButton.Location = new Point(967, 36);
            financesButton.Name = "financesButton";
            financesButton.Size = new Size(152, 56);
            financesButton.TabIndex = 4;
            financesButton.Text = "Pénzügyek";
            financesButton.UseVisualStyleBackColor = true;
            // 
            // userDataPanel
            // 
            userDataPanel.Location = new Point(75, 108);
            userDataPanel.Name = "userDataPanel";
            userDataPanel.Size = new Size(1044, 438);
            userDataPanel.TabIndex = 5;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(exitButton);
            Controls.Add(userDataPanel);
            Controls.Add(financesButton);
            Controls.Add(examsButton);
            Controls.Add(subjectsButton);
            Controls.Add(studiesButton);
            Controls.Add(userDataButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button userDataButton;
        private Button studiesButton;
        private Button subjectsButton;
        private Button examsButton;
        private Button financesButton;
        private Panel userDataPanel;
        private Button exitButton;
        private ToolTip toolTip1;
    }
}