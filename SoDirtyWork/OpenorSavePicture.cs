using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDirtyWork
{
    class OpenorSavePicture : Basic_function
    {
        
        /// <summary>
        /// 開啟檔案，只需要呼叫即可
        /// </summary>
        /// <returns></returns>
        public Bitmap OpenPicture()
        {
            Bitmap output = null;

            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.GetEncoding(950), true))
                        {
                            output = new Bitmap(ofd.FileName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀檔失敗!!!!");
            }
            return output;
        }


        /// <summary>
        /// 給定一個欲存檔的圖片即可 type = Bitmap
        /// </summary>
        /// <param name="save_picture"></param>
        public void SavePicture(Bitmap save_picture)
        {
            /* 存檔功能 */

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();

            try
            {
                if (saveFileDialog1.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    save_picture.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fs.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("存檔失敗");
            }
        }

        
    }
}
