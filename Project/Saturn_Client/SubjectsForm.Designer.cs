﻿namespace Saturn_Client
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
            subjectDataGridView = new DataGridView();
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
            subjecttypeTB = new TextBox();
            creditTB = new TextBox();
            recSemesterTB = new TextBox();
            subjectidTB = new TextBox();
            subjectgroupTB = new TextBox();
            subjectcodeTB = new TextBox();
            subjectTB = new TextBox();
            subjectTypeLabel = new Label();
            craditLabel = new Label();
            recSemesterLabel = new Label();
            subjectidLabel = new Label();
            subjectgroupLabel = new Label();
            subjectcodeLabel = new Label();
            subjectLabel = new Label();
            backButton = new Button();
            ((System.ComponentModel.ISupportInitialize)subjectDataGridView).BeginInit();
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
            // subjectDataGridView
            // 
            subjectDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subjectDataGridView.Columns.AddRange(new DataGridViewColumn[] { targynev, targykod, targycsopnev, sorszam, ajanlottfelev, kredit, targytipus, teljesitett, felvett });
            subjectDataGridView.Location = new Point(24, 51);
            subjectDataGridView.Name = "subjectDataGridView";
            subjectDataGridView.Size = new Size(945, 284);
            subjectDataGridView.TabIndex = 13;
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
            deleteSubjectButton.Location = new Point(515, 351);
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
            updateSubjectButton.Location = new Point(620, 351);
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
            applyButton.Location = new Point(886, 351);
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
            addSubjectButton.Location = new Point(753, 351);
            addSubjectButton.Name = "addSubjectButton";
            addSubjectButton.Size = new Size(127, 34);
            addSubjectButton.TabIndex = 20;
            addSubjectButton.Text = "Tárgy Hozzáadása";
            addSubjectButton.UseVisualStyleBackColor = false;
            addSubjectButton.Click += addSubjectButton_Click;
            // 
            // subjecttypeTB
            // 
            subjecttypeTB.Location = new Point(674, 105);
            subjecttypeTB.Name = "subjecttypeTB";
            subjecttypeTB.Size = new Size(100, 23);
            subjecttypeTB.TabIndex = 52;
            // 
            // creditTB
            // 
            creditTB.Location = new Point(568, 105);
            creditTB.Name = "creditTB";
            creditTB.Size = new Size(100, 23);
            creditTB.TabIndex = 51;
            // 
            // recSemesterTB
            // 
            recSemesterTB.Location = new Point(462, 105);
            recSemesterTB.Name = "recSemesterTB";
            recSemesterTB.Size = new Size(100, 23);
            recSemesterTB.TabIndex = 50;
            // 
            // subjectidTB
            // 
            subjectidTB.Location = new Point(356, 105);
            subjectidTB.Name = "subjectidTB";
            subjectidTB.Size = new Size(100, 23);
            subjectidTB.TabIndex = 49;
            // 
            // subjectgroupTB
            // 
            subjectgroupTB.Location = new Point(250, 105);
            subjectgroupTB.Name = "subjectgroupTB";
            subjectgroupTB.Size = new Size(100, 23);
            subjectgroupTB.TabIndex = 48;
            // 
            // subjectcodeTB
            // 
            subjectcodeTB.Location = new Point(144, 105);
            subjectcodeTB.Name = "subjectcodeTB";
            subjectcodeTB.Size = new Size(100, 23);
            subjectcodeTB.TabIndex = 47;
            // 
            // subjectTB
            // 
            subjectTB.Location = new Point(38, 105);
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
            subjectTypeLabel.Location = new Point(674, 87);
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
            craditLabel.Location = new Point(568, 87);
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
            recSemesterLabel.Location = new Point(461, 87);
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
            subjectidLabel.Location = new Point(356, 87);
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
            subjectgroupLabel.Location = new Point(250, 87);
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
            subjectcodeLabel.Location = new Point(144, 87);
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
            subjectLabel.Location = new Point(38, 87);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(35, 15);
            subjectLabel.TabIndex = 38;
            subjectLabel.Text = "Tárgy";
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Underline, GraphicsUnit.Point, 238);
            backButton.ForeColor = Color.DarkOrange;
            backButton.Location = new Point(909, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(60, 34);
            backButton.TabIndex = 53;
            backButton.Text = "<Vissza";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // SubjectsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(1111, 494);
            Controls.Add(backButton);
            Controls.Add(subjectDataGridView);
            Controls.Add(deleteSubjectButton);
            Controls.Add(updateSubjectButton);
            Controls.Add(applyButton);
            Controls.Add(addSubjectButton);
            Controls.Add(HelpButton);
            Controls.Add(subjecttypeTB);
            Controls.Add(creditTB);
            Controls.Add(recSemesterTB);
            Controls.Add(subjectidTB);
            Controls.Add(subjectgroupTB);
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
            ((System.ComponentModel.ISupportInitialize)subjectDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button HelpButton;
        private ToolTip toolTip1;
        private DataGridView subjectDataGridView;
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
        private TextBox subjecttypeTB;
        private TextBox creditTB;
        private TextBox recSemesterTB;
        private TextBox subjectidTB;
        private TextBox subjectgroupTB;
        private TextBox subjectcodeTB;
        private TextBox subjectTB;
        private Label subjectTypeLabel;
        private Label craditLabel;
        private Label recSemesterLabel;
        private Label subjectidLabel;
        private Label subjectgroupLabel;
        private Label subjectcodeLabel;
        private Label subjectLabel;
        private Button backButton;
    }
}