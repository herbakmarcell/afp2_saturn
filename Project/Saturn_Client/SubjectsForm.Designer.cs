namespace Saturn_Client
{
    partial class SubjectsForm
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
            targynev = new DataGridViewTextBoxColumn();
            targykod = new DataGridViewTextBoxColumn();
            targycsopnev = new DataGridViewTextBoxColumn();
            sorszam = new DataGridViewTextBoxColumn();
            ajanlottfelev = new DataGridViewTextBoxColumn();
            kredit = new DataGridViewTextBoxColumn();
            targytipus = new DataGridViewTextBoxColumn();
            teljesitett = new DataGridViewTextBoxColumn();
            felvett = new DataGridViewTextBoxColumn();
            deleteSubjectButton = new Button();
            updateSubjectButton = new Button();
            applyButton = new Button();
            addSubjectButton = new Button();
            classroomTB = new TextBox();
            limitTB = new TextBox();
            startTB = new TextBox();
            typeTB = new TextBox();
            courseTB = new TextBox();
            subjectcodeTB = new TextBox();
            subjectTB = new TextBox();
            subjectTypeLabel = new Label();
            craditLabel = new Label();
            recSemesterLabel = new Label();
            subjectidLabel = new Label();
            subjectgroupLabel = new Label();
            subjectcodeLabel = new Label();
            subjectLabel = new Label();
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
            HelpButton.ForeColor = Color.DarkOrange;
            HelpButton.Location = new Point(979, 12);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { targynev, targykod, targycsopnev, sorszam, ajanlottfelev, kredit, targytipus, teljesitett, felvett });
            dataGridView1.Location = new Point(28, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(945, 284);
            dataGridView1.TabIndex = 13;
            // 
            // targynev
            // 
            targynev.HeaderText = "Tárgy neve";
            targynev.Name = "targynev";
            // 
            // targykod
            // 
            targykod.HeaderText = "Tárgy kódja";
            targykod.Name = "targykod";
            // 
            // targycsopnev
            // 
            targycsopnev.HeaderText = "Tárgycsoport neve";
            targycsopnev.Name = "targycsopnev";
            // 
            // sorszam
            // 
            sorszam.HeaderText = "Sorszám";
            sorszam.Name = "sorszam";
            // 
            // ajanlottfelev
            // 
            ajanlottfelev.HeaderText = "Ajánlott félév";
            ajanlottfelev.Name = "ajanlottfelev";
            // 
            // kredit
            // 
            kredit.HeaderText = "Kredit";
            kredit.Name = "kredit";
            // 
            // targytipus
            // 
            targytipus.HeaderText = "Tárgytípus";
            targytipus.Name = "targytipus";
            // 
            // teljesitett
            // 
            teljesitett.HeaderText = "Teljesített";
            teljesitett.Name = "teljesitett";
            // 
            // felvett
            // 
            felvett.HeaderText = "Felvett";
            felvett.Name = "felvett";
            // 
            // deleteSubjectButton
            // 
            deleteSubjectButton.BackColor = Color.Transparent;
            deleteSubjectButton.FlatAppearance.BorderSize = 0;
            deleteSubjectButton.FlatStyle = FlatStyle.Flat;
            deleteSubjectButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            deleteSubjectButton.ForeColor = Color.DarkOrange;
            deleteSubjectButton.Location = new Point(519, 312);
            deleteSubjectButton.Name = "deleteSubjectButton";
            deleteSubjectButton.Size = new Size(99, 34);
            deleteSubjectButton.TabIndex = 23;
            deleteSubjectButton.Text = "Tárgy Törlése";
            deleteSubjectButton.UseVisualStyleBackColor = false;
            deleteSubjectButton.Click += deleteSubjectButton_Click;
            // 
            // updateSubjectButton
            // 
            updateSubjectButton.BackColor = Color.Transparent;
            updateSubjectButton.FlatAppearance.BorderSize = 0;
            updateSubjectButton.FlatStyle = FlatStyle.Flat;
            updateSubjectButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            updateSubjectButton.ForeColor = Color.DarkOrange;
            updateSubjectButton.Location = new Point(624, 312);
            updateSubjectButton.Name = "updateSubjectButton";
            updateSubjectButton.Size = new Size(127, 34);
            updateSubjectButton.TabIndex = 22;
            updateSubjectButton.Text = "Tárgy Módosítása";
            updateSubjectButton.UseVisualStyleBackColor = false;
            updateSubjectButton.Click += updateSubjectButton_Click;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.Transparent;
            applyButton.FlatAppearance.BorderSize = 0;
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            applyButton.ForeColor = Color.DarkOrange;
            applyButton.Location = new Point(890, 312);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(83, 34);
            applyButton.TabIndex = 21;
            applyButton.Text = "Jelentkezés";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            // 
            // addSubjectButton
            // 
            addSubjectButton.BackColor = Color.Transparent;
            addSubjectButton.FlatAppearance.BorderSize = 0;
            addSubjectButton.FlatStyle = FlatStyle.Flat;
            addSubjectButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            addSubjectButton.ForeColor = Color.DarkOrange;
            addSubjectButton.Location = new Point(757, 312);
            addSubjectButton.Name = "addSubjectButton";
            addSubjectButton.Size = new Size(127, 34);
            addSubjectButton.TabIndex = 20;
            addSubjectButton.Text = "Tárgy Hozzáadása";
            addSubjectButton.UseVisualStyleBackColor = false;
            addSubjectButton.Click += addSubjectButton_Click;
            // 
            // classroomTB
            // 
            classroomTB.Location = new Point(678, 66);
            classroomTB.Name = "classroomTB";
            classroomTB.Size = new Size(100, 23);
            classroomTB.TabIndex = 52;
            // 
            // limitTB
            // 
            limitTB.Location = new Point(572, 66);
            limitTB.Name = "limitTB";
            limitTB.Size = new Size(100, 23);
            limitTB.TabIndex = 51;
            // 
            // startTB
            // 
            startTB.Location = new Point(466, 66);
            startTB.Name = "startTB";
            startTB.Size = new Size(100, 23);
            startTB.TabIndex = 50;
            // 
            // typeTB
            // 
            typeTB.Location = new Point(360, 66);
            typeTB.Name = "typeTB";
            typeTB.Size = new Size(100, 23);
            typeTB.TabIndex = 49;
            // 
            // courseTB
            // 
            courseTB.Location = new Point(254, 66);
            courseTB.Name = "courseTB";
            courseTB.Size = new Size(100, 23);
            courseTB.TabIndex = 48;
            // 
            // subjectcodeTB
            // 
            subjectcodeTB.Location = new Point(148, 66);
            subjectcodeTB.Name = "subjectcodeTB";
            subjectcodeTB.Size = new Size(100, 23);
            subjectcodeTB.TabIndex = 47;
            // 
            // subjectTB
            // 
            subjectTB.Location = new Point(42, 66);
            subjectTB.Name = "subjectTB";
            subjectTB.Size = new Size(100, 23);
            subjectTB.TabIndex = 46;
            // 
            // subjectTypeLabel
            // 
            subjectTypeLabel.AutoSize = true;
            subjectTypeLabel.BackColor = Color.Transparent;
            subjectTypeLabel.FlatStyle = FlatStyle.Flat;
            subjectTypeLabel.ForeColor = Color.DarkOrange;
            subjectTypeLabel.Location = new Point(678, 48);
            subjectTypeLabel.Name = "subjectTypeLabel";
            subjectTypeLabel.Size = new Size(61, 15);
            subjectTypeLabel.TabIndex = 44;
            subjectTypeLabel.Text = "Tárgytípus";
            // 
            // craditLabel
            // 
            craditLabel.AutoSize = true;
            craditLabel.BackColor = Color.Transparent;
            craditLabel.FlatStyle = FlatStyle.Flat;
            craditLabel.ForeColor = Color.DarkOrange;
            craditLabel.Location = new Point(572, 48);
            craditLabel.Name = "craditLabel";
            craditLabel.Size = new Size(38, 15);
            craditLabel.TabIndex = 43;
            craditLabel.Text = "Kredit";
            // 
            // recSemesterLabel
            // 
            recSemesterLabel.AutoSize = true;
            recSemesterLabel.BackColor = Color.Transparent;
            recSemesterLabel.FlatStyle = FlatStyle.Flat;
            recSemesterLabel.ForeColor = Color.DarkOrange;
            recSemesterLabel.Location = new Point(465, 48);
            recSemesterLabel.Name = "recSemesterLabel";
            recSemesterLabel.Size = new Size(77, 15);
            recSemesterLabel.TabIndex = 42;
            recSemesterLabel.Text = "Ajánlott félév";
            // 
            // subjectidLabel
            // 
            subjectidLabel.AutoSize = true;
            subjectidLabel.BackColor = Color.Transparent;
            subjectidLabel.FlatStyle = FlatStyle.Flat;
            subjectidLabel.ForeColor = Color.DarkOrange;
            subjectidLabel.Location = new Point(360, 48);
            subjectidLabel.Name = "subjectidLabel";
            subjectidLabel.Size = new Size(51, 15);
            subjectidLabel.TabIndex = 41;
            subjectidLabel.Text = "Sorszám";
            // 
            // subjectgroupLabel
            // 
            subjectgroupLabel.AutoSize = true;
            subjectgroupLabel.BackColor = Color.Transparent;
            subjectgroupLabel.FlatStyle = FlatStyle.Flat;
            subjectgroupLabel.ForeColor = Color.DarkOrange;
            subjectgroupLabel.Location = new Point(254, 48);
            subjectgroupLabel.Name = "subjectgroupLabel";
            subjectgroupLabel.Size = new Size(103, 15);
            subjectgroupLabel.TabIndex = 40;
            subjectgroupLabel.Text = "Tárgycsoport neve";
            // 
            // subjectcodeLabel
            // 
            subjectcodeLabel.AutoSize = true;
            subjectcodeLabel.BackColor = Color.Transparent;
            subjectcodeLabel.FlatStyle = FlatStyle.Flat;
            subjectcodeLabel.ForeColor = Color.DarkOrange;
            subjectcodeLabel.Location = new Point(148, 48);
            subjectcodeLabel.Name = "subjectcodeLabel";
            subjectcodeLabel.Size = new Size(55, 15);
            subjectcodeLabel.TabIndex = 39;
            subjectcodeLabel.Text = "Tárgykód";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.BackColor = Color.Transparent;
            subjectLabel.FlatStyle = FlatStyle.Flat;
            subjectLabel.ForeColor = Color.DarkOrange;
            subjectLabel.Location = new Point(42, 48);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(35, 15);
            subjectLabel.TabIndex = 38;
            subjectLabel.Text = "Tárgy";
            // 
            // SubjectsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(1111, 494);
            Controls.Add(deleteSubjectButton);
            Controls.Add(updateSubjectButton);
            Controls.Add(applyButton);
            Controls.Add(addSubjectButton);
            Controls.Add(dataGridView1);
            Controls.Add(HelpButton);
            Controls.Add(classroomTB);
            Controls.Add(limitTB);
            Controls.Add(startTB);
            Controls.Add(typeTB);
            Controls.Add(courseTB);
            Controls.Add(subjectcodeTB);
            Controls.Add(subjectTB);
            Controls.Add(subjectTypeLabel);
            Controls.Add(craditLabel);
            Controls.Add(recSemesterLabel);
            Controls.Add(subjectidLabel);
            Controls.Add(subjectgroupLabel);
            Controls.Add(subjectcodeLabel);
            Controls.Add(subjectLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SubjectsForm";
            Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button HelpButton;
        private ToolTip toolTip1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn targynev;
        private DataGridViewTextBoxColumn targykod;
        private DataGridViewTextBoxColumn targycsopnev;
        private DataGridViewTextBoxColumn sorszam;
        private DataGridViewTextBoxColumn ajanlottfelev;
        private DataGridViewTextBoxColumn kredit;
        private DataGridViewTextBoxColumn targytipus;
        private DataGridViewTextBoxColumn teljesitett;
        private DataGridViewTextBoxColumn felvett;
        private Button deleteSubjectButton;
        private Button updateSubjectButton;
        private Button applyButton;
        private Button addSubjectButton;
        private TextBox classroomTB;
        private TextBox limitTB;
        private TextBox startTB;
        private TextBox typeTB;
        private TextBox courseTB;
        private TextBox subjectcodeTB;
        private TextBox subjectTB;
        private Label subjectTypeLabel;
        private Label craditLabel;
        private Label recSemesterLabel;
        private Label subjectidLabel;
        private Label subjectgroupLabel;
        private Label subjectcodeLabel;
        private Label subjectLabel;
    }
}