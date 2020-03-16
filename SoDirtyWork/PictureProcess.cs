using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDirtyWork
{
    class PictureProcess : Basic_function
    {
        /// <summary>
        /// 照片Resize
        /// </summary>
        /// <param name="original_picture"></param>
        /// <param name="r_size"></param>
        /// <returns></returns>
        public Bitmap Resize(Bitmap original_picture , Size r_size)
        {
            return (new Bitmap(original_picture, r_size));
        }

        /// <summary>
        /// 輸入欲改變的照片以及width and height
        /// </summary>
        /// <param name="original_picture"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Bitmap Resize(Bitmap original_picture , int width , int height)
        {
            Size x = new Size(width, height);
            return (new Bitmap(original_picture, x));
        }

        /// <summary>
        /// 圖片取RGB的值做灰階
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        public Bitmap Mean_Value_Grayscle(Bitmap pic)
        {
            //取出所想pixel的RGB平均
            for(int i = 0; i < pic.Width; i++)
            {
                for(int j = 0; j < pic.Height; j++)
                {
                    byte r = pic.GetPixel(i, j).R , g = pic.GetPixel(i,j).G , b = pic.GetPixel(i,j).B;
                    byte mean = (byte)((r + g + b) / 3);

                    pic.SetPixel(i, j,Color.FromArgb(mean,mean,mean));
                }
            }

            return pic;
        }


        /// <summary>
        /// 給定一個欲使用最大化灰階的Bitmap。 取一個RGB中最大的值當成灰階值
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        public Bitmap max_Grayscale(Bitmap pic)
        {
            for(int i = 0; i < pic.Width; i++)
            {
                for (int j = 0; j < pic.Height; j++)
                {
                    bool max_r = (pic.GetPixel(i, j).R >= pic.GetPixel(i, j).G) && (pic.GetPixel(i, j).R >= pic.GetPixel(i, j).B);
                    bool max_g = (pic.GetPixel(i, j).G >= pic.GetPixel(i, j).R) && (pic.GetPixel(i, j).G >= pic.GetPixel(i, j).B);
                    bool max_b = (pic.GetPixel(i, j).B >= pic.GetPixel(i, j).R) && (pic.GetPixel(i, j).B >= pic.GetPixel(i, j).G);

                    if(max_r)
                    {
                        //全部換成r pixel
                        pic.SetPixel(i, j, Color.FromArgb(pic.GetPixel(i, j).R, pic.GetPixel(i, j).R, pic.GetPixel(i, j).R));
                    }else if(max_g)
                    {
                        //全部換成 g pixel
                        pic.SetPixel(i, j, Color.FromArgb(pic.GetPixel(i, j).G, pic.GetPixel(i, j).G, pic.GetPixel(i, j).G));
                    }else if(max_b)
                    {
                        //全部換成 g pixel
                        pic.SetPixel(i, j, Color.FromArgb(pic.GetPixel(i, j).B, pic.GetPixel(i, j).B, pic.GetPixel(i, j).B));
                    }
                }
            }

            return pic;
        }

        public Bitmap weight_GrayScale(Bitmap pic , double r_weight , double g_weight , double b_weight)
        {
            for(int i = 0; i < pic.Width; i++)
            {
                for(int j = 0;j < pic.Height; j++)
                {
                    int r = Convert.ToInt32(pic.GetPixel(i, j).R * r_weight) , g = Convert.ToInt32(pic.GetPixel(i, j).G * g_weight) , b = Convert.ToInt32(pic.GetPixel(i, j).B * b_weight);
                    //全部換成 g pixel
                    pic.SetPixel(i, j, Color.FromArgb(r,g,b));
                }
            }

            return pic;
        }

        public Bitmap R_trans(Bitmap pic)
        {
            Bitmap r_retengo = new Bitmap(pic.Width , 100);

            //找到每個橫排的最高點 
            for(int i = 0; i < pic.Width; i++)
            {
                double counter = 0;
                for(int j = 0; j < pic.Height; j++)
                {
                    int reg = Convert.ToInt32(pic.GetPixel(i, j).R);
                    counter += reg;
                }

                //塗色塗到最高點 讀取一排就畫一排
                double x = counter / (pic.Height * 255) * 100;
                int int_x = (int)x;
                //MessageBox.Show("" + int_x);
                for(int j = 99; int_x >= 0; j--)
                {
                    r_retengo.SetPixel(i, j, Color.Red);
                    int_x--;
                }
            }

            return r_retengo;
        }

    }
}
