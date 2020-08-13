using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    class Trapesium
    {
        private float a, b, c, d, t, luas, kel;

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
        public float luas_Trapesium()
        {
            luas = (a + b) * t / 2;
            return luas;
        }

        public float kel_Trapesium()
        {
            kel = a + b + c + d;
            return kel;
        }
    }
}