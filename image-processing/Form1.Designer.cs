namespace image_processing
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_mean_filter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Q = new System.Windows.Forms.TextBox();
            this.btn_max = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_midpoint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_d = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mean_filter
            // 
            this.btn_mean_filter.Location = new System.Drawing.Point(187, 314);
            this.btn_mean_filter.Name = "btn_mean_filter";
            this.btn_mean_filter.Size = new System.Drawing.Size(84, 51);
            this.btn_mean_filter.TabIndex = 1;
            this.btn_mean_filter.Text = "Contra Harmonic Mean Filter";
            this.btn_mean_filter.UseVisualStyleBackColor = true;
            this.btn_mean_filter.Click += new System.EventHandler(this.btn_mean_filter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(314, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Q
            // 
            this.txt_Q.Location = new System.Drawing.Point(113, 327);
            this.txt_Q.Name = "txt_Q";
            this.txt_Q.Size = new System.Drawing.Size(68, 20);
            this.txt_Q.TabIndex = 4;
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(277, 327);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(75, 23);
            this.btn_max.TabIndex = 5;
            this.btn_max.Text = "Max";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(358, 327);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(75, 24);
            this.btn_min.TabIndex = 6;
            this.btn_min.Text = "Min";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_midpoint
            // 
            this.btn_midpoint.Location = new System.Drawing.Point(439, 328);
            this.btn_midpoint.Name = "btn_midpoint";
            this.btn_midpoint.Size = new System.Drawing.Size(75, 23);
            this.btn_midpoint.TabIndex = 7;
            this.btn_midpoint.Text = "Midpoint";
            this.btn_midpoint.UseVisualStyleBackColor = true;
            this.btn_midpoint.Click += new System.EventHandler(this.btn_midpoint_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Alpha";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(521, 293);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(75, 20);
            this.txt_d.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 375);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_midpoint);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.txt_Q);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_mean_filter);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_mean_filter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_Q;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_midpoint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_d;
    }
}

