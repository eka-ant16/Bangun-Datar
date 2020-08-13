using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    class belahKetupat
    {
        private float s, d1, d2, luas, kel;

        public float sisi
        {
            get { return s; }
            set
            {
                s = value;
            }
        }

        public float diagonal1
        {
            get { return d1; }
            set
            {
                d1 = value;
            }
        }

        public float diagonal2
        {
            get { return d2; }
            set
            {
                d2 = value;
            }
        }

        public float luas_belah()
        {
            luas = (d1 * d2) / 2;
            return luas;pke 
        }

        public float kel_belah()
        {
            kel = s + s + s + s;
            return kel;
        }
    }
}
