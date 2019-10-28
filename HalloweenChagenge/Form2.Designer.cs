namespace HalloweenChagenge
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TitleFilm = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilmDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Minutes = new System.Windows.Forms.Label();
            this.FilmRating = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleFilm
            // 
            this.TitleFilm.AutoSize = true;
            this.TitleFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleFilm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TitleFilm.Location = new System.Drawing.Point(154, 21);
            this.TitleFilm.Name = "TitleFilm";
            this.TitleFilm.Size = new System.Drawing.Size(81, 24);
            this.TitleFilm.TabIndex = 0;
            this.TitleFilm.Text = "TitleFilm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // FilmDescription
            // 
            this.FilmDescription.AutoSize = true;
            this.FilmDescription.BackColor = System.Drawing.SystemColors.Window;
            this.FilmDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FilmDescription.Location = new System.Drawing.Point(29, 171);
            this.FilmDescription.Name = "FilmDescription";
            this.FilmDescription.Size = new System.Drawing.Size(78, 13);
            this.FilmDescription.TabIndex = 4;
            this.FilmDescription.Text = "FilmDescription";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(373, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 163);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.BackColor = System.Drawing.SystemColors.Window;
            this.Minutes.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Minutes.Location = new System.Drawing.Point(424, 203);
            this.Minutes.Name = "Minutes";
            this.Minutes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Minutes.Size = new System.Drawing.Size(44, 13);
            this.Minutes.TabIndex = 6;
            this.Minutes.Text = "Minutes";
            // 
            // FilmRating
            // 
            this.FilmRating.AutoSize = true;
            this.FilmRating.BackColor = System.Drawing.SystemColors.Window;
            this.FilmRating.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FilmRating.Location = new System.Drawing.Point(412, 234);
            this.FilmRating.Name = "FilmRating";
            this.FilmRating.Size = new System.Drawing.Size(56, 13);
            this.FilmRating.TabIndex = 7;
            this.FilmRating.Text = "FilmRating";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 256);
            this.Controls.Add(this.FilmRating);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FilmDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleFilm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FilmDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Label FilmRating;
    }
}