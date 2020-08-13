using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    class persegiPanjang
    {
        private float p, l, luas, kel;

        public float panjang
        {
            get { return p; }
            set
            {
                p = value;
            }
        }

        public float lebar
        {
            get { return l; }
            set
            {
                l = value;
            }
        }

        public float luas_PersegiPanjang()
        {
            luas = p * l;
            return luas;
        }

        public float kel_PersegiPanjang()
        {
            kel = 2 * (p + l);
            return kel;
        }
    }
}
