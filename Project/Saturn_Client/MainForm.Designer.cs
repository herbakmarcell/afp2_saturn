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
            userDataButton = new Button();
            studiesButton = new Button();
            subjectsButton = new Button();
            examsButton = new Button();
            financesButton = new Button();
            SuspendLayout();
            // 
            // userDataButton
            // 
            userDataButton.Location = new Point(71, 83);
            userDataButton.Name = "userDataButton";
            userDataButton.Size = new Size(152, 56);
            userDataButton.TabIndex = 0;
            userDataButton.Text = "Saját adatok";
            userDataButton.UseVisualStyleBackColor = true;
            // 
            // studiesButton
            // 
            studiesButton.Location = new Point(300, 83);
            studiesButton.Name = "studiesButton";
            studiesButton.Size = new Size(152, 56);
            studiesButton.TabIndex = 1;
            studiesButton.Text = "Tanulmányok";
            studiesButton.UseVisualStyleBackColor = true;
            // 
            // subjectsButton
            // 
            subjectsButton.Location = new Point(529, 83);
            subjectsButton.Name = "subjectsButton";
            subjectsButton.Size = new Size(152, 56);
            subjectsButton.TabIndex = 2;
            subjectsButton.Text = "Tárgyak";
            subjectsButton.UseVisualStyleBackColor = true;
            // 
            // examsButton
            // 
            examsButton.Location = new Point(752, 83);
            examsButton.Name = "examsButton";
            examsButton.Size = new Size(152, 56);
            examsButton.TabIndex = 3;
            examsButton.Text = "Vizsgázás";
            examsButton.UseVisualStyleBackColor = true;
            // 
            // financesButton
            // 
            financesButton.Location = new Point(972, 83);
            financesButton.Name = "financesButton";
            financesButton.Size = new Size(152, 56);
            financesButton.TabIndex = 4;
            financesButton.Text = "Pénzügyek";
            financesButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(financesButton);
            Controls.Add(examsButton);
            Controls.Add(subjectsButton);
            Controls.Add(studiesButton);
            Controls.Add(userDataButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button userDataButton;
        private Button studiesButton;
        private Button subjectsButton;
        private Button examsButton;
        private Button financesButton;
    }
}