namespace Saturn_Client
{
    partial class ExamsForm
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
            HelpButton = new Button();
            toolTip1 = new ToolTip(components);
            dataGridView1 = new DataGridView();
            subject = new DataGridViewTextBoxColumn();
            subjectCode = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            startingTime = new DataGridViewTextBoxColumn();
            personLimit = new DataGridViewTextBoxColumn();
            classroom = new DataGridViewTextBoxColumn();
            teacher = new DataGridViewTextBoxColumn();
            myExamsButton = new Button();
            backButton = new Button();
            addExamButton = new Button();
            applyButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // HelpButton
            // 
            HelpButton.BackColor = Color.Transparent;
            HelpButton.FlatAppearance.BorderSize = 0;
            HelpButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            HelpButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            HelpButton.FlatStyle = FlatStyle.Flat;
            HelpButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            HelpButton.Location = new Point(916, 12);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(27, 27);
            HelpButton.TabIndex = 12;
            HelpButton.Text = "?";
            toolTip1.SetToolTip(HelpButton, "Használati útmutató");
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { subject, subjectCode, course, type, startingTime, personLimit, classroom, teacher });
            dataGridView1.Location = new Point(37, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(843, 150);
            dataGridView1.TabIndex = 13;
            // 
            // subject
            // 
            subject.HeaderText = "Tárgy";
            subject.Name = "subject";
            // 
            // subjectCode
            // 
            subjectCode.HeaderText = "Tárgykód";
            subjectCode.Name = "subjectCode";
            // 
            // course
            // 
            course.HeaderText = "Kurzus";
            course.Name = "course";
            // 
            // type
            // 
            type.HeaderText = "Típus";
            type.Name = "type";
            // 
            // startingTime
            // 
            startingTime.HeaderText = "Kezdés";
            startingTime.Name = "startingTime";
            // 
            // personLimit
            // 
            personLimit.HeaderText = "Fő/Limit";
            personLimit.Name = "personLimit";
            // 
            // classroom
            // 
            classroom.HeaderText = "Terem";
            classroom.Name = "classroom";
            // 
            // teacher
            // 
            teacher.HeaderText = "Oktató";
            teacher.Name = "teacher";
            // 
            // myExamsButton
            // 
            myExamsButton.BackColor = Color.Transparent;
            myExamsButton.FlatAppearance.BorderSize = 0;
            myExamsButton.FlatStyle = FlatStyle.Flat;
            myExamsButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            myExamsButton.Location = new Point(765, 25);
            myExamsButton.Name = "myExamsButton";
            myExamsButton.Size = new Size(115, 34);
            myExamsButton.TabIndex = 14;
            myExamsButton.Text = "Felvett vizsgáim";
            myExamsButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            backButton.Location = new Point(708, 25);
            backButton.Name = "backButton";
            backButton.Size = new Size(60, 34);
            backButton.TabIndex = 15;
            backButton.Text = "<Vissza";
            backButton.UseVisualStyleBackColor = false;
            // 
            // addExamButton
            // 
            addExamButton.BackColor = Color.Transparent;
            addExamButton.FlatAppearance.BorderSize = 0;
            addExamButton.FlatStyle = FlatStyle.Flat;
            addExamButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            addExamButton.Location = new Point(664, 234);
            addExamButton.Name = "addExamButton";
            addExamButton.Size = new Size(127, 34);
            addExamButton.TabIndex = 16;
            addExamButton.Text = "Vizsga Hozzáadása";
            addExamButton.UseVisualStyleBackColor = false;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.Transparent;
            applyButton.FlatAppearance.BorderSize = 0;
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            applyButton.Location = new Point(797, 234);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(83, 34);
            applyButton.TabIndex = 17;
            applyButton.Text = "Jelentkezés";
            applyButton.UseVisualStyleBackColor = false;
            // 
            // ExamsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(955, 346);
            Controls.Add(applyButton);
            Controls.Add(addExamButton);
            Controls.Add(backButton);
            Controls.Add(myExamsButton);
            Controls.Add(dataGridView1);
            Controls.Add(HelpButton);
            ForeColor = Color.DarkOrange;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExamsForm";
            Text = "ExamsForm";
            toolTip1.SetToolTip(this, "Használati útmutató");
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button HelpButton;
        private ToolTip toolTip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn subject;
        private DataGridViewTextBoxColumn subjectCode;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn startingTime;
        private DataGridViewTextBoxColumn personLimit;
        private DataGridViewTextBoxColumn classroom;
        private DataGridViewTextBoxColumn teacher;
        private Button myExamsButton;
        private Button backButton;
        private Button addExamButton;
        private Button applyButton;
    }
}