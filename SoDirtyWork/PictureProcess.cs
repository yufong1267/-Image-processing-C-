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


        /// <summary>
        /// 給定一張輸入的Bitmap，後面三個參數為R的權重；G的權重；B的權重
        /// return 一張修改後的Bitmap
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="r_weight"></param>
        /// <param name="g_weight"></param>
        /// <param name="b_weight"></param>
        /// <returns></returns>
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


        /// <summary>
        /// 輸入給定一張Bitmap
        /// return 一張灰階後的Bitmap
        /// 方法：採用每個pixel R G B中最小值為灰階值，因此花費時間比較久
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        public Bitmap min_GrayScale(Bitmap pic)
        {
            for (int i = 0; i < pic.Width; i++)
            {
                for (int j = 0; j < pic.Height; j++)
                {
                    bool min_r = (pic.GetPixel(i, j).R <= pic.GetPixel(i, j).G) && (pic.GetPixel(i, j).R <= pic.GetPixel(i, j).B);
                    bool min_g = (pic.GetPixel(i, j).G <= pic.GetPixel(i, j).R) && (pic.GetPixel(i, j).G <= pic.GetPixel(i, j).B);
                    bool min_b = (pic.GetPixel(i, j).B <= pic.GetPixel(i, j).R) && (pic.GetPixel(i, j).B <= pic.GetPixel(i, j).G);

                    if (min_r)
                    {
                        //全部換成r pixel
                        pic.SetPixel(i, j, Color.FromArgb(pic.GetPixel(i, j).R, pic.GetPixel(i, j).R, pic.GetPixel(i, j).R));
                    }
                    else if (min_g)
                    {
                        //全部換成 g pixel
                        pic.SetPixel(i, j, Color.FromArgb(pic.GetPixel(i, j).G, pic.GetPixel(i, j).G, pic.GetPixel(i, j).G));
                    }
                    else if (min_b)
                    {
                        //全部換成 g pixel
                        pic.SetPixel(i, j, Color.FromArgb(pic.GetPixel(i, j).B, pic.GetPixel(i, j).B, pic.GetPixel(i, j).B));
                    }
                }
            }
            return pic;
        }



        /// <summary>
        /// 輸入給定一張Bitmap  return 一個負片後的Bitmap
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        public Bitmap Negative_Picture(Bitmap pic)
        {
            for(int i = 0;i < pic.Width; i++)
            {
                for(int j = 0; j < pic.Height; j++)
                {
                    //每個byte的值取出來後用255扣掉
                    int r = 255 - pic.GetPixel(i, j).R,g = 255 - pic.GetPixel(i, j).G, b = 255 - pic.GetPixel(i, j).B;
                    pic.SetPixel(i,j,Color.FromArgb(r,g,b));
                }
            }

            return pic;
        }


        /// <summary>
        /// 輸入一個Bitmap，回傳整個RGB中R的分布
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
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


        /// <summary>
        /// 輸入一個Bitmap，回傳整個RGB中G的分布
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        public Bitmap G_trans(Bitmap pic)
        {
            Bitmap g_retengo = new Bitmap(pic.Width, 100);
            //找到每個橫排的最高點 
            for (int i = 0; i < pic.Width; i++)
            {
                double counter = 0;
                for (int j = 0; j < pic.Height; j++)
                {
                    int reg = Convert.ToInt32(pic.GetPixel(i, j).G);
                    counter += reg;
                }

                //塗色塗到最高點 讀取一排就畫一排
                double x = counter / (pic.Height * 255) * 100;
                int int_x = (int)x;
                //MessageBox.Show("" + int_x);
                for (int j = 99; int_x >= 0; j--)
                {
                    g_retengo.SetPixel(i, j, Color.Green);
                    int_x--;
                }
            }

            return g_retengo;
        }


        /// <summary>
        /// 輸入一個Bitmap，回傳整個RGB中B的分布
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        public Bitmap B_trans(Bitmap pic)
        {
            Bitmap b_retengo = new Bitmap(pic.Width, 100);

            //找到每個橫排的最高點 
            for (int i = 0; i < pic.Width; i++)
            {
                double counter = 0;
                for (int j = 0; j < pic.Height; j++)
                {
                    int reg = Convert.ToInt32(pic.GetPixel(i, j).B);
                    counter += reg;
                }

                //塗色塗到最高點 讀取一排就畫一排
                double x = counter / (pic.Height * 255) * 100;
                int int_x = (int)x;
                //MessageBox.Show("" + int_x);
                for (int j = 99; int_x >= 0; j--)
                {
                    b_retengo.SetPixel(i, j, Color.Blue);
                    int_x--;
                }
            }

            return b_retengo;
        }



        private Bitmap sep_r = null, sep_g = null, sep_b = null; //分割RGB
        public void separate_RGB(Bitmap pic)
        {
            //初始化 Bitmap大小
            sep_r = new Bitmap(pic.Width, pic.Height);
            sep_g = new Bitmap(pic.Width, pic.Height);
            sep_b = new Bitmap(pic.Width, pic.Height);

            for (int i = 0; i < pic.Width; i++)
            {
                for (int j = 0; j < pic.Height; j++)
                {
                    sep_r.SetPixel(i, j, Color.FromArgb(pic.GetPixel(i, j).R, 0, 0));
                    sep_g.SetPixel(i, j, Color.FromArgb(0, pic.GetPixel(i, j).G, 0));
                    sep_b.SetPixel(i, j, Color.FromArgb(0, 0, pic.GetPixel(i, j).B));
                }
            }
        }

        public Bitmap get_sep_R()
        {
            return this.sep_r;
        }

        public Bitmap get_sep_G()
        {
            return this.sep_g;
        }
        public Bitmap get_sep_B()
        {
            return this.sep_b;
        }

       
    }
}
