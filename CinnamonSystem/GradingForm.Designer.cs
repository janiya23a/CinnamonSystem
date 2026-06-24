namespace CinnamonSystem
{
    partial class GradingForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPayout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.cmbWorkers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMoisture = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "🍂 CGPS \r\nGRADING CONSOLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtPayout
            // 
            this.txtPayout.BackColor = System.Drawing.Color.White;
            this.txtPayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPayout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPayout.Location = new System.Drawing.Point(284, 49);
            this.txtPayout.Name = "txtPayout";
            this.txtPayout.ReadOnly = true;
            this.txtPayout.Size = new System.Drawing.Size(100, 27);
            this.txtPayout.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(23, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Payout (Rs):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 78);
            this.panel1.TabIndex = 17;
            // 
            // txtWeight
            // 
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeight.Location = new System.Drawing.Point(285, 118);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(206, 27);
            this.txtWeight.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(20, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "3. Weight (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Enter Quill Diameter (mm):";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULATE GRADE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDiameter
            // 
            this.txtDiameter.BackColor = System.Drawing.Color.White;
            this.txtDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiameter.Location = new System.Drawing.Point(285, 72);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(206, 27);
            this.txtDiameter.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.label3.Location = new System.Drawing.Point(22, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Assigned Grade:";
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.White;
            this.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrade.Location = new System.Drawing.Point(284, 16);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(159, 27);
            this.txtGrade.TabIndex = 3;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // cmbWorkers
            // 
            this.cmbWorkers.FormattingEnabled = true;
            this.cmbWorkers.Items.AddRange(new object[] {
            "Kamal",
            "Nimal"});
            this.cmbWorkers.Location = new System.Drawing.Point(285, 20);
            this.cmbWorkers.Name = "cmbWorkers";
            this.cmbWorkers.Size = new System.Drawing.Size(206, 28);
            this.cmbWorkers.TabIndex = 9;
            this.cmbWorkers.SelectedIndexChanged += new System.EventHandler(this.cmbWorkers_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label7.Location = new System.Drawing.Point(20, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "4. Moisture Content (%):";
            // 
            // txtMoisture
            // 
            this.txtMoisture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoisture.Location = new System.Drawing.Point(285, 163);
            this.txtMoisture.Name = "txtMoisture";
            this.txtMoisture.Size = new System.Drawing.Size(206, 27);
            this.txtMoisture.TabIndex = 15;
            this.txtMoisture.TextChanged += new System.EventHandler(this.txtMoisture_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "1.Select Worker:";
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(343, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "CLEAR FORM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtPayout);
            this.panel3.Controls.Add(this.txtGrade);
            this.panel3.Location = new System.Drawing.Point(34, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 91);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMoisture);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbWorkers);
            this.panel2.Controls.Add(this.txtDiameter);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtWeight);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(32, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 428);
            this.panel2.TabIndex = 18;
            // 
            // GradingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GradingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GradingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPayout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.ComboBox cmbWorkers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMoisture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}