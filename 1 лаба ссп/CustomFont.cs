using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_лаба_ссп
{
    [Serializable]
    public class CustomFont
    {
        public String fontFamily;

       public  float size;

       public FontStyle fontStyle;

       public  Color color;

        public CustomFont()
        {
        }

        public CustomFont(String fontFamily, float size, FontStyle fontStyle)
        {
            this.fontFamily = fontFamily;
            this.size = size;
            this.fontStyle = fontStyle;
        }

        public CustomFont(String fontFamily, float size, FontStyle fontStyle, Color color)
        {
            this.fontFamily = fontFamily;
            this.size = size;
            this.fontStyle = fontStyle;
            this.color = color;
        }
    }
}
