namespace HalloweenChagenge
{
    partial class Form1
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
            this.Films = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilmTextBox = new System.Windows.Forms.TextBox();
            this.FilmButton = new System.Windows.Forms.Button();
            this.FilmsFoundLabel = new System.Windows.Forms.Label();
            this.FilmWordCheckBox = new System.Windows.Forms.CheckBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.Films.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Films
            // 
            this.Films.Controls.Add(this.FilmsListBox);
            this.Films.Controls.Add(this.FilmWordCheckBox);
            this.Films.Controls.Add(this.FilmsFoundLabel);
            this.Films.Controls.Add(this.FilmButton);
            this.Films.Controls.Add(this.FilmTextBox);
            this.Films.Controls.Add(this.label2);
            this.Films.Location = new System.Drawing.Point(23, 4);
            this.Films.Name = "Films";
            this.Films.Padding = new System.Windows.Forms.Padding(3);
            this.Films.Size = new System.Drawing.Size(551, 226);
            this.Films.TabIndex = 1;
            this.Films.Text = "Films";
            this.Films.UseVisualStyleBackColor = true;
            this.Films.UseWaitCursor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.Films);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 70);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 234);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.UseWaitCursor = true;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(23, 4);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(551, 226);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(551, 226);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Staff";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAKILA FILMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(30, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // FilmTextBox
            // 
            this.FilmTextBox.Location = new System.Drawing.Point(89, 10);
            this.FilmTextBox.Name = "FilmTextBox";
            this.FilmTextBox.Size = new System.Drawing.Size(323, 20);
            this.FilmTextBox.TabIndex = 1;
            // 
            // FilmButton
            // 
            this.FilmButton.Location = new System.Drawing.Point(436, 7);
            this.FilmButton.Name = "FilmButton";
            this.FilmButton.Size = new System.Drawing.Size(95, 38);
            this.FilmButton.TabIndex = 2;
            this.FilmButton.Text = "Find";
            this.FilmButton.UseVisualStyleBackColor = true;
            this.FilmButton.Click += new System.EventHandler(this.FilmButton_Click);
            // 
            // FilmsFoundLabel
            // 
            this.FilmsFoundLabel.AutoSize = true;
            this.FilmsFoundLabel.Location = new System.Drawing.Point(86, 51);
            this.FilmsFoundLabel.Name = "FilmsFoundLabel";
            this.FilmsFoundLabel.Size = new System.Drawing.Size(81, 13);
            this.FilmsFoundLabel.TabIndex = 3;
            this.FilmsFoundLabel.Text = "0 records found";
            // 
            // FilmWordCheckBox
            // 
            this.FilmWordCheckBox.AutoSize = true;
            this.FilmWordCheckBox.Location = new System.Drawing.Point(412, 51);
            this.FilmWordCheckBox.Name = "FilmWordCheckBox";
            this.FilmWordCheckBox.Size = new System.Drawing.Size(119, 17);
            this.FilmWordCheckBox.TabIndex = 4;
            this.FilmWordCheckBox.Text = "Match Whole Word";
            this.FilmWordCheckBox.UseVisualStyleBackColor = true;
            this.FilmWordCheckBox.CheckedChanged += new System.EventHandler(this.FilmWordCheckBox_CheckedChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.Location = new System.Drawing.Point(89, 76);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(441, 134);
            this.FilmsListBox.TabIndex = 5;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(576, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Films.ResumeLayout(false);
            this.Films.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage Films;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilmButton;
        private System.Windows.Forms.TextBox FilmTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.CheckBox FilmWordCheckBox;
        private System.Windows.Forms.Label FilmsFoundLabel;
    }
}

