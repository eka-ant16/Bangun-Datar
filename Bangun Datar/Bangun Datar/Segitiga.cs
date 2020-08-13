using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    class Segitiga
    {
        private float a, t, s, luas, kel;

        public float alas
        {
            get { return a; }
            set
            {
                a = value;
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

        public float sisi
        {
            get { return t;  }
            set
            {
                s = value;
            }
        }

        public float luas_segitiga()
        {
            luas = (a * t) / 2;
            return luas;
        }

        public float kel_segitiga()
        {
            kel = s + s + s;
            return kel;
        }
    }
}
