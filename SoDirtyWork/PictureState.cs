using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDirtyWork
{
    class PictureState
    {
        //Bitmap vector implementation
        Bitmap[] bm = new Bitmap[100];
        int bm_index = 0;


        /// <summary>
        /// 此Vector最大Size為100
        /// </summary>
        public PictureState()
        {

        }

        /// <summary>
        /// 輸入一個送入堆疊的Bitmap。  因為不是直接把refrence複製過來，而是一個Pixel一個Pixel setpixel上去，所以比較會花費時間。
        /// </summary>
        /// <param name="pic"></param>
        public void Push(Bitmap pic)
        {
            bm[bm_index] = new Bitmap(pic.Width , pic.Height);
            for(int i = 0; i < pic.Width; i++)
            {
                for(int j = 0; j < pic.Height; j++)
                {
                    bm[bm_index].SetPixel(i, j, Color.FromArgb(pic.GetPixel(i, j).R, pic.GetPixel(i, j).G, pic.GetPixel(i, j).B));
                }
            }

            bm_index++;

            if(bm_index > 99)
            {
                //大於最大值從最小的開始往回扣
                bm_index = 0;
            }
        }


        /// <summary>
        /// 使用前要先確定有push東西進來才可以使用，不需輸入參數。 
        /// Exception：如果沒有push Bitmap近來會獲得MessageBox提醒
        /// </summary>
        /// <returns></returns>
        public Bitmap Pop()
        {
            bm_index--;
            if(bm_index < 0)
            {
                bm_index = 0;
            }

            try
            {
                return bm[bm_index];
            }
            catch(Exception ex)
            {
                //可能此Refrence為null，表示這個index的Bitmap還沒有存Bitmap導致的
                MessageBox.Show("還沒有push任何東西進來喔");
                return null;
            }
            
        }
    }
}
