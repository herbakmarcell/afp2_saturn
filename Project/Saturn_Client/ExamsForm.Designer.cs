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
            examsDataGridView = new DataGridView();
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
            updateExamButton = new Button();
            deleteExamButton = new Button();
            updateExamInDBButton = new Button();
            addExamToDBButton = new Button();
            subjectLabel = new Label();
            subjectcodeLabel = new Label();
            courseLabel = new Label();
            typeLabel = new Label();
            startLabel = new Label();
            limitLabel = new Label();
            classroomLabel = new Label();
            teacherLabel = new Label();
            subjectTB = new TextBox();
            subjectcodeTB = new TextBox();
            courseTB = new TextBox();
            typeTB = new TextBox();
            startTB = new TextBox();
            limitTB = new TextBox();
            classroomTB = new TextBox();
            teacherTB = new TextBox();
            ((System.ComponentModel.ISupportInitialize)examsDataGridView).BeginInit();
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
            // examsDataGridView
            // 
            examsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            examsDataGridView.Columns.AddRange(new DataGridViewColumn[] { subject, subjectCode, course, type, startingTime, personLimit, classroom, teacher });
            examsDataGridView.Location = new Point(28, 47);
            examsDataGridView.Name = "examsDataGridView";
            examsDataGridView.Size = new Size(843, 238);
            examsDataGridView.TabIndex = 13;
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
            myExamsButton.Location = new Point(765, 12);
            myExamsButton.Name = "myExamsButton";
            myExamsButton.Size = new Size(115, 34);
            myExamsButton.TabIndex = 14;
            myExamsButton.Text = "Felvett vizsgáim";
            myExamsButton.UseVisualStyleBackColor = false;
            myExamsButton.Click += myExamsButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            backButton.Location = new Point(708, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(60, 34);
            backButton.TabIndex = 15;
            backButton.Text = "<Vissza";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // addExamButton
            // 
            addExamButton.BackColor = Color.Transparent;
            addExamButton.FlatAppearance.BorderSize = 0;
            addExamButton.FlatStyle = FlatStyle.Flat;
            addExamButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            addExamButton.Location = new Point(664, 291);
            addExamButton.Name = "addExamButton";
            addExamButton.Size = new Size(127, 34);
            addExamButton.TabIndex = 16;
            addExamButton.Text = "Vizsga Hozzáadása";
            addExamButton.UseVisualStyleBackColor = false;
            addExamButton.Click += addExamButton_Click;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.Transparent;
            applyButton.FlatAppearance.BorderSize = 0;
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            applyButton.Location = new Point(797, 291);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(83, 34);
            applyButton.TabIndex = 17;
            applyButton.Text = "Jelentkezés";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            // 
            // updateExamButton
            // 
            updateExamButton.BackColor = Color.Transparent;
            updateExamButton.FlatAppearance.BorderSize = 0;
            updateExamButton.FlatStyle = FlatStyle.Flat;
            updateExamButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            updateExamButton.Location = new Point(531, 291);
            updateExamButton.Name = "updateExamButton";
            updateExamButton.Size = new Size(127, 34);
            updateExamButton.TabIndex = 18;
            updateExamButton.Text = "Vizsga Módosítása";
            updateExamButton.UseVisualStyleBackColor = false;
            updateExamButton.Click += updateExamButton_Click;
            // 
            // deleteExamButton
            // 
            deleteExamButton.BackColor = Color.Transparent;
            deleteExamButton.FlatAppearance.BorderSize = 0;
            deleteExamButton.FlatStyle = FlatStyle.Flat;
            deleteExamButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            deleteExamButton.Location = new Point(426, 291);
            deleteExamButton.Name = "deleteExamButton";
            deleteExamButton.Size = new Size(99, 34);
            deleteExamButton.TabIndex = 19;
            deleteExamButton.Text = "Vizsga Törlése";
            deleteExamButton.UseVisualStyleBackColor = false;
            deleteExamButton.Click += deleteExamButton_Click;
            // 
            // updateExamInDBButton
            // 
            updateExamInDBButton.BackColor = Color.Transparent;
            updateExamInDBButton.FlatAppearance.BorderSize = 0;
            updateExamInDBButton.FlatStyle = FlatStyle.Flat;
            updateExamInDBButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            updateExamInDBButton.Location = new Point(531, 251);
            updateExamInDBButton.Name = "updateExamInDBButton";
            updateExamInDBButton.Size = new Size(127, 34);
            updateExamInDBButton.TabIndex = 20;
            updateExamInDBButton.Text = "Vizsga Módosítása";
            updateExamInDBButton.UseVisualStyleBackColor = false;
            updateExamInDBButton.Click += updateExamInDBButton_Click_1;
            // 
            // addExamToDBButton
            // 
            addExamToDBButton.BackColor = Color.Transparent;
            addExamToDBButton.FlatAppearance.BorderSize = 0;
            addExamToDBButton.FlatStyle = FlatStyle.Flat;
            addExamToDBButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            addExamToDBButton.Location = new Point(664, 251);
            addExamToDBButton.Name = "addExamToDBButton";
            addExamToDBButton.Size = new Size(127, 34);
            addExamToDBButton.TabIndex = 21;
            addExamToDBButton.Text = "Vizsga Hozzáadása";
            addExamToDBButton.UseVisualStyleBackColor = false;
            addExamToDBButton.Click += addExamToDBButton_Click;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.BackColor = Color.Transparent;
            subjectLabel.FlatStyle = FlatStyle.Flat;
            subjectLabel.Location = new Point(28, 47);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(35, 15);
            subjectLabel.TabIndex = 22;
            subjectLabel.Text = "Tárgy";
            // 
            // subjectcodeLabel
            // 
            subjectcodeLabel.AutoSize = true;
            subjectcodeLabel.BackColor = Color.Transparent;
            subjectcodeLabel.FlatStyle = FlatStyle.Flat;
            subjectcodeLabel.Location = new Point(134, 47);
            subjectcodeLabel.Name = "subjectcodeLabel";
            subjectcodeLabel.Size = new Size(55, 15);
            subjectcodeLabel.TabIndex = 23;
            subjectcodeLabel.Text = "Tárgykód";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.BackColor = Color.Transparent;
            courseLabel.FlatStyle = FlatStyle.Flat;
            courseLabel.Location = new Point(240, 47);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new Size(42, 15);
            courseLabel.TabIndex = 24;
            courseLabel.Text = "Kurzus";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.BackColor = Color.Transparent;
            typeLabel.FlatStyle = FlatStyle.Flat;
            typeLabel.Location = new Point(346, 47);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(35, 15);
            typeLabel.TabIndex = 25;
            typeLabel.Text = "Típus";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.BackColor = Color.Transparent;
            startLabel.FlatStyle = FlatStyle.Flat;
            startLabel.Location = new Point(451, 47);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(43, 15);
            startLabel.TabIndex = 26;
            startLabel.Text = "Kezdés";
            // 
            // limitLabel
            // 
            limitLabel.AutoSize = true;
            limitLabel.BackColor = Color.Transparent;
            limitLabel.FlatStyle = FlatStyle.Flat;
            limitLabel.Location = new Point(558, 47);
            limitLabel.Name = "limitLabel";
            limitLabel.Size = new Size(52, 15);
            limitLabel.TabIndex = 27;
            limitLabel.Text = "Fő/Limit";
            // 
            // classroomLabel
            // 
            classroomLabel.AutoSize = true;
            classroomLabel.BackColor = Color.Transparent;
            classroomLabel.FlatStyle = FlatStyle.Flat;
            classroomLabel.Location = new Point(664, 47);
            classroomLabel.Name = "classroomLabel";
            classroomLabel.Size = new Size(39, 15);
            classroomLabel.TabIndex = 28;
            classroomLabel.Text = "Terem";
            // 
            // teacherLabel
            // 
            teacherLabel.AutoSize = true;
            teacherLabel.BackColor = Color.Transparent;
            teacherLabel.FlatStyle = FlatStyle.Flat;
            teacherLabel.Location = new Point(770, 47);
            teacherLabel.Name = "teacherLabel";
            teacherLabel.Size = new Size(43, 15);
            teacherLabel.TabIndex = 29;
            teacherLabel.Text = "Oktató";
            // 
            // subjectTB
            // 
            subjectTB.Location = new Point(28, 65);
            subjectTB.Name = "subjectTB";
            subjectTB.Size = new Size(100, 23);
            subjectTB.TabIndex = 30;
            // 
            // subjectcodeTB
            // 
            subjectcodeTB.Location = new Point(134, 65);
            subjectcodeTB.Name = "subjectcodeTB";
            subjectcodeTB.Size = new Size(100, 23);
            subjectcodeTB.TabIndex = 31;
            // 
            // courseTB
            // 
            courseTB.Location = new Point(240, 65);
            courseTB.Name = "courseTB";
            courseTB.Size = new Size(100, 23);
            courseTB.TabIndex = 32;
            // 
            // typeTB
            // 
            typeTB.Location = new Point(346, 65);
            typeTB.Name = "typeTB";
            typeTB.Size = new Size(100, 23);
            typeTB.TabIndex = 33;
            // 
            // startTB
            // 
            startTB.Location = new Point(452, 65);
            startTB.Name = "startTB";
            startTB.Size = new Size(100, 23);
            startTB.TabIndex = 34;
            // 
            // limitTB
            // 
            limitTB.Location = new Point(558, 65);
            limitTB.Name = "limitTB";
            limitTB.Size = new Size(100, 23);
            limitTB.TabIndex = 35;
            // 
            // classroomTB
            // 
            classroomTB.Location = new Point(664, 65);
            classroomTB.Name = "classroomTB";
            classroomTB.Size = new Size(100, 23);
            classroomTB.TabIndex = 36;
            // 
            // teacherTB
            // 
            teacherTB.Location = new Point(770, 65);
            teacherTB.Name = "teacherTB";
            teacherTB.Size = new Size(100, 23);
            teacherTB.TabIndex = 37;
            // 
            // ExamsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(1111, 494);
            Controls.Add(examsDataGridView);
            Controls.Add(teacherTB);
            Controls.Add(classroomTB);
            Controls.Add(limitTB);
            Controls.Add(startTB);
            Controls.Add(typeTB);
            Controls.Add(courseTB);
            Controls.Add(subjectcodeTB);
            Controls.Add(subjectTB);
            Controls.Add(teacherLabel);
            Controls.Add(classroomLabel);
            Controls.Add(limitLabel);
            Controls.Add(startLabel);
            Controls.Add(typeLabel);
            Controls.Add(courseLabel);
            Controls.Add(subjectcodeLabel);
            Controls.Add(subjectLabel);
            Controls.Add(addExamToDBButton);
            Controls.Add(updateExamInDBButton);
            Controls.Add(deleteExamButton);
            Controls.Add(updateExamButton);
            Controls.Add(applyButton);
            Controls.Add(addExamButton);
            Controls.Add(backButton);
            Controls.Add(myExamsButton);
            Controls.Add(HelpButton);
            ForeColor = Color.DarkOrange;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExamsForm";
            Text = "ExamsForm";
            toolTip1.SetToolTip(this, "Használati útmutató");
            ((System.ComponentModel.ISupportInitialize)examsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button HelpButton;
        private ToolTip toolTip1;
        private DataGridView examsDataGridView;
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
        private Button updateExamButton;
        private Button deleteExamButton;
        private Button updateExamInDBButton;
        private Button addExamToDBButton;
        private Label subjectLabel;
        private Label subjectcodeLabel;
        private Label courseLabel;
        private Label typeLabel;
        private Label startLabel;
        private Label limitLabel;
        private Label classroomLabel;
        private Label teacherLabel;
        private TextBox subjectTB;
        private TextBox subjectcodeTB;
        private TextBox courseTB;
        private TextBox typeTB;
        private TextBox startTB;
        private TextBox limitTB;
        private TextBox classroomTB;
        private TextBox teacherTB;
    }
}