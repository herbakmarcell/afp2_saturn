namespace Saturn_Client
{
    partial class InboxForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            HelpButton = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 9F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(59, 21);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Küldő";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 9F);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(235, 21);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Tárgy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 9F);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(637, 21);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 2;
            label3.Text = "Érkezés időpontja";
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
            HelpButton.Location = new Point(999, 16);
            HelpButton.Margin = new Padding(3, 4, 3, 4);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(31, 36);
            HelpButton.TabIndex = 19;
            HelpButton.Text = "?";
            toolTip1.SetToolTip(HelpButton, "Használati útmutató");
            HelpButton.UseVisualStyleBackColor = false;
            HelpButton.Click += HelpButton_Click;
            // 
            // InboxForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dataBack;
            ClientSize = new Size(1091, 462);
            Controls.Add(HelpButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InboxForm";
            Text = "Inbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button HelpButton;
        private ToolTip toolTip1;
    }
}