namespace SoDirtyWork
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_width = new System.Windows.Forms.TextBox();
            this.m_height = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Grayscale = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Max_Gray = new System.Windows.Forms.Button();
            this.Weight_Gray = new System.Windows.Forms.Button();
            this.R_dis = new System.Windows.Forms.PictureBox();
            this.RGBget = new System.Windows.Forms.Button();
            this.G_dis = new System.Windows.Forms.PictureBox();
            this.B_dis = new System.Windows.Forms.PictureBox();
            this.B_only = new System.Windows.Forms.PictureBox();
            this.G_only = new System.Windows.Forms.PictureBox();
            this.R_only = new System.Windows.Forms.PictureBox();
            this.min_grayscale = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_dis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_dis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_dis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_only)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_only)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_only)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "存檔";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 308);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "開啟圖片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(562, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 290);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height";
            // 
            // m_width
            // 
            this.m_width.Location = new System.Drawing.Point(375, 16);
            this.m_width.Name = "m_width";
            this.m_width.Size = new System.Drawing.Size(100, 25);
            this.m_width.TabIndex = 8;
            // 
            // m_height
            // 
            this.m_height.Location = new System.Drawing.Point(375, 42);
            this.m_height.Name = "m_height";
            this.m_height.Size = new System.Drawing.Size(100, 25);
            this.m_height.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(505, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 57);
            this.button3.TabIndex = 10;
            this.button3.Text = "Resize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Grayscale
            // 
            this.Grayscale.Location = new System.Drawing.Point(883, 34);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(75, 23);
            this.Grayscale.TabIndex = 11;
            this.Grayscale.Text = "均值";
            this.Grayscale.UseVisualStyleBackColor = true;
            this.Grayscale.Click += new System.EventHandler(this.Grayscale_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(880, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "灰階";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Max_Gray
            // 
            this.Max_Gray.Location = new System.Drawing.Point(883, 64);
            this.Max_Gray.Name = "Max_Gray";
            this.Max_Gray.Size = new System.Drawing.Size(75, 23);
            this.Max_Gray.TabIndex = 13;
            this.Max_Gray.Text = "最大值";
            this.Max_Gray.UseVisualStyleBackColor = true;
            this.Max_Gray.Click += new System.EventHandler(this.Max_Gray_Click);
            // 
            // Weight_Gray
            // 
            this.Weight_Gray.Location = new System.Drawing.Point(883, 94);
            this.Weight_Gray.Name = "Weight_Gray";
            this.Weight_Gray.Size = new System.Drawing.Size(75, 23);
            this.Weight_Gray.TabIndex = 14;
            this.Weight_Gray.Text = "加權值";
            this.Weight_Gray.UseVisualStyleBackColor = true;
            this.Weight_Gray.Click += new System.EventHandler(this.Weight_Gray_Click);
            // 
            // R_dis
            // 
            this.R_dis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.R_dis.Location = new System.Drawing.Point(15, 408);
            this.R_dis.Name = "R_dis";
            this.R_dis.Size = new System.Drawing.Size(98, 86);
            this.R_dis.TabIndex = 15;
            this.R_dis.TabStop = false;
            // 
            // RGBget
            // 
            this.RGBget.Location = new System.Drawing.Point(400, 112);
            this.RGBget.Name = "RGBget";
            this.RGBget.Size = new System.Drawing.Size(75, 23);
            this.RGBget.TabIndex = 16;
            this.RGBget.Text = "分離RGB";
            this.RGBget.UseVisualStyleBackColor = true;
            this.RGBget.Click += new System.EventHandler(this.RGBget_Click);
            // 
            // G_dis
            // 
            this.G_dis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.G_dis.Location = new System.Drawing.Point(119, 408);
            this.G_dis.Name = "G_dis";
            this.G_dis.Size = new System.Drawing.Size(100, 86);
            this.G_dis.TabIndex = 17;
            this.G_dis.TabStop = false;
            // 
            // B_dis
            // 
            this.B_dis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_dis.Location = new System.Drawing.Point(225, 408);
            this.B_dis.Name = "B_dis";
            this.B_dis.Size = new System.Drawing.Size(106, 86);
            this.B_dis.TabIndex = 18;
            this.B_dis.TabStop = false;
            // 
            // B_only
            // 
            this.B_only.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.B_only.Location = new System.Drawing.Point(225, 509);
            this.B_only.Name = "B_only";
            this.B_only.Size = new System.Drawing.Size(106, 86);
            this.B_only.TabIndex = 21;
            this.B_only.TabStop = false;
            // 
            // G_only
            // 
            this.G_only.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.G_only.Location = new System.Drawing.Point(119, 509);
            this.G_only.Name = "G_only";
            this.G_only.Size = new System.Drawing.Size(100, 86);
            this.G_only.TabIndex = 20;
            this.G_only.TabStop = false;
            // 
            // R_only
            // 
            this.R_only.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.R_only.Location = new System.Drawing.Point(15, 509);
            this.R_only.Name = "R_only";
            this.R_only.Size = new System.Drawing.Size(98, 86);
            this.R_only.TabIndex = 19;
            this.R_only.TabStop = false;
            // 
            // min_grayscale
            // 
            this.min_grayscale.Location = new System.Drawing.Point(883, 124);
            this.min_grayscale.Name = "min_grayscale";
            this.min_grayscale.Size = new System.Drawing.Size(75, 23);
            this.min_grayscale.TabIndex = 22;
            this.min_grayscale.Text = "最小值";
            this.min_grayscale.UseVisualStyleBackColor = true;
            this.min_grayscale.Click += new System.EventHandler(this.min_grayscale_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(883, 154);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 23;
            this.minus.Text = "負片";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 936);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.min_grayscale);
            this.Controls.Add(this.B_only);
            this.Controls.Add(this.G_only);
            this.Controls.Add(this.R_only);
            this.Controls.Add(this.B_dis);
            this.Controls.Add(this.G_dis);
            this.Controls.Add(this.RGBget);
            this.Controls.Add(this.R_dis);
            this.Controls.Add(this.Weight_Gray);
            this.Controls.Add(this.Max_Gray);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Grayscale);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.m_height);
            this.Controls.Add(this.m_width);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_dis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_dis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_dis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_only)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G_only)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_only)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_width;
        private System.Windows.Forms.TextBox m_height;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Grayscale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Max_Gray;
        private System.Windows.Forms.Button Weight_Gray;
        private System.Windows.Forms.PictureBox R_dis;
        private System.Windows.Forms.Button RGBget;
        private System.Windows.Forms.PictureBox G_dis;
        private System.Windows.Forms.PictureBox B_dis;
        private System.Windows.Forms.PictureBox B_only;
        private System.Windows.Forms.PictureBox G_only;
        private System.Windows.Forms.PictureBox R_only;
        private System.Windows.Forms.Button min_grayscale;
        private System.Windows.Forms.Button minus;
    }
}

