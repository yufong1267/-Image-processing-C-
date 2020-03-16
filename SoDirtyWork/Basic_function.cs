using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoDirtyWork
{
    class Basic_function
    {

        /// <summary>
        /// 給定一個慾輸出長寬的照片，回傳型態 Width x Height 
        /// </summary>
        /// <param name="pic"></param>
        /// <returns></returns>
        public String get_widthxHeight(Bitmap pic)
        {
            String WidthxHeight = pic.Width + " x " + pic.Height;

            return WidthxHeight;
        }

    }
}
