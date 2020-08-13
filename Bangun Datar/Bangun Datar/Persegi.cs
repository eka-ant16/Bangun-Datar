using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    class Persegi
    {
        private float s, luas, kel_Persegi;

        public float sisi
        {
            get { return s; }
            set
            {
                s = value;
            }
        }

        public float luas_persegi()
        {
            luas = s * s;
            return luas;
        }

        public float kel_persegi()
        {
            kel_Persegi = s + s + s + s;
            return kel_Persegi;
        }
    }
}
