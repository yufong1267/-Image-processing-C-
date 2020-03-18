using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDirtyWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //圖片預處理優化
            this.DoubleBuffered = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            /* 開啟檔案 */
            OpenorSavePicture m_openorsavepicture = new OpenorSavePicture();
            Bitmap reg = m_openorsavepicture.OpenPicture();

            //放上照片
            pictureBox1.BackgroundImage = reg;
            pictureBox2.BackgroundImage = reg;

            //輸入長寬到label
            label1.Text = m_openorsavepicture.get_widthxHeight((Bitmap)pictureBox1.BackgroundImage);
            label2.Text = "修改後" + m_openorsavepicture.get_widthxHeight((Bitmap)pictureBox2.BackgroundImage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenorSavePicture save = new OpenorSavePicture();
            save.SavePicture((Bitmap)pictureBox2.BackgroundImage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PictureProcess change_size = new PictureProcess();

            //get width and height
            string str_width = m_width.Text.ToString() , str_height = m_height.Text.ToString();
            int int_width = Int32.Parse(str_width), int_height = Int32.Parse(str_height);
            pictureBox2.BackgroundImage = change_size.Resize((Bitmap)pictureBox2.BackgroundImage, int_width , int_height);

            //更新改變後 label的width x height
            label2.Text = "修改後" + change_size.get_widthxHeight((Bitmap)pictureBox2.BackgroundImage);
        }

        private void Grayscale_Click(object sender, EventArgs e)
        {
            //灰階
            PictureProcess m_gray = new PictureProcess();
            Bitmap n_background = m_gray.Mean_Value_Grayscle((Bitmap)pictureBox2.BackgroundImage);
            pictureBox2.BackgroundImage = n_background;

            //更新新的width x height
            label2.Text = "編輯後" + m_gray.get_widthxHeight((Bitmap)pictureBox2.BackgroundImage);
        }

        private void Max_Gray_Click(object sender, EventArgs e)
        {
            //最大值 灰階
            PictureProcess max_gray = new PictureProcess();
            Bitmap n_background = max_gray.max_Grayscale((Bitmap)pictureBox2.BackgroundImage);
            pictureBox2.BackgroundImage = n_background;

            //更新新的width x height
            label2.Text = "編輯後" + max_gray.get_widthxHeight((Bitmap)pictureBox2.BackgroundImage);
        }

        private void Weight_Gray_Click(object sender, EventArgs e)
        {
            PictureProcess w_gray = new PictureProcess();
            pictureBox2.BackgroundImage = w_gray.weight_GrayScale((Bitmap)pictureBox2.BackgroundImage, 0.299, 0.587, 0.114);

            //更新新的width x height
            label2.Text = "編輯後" + w_gray.get_widthxHeight((Bitmap)pictureBox2.BackgroundImage);
        }

        private void RGBget_Click(object sender, EventArgs e)
        {
            PictureProcess m_p = new PictureProcess();
            //RGB長條圖
            R_dis.BackgroundImage = m_p.R_trans((Bitmap)pictureBox2.BackgroundImage); 
            G_dis.BackgroundImage = m_p.G_trans((Bitmap)pictureBox2.BackgroundImage); 
            B_dis.BackgroundImage = m_p.B_trans((Bitmap)pictureBox2.BackgroundImage);

            //分離RGB
            m_p.separate_RGB((Bitmap)pictureBox2.BackgroundImage);
            R_only.BackgroundImage = m_p.get_sep_R();
            G_only.BackgroundImage = m_p.get_sep_G();
            B_only.BackgroundImage = m_p.get_sep_B();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
