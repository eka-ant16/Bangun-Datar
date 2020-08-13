using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    class jajarGenjang
    {
        private float a, b, t, luas, kel;

        public float sisi
        {
            get { return a; }
            set
            {
                a = value;
            }
        }

        public float sisib
        {
            get { return b; }
            set
            {
                b = value;
            }
        }

        public float tinggi
        {
            get { return t; }
            set
            {
                t = value;
            }
        }

        public float luas_jajarGenjang()
        {
            luas = a * t;
            return luas;
        }

        public float kel_jajarGenjang()
        {
            kel = 2 * (a + b);
            return kel;
        }
    }
}