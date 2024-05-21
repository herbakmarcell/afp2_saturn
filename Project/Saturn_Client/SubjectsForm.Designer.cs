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
            dataGridView1.Location = new Point(28, 12);
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
            // SubjectsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBackFinal;
            ClientSize = new Size(1111, 494);
            Controls.Add(dataGridView1);
            Controls.Add(HelpButton);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SubjectsForm";
            Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
    }
}