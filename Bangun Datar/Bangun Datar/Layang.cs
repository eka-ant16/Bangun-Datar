using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    class Layang
    {
        private float a, b, c, d, d1, d2, luas, kel;

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

        public float sisic
        {
            get { return c; }
            set
            {
                c = value;
            }
        }

        public float sisid
        {
            get { return d; }
            set
            {
                d = value;
            }
        }
        public float luas_Layang()
        {
            luas = (d1 * d2) / 2;
            return luas;
        }

        public float kel_Layang()
        {
            kel = a + b + c + d;
            return kel;
        }
    }
}