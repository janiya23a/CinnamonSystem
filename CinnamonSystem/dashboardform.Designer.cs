namespace CinnamonSystem
{
    partial class dashboardform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardform));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrading = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(128, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAIN MENU";
            // 
            // btnGrading
            // 
            this.btnGrading.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGrading.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrading.Location = new System.Drawing.Point(96, 131);
            this.btnGrading.Name = "btnGrading";
            this.btnGrading.Size = new System.Drawing.Size(196, 41);
            this.btnGrading.TabIndex = 1;
            this.btnGrading.Text = "Cinnamon Grading";
            this.btnGrading.UseVisualStyleBackColor = false;
            this.btnGrading.Click += new System.EventHandler(this.btnGrading_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(148, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Exit System.";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-115, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 361);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGrading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "dashboardform";
            this.Text = "dashboardform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrading;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}