using System;
using System.Collections.Generic;
using System.Text;

namespace Bangun_Datar
{
    class Menu
    {
        public int pilih;

        public void menu()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("====== PROGRAM MENGHITUNG LUAS BANGUN DATAR ======");
            Console.WriteLine("=================By Eka MUkti=====================");
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Persegi");
            Console.WriteLine("2. Persegi Panjang");
            Console.WriteLine("3. Segitiga");
            Console.WriteLine("4. jajargenjang");
            Console.WriteLine("5. Trapesium");
            Console.WriteLine("6. Layang-Layang");
            Console.WriteLine("7. Belah Ketupat");
            Console.Write("Masukkan Pilihan : ");
            pilih = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (pilih)
            {
                case 1:
                    {
                        Persegi a = new Persegi();

                        Console.WriteLine("Menghitung Luas Dan Keliling Persegi");
                        Console.WriteLine("------------------------------------");
                        Console.Write("Sisi : ");
                        a.sisi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas : {0} cm", a.luas_persegi());
                        Console.WriteLine("Keliling : {0} cm", a.kel_persegi());

                        break;
                    }
                case 2:
                    {
                        persegiPanjang b = new persegiPanjang();

                        Console.WriteLine("Menghitung Luas Dan Keliling Persegi Panjang");
                        Console.WriteLine("--------------------------------------------");
                        Console.Write("Panjang : ");
                        b.panjang = (int.Parse(Console.ReadLine()));
                        Console.Write("Lebar   : ");
                        b.lebar = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas : {0} cm", b.luas_PersegiPanjang());
                        Console.WriteLine("Keliling : {0} cm", b.kel_PersegiPanjang());

                        break;
                    }

                case 3:
                    {
                        Segitiga c = new Segitiga();

                        Console.WriteLine("Menghitung Luas Segitiga");
                        Console.WriteLine("------------------------");
                        Console.Write("Alas   : ");
                        c.alas = (int.Parse(Console.ReadLine()));
                        Console.Write("Tinggi : ");
                        c.tinggi = (int.Parse(Console.ReadLine()));
                        Console.Write("Sisi   : ");
                        c.sisi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas : {0} cm", c.luas_segitiga());
                        Console.WriteLine("Keliling : {0} cm", c.kel_segitiga());

                        break;
                    }
                case 4:
                    {
                        jajarGenjang d = new jajarGenjang();

                        Console.WriteLine("Menghitung Luas Jajargenjang");
                        Console.WriteLine("----------------------------");
                        Console.Write("Sisi a   : ");
                        d.sisi = (int.Parse(Console.ReadLine()));
                        Console.Write("Sisi b : ");
                        d.sisib = (int.Parse(Console.ReadLine()));
                        Console.Write("Tinggi   : ");
                        d.tinggi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas : {0} cm", d.luas_jajarGenjang());
                        Console.WriteLine("Keliling : {0} cm", d.kel_jajarGenjang());

                        break;
                    }
                case 5:
                    {
                        Trapesium e = new Trapesium();

                        Console.WriteLine("Menghitung Luas Trapesium");
                        Console.WriteLine("-------------------------");
                        Console.Write("Sisi a   : ");
                        e.sisi = (int.Parse(Console.ReadLine()));
                        Console.Write("Sisi b : ");
                        e.sisib = (int.Parse(Console.ReadLine()));
                        Console.Write("Sisi c   : ");
                        e.sisic = (int.Parse(Console.ReadLine()));
                        Console.Write("Sisi d : ");
                        e.sisid = (int.Parse(Console.ReadLine()));
                        Console.Write("Tinggi : ");
                        e.tinggi = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas : {0} cm", e.luas_Trapesium());
                        Console.WriteLine("Keliling : {0} cm", e.kel_Trapesium());

                        break;
                    }
                case 6:
                    {
                        Layang f = new Layang();

                        Console.WriteLine("Menghitung Luas Layang Layang");
                        Console.WriteLine("-----------------------------");
                        Console.Write("Sisi a   : ");
                        f.sisi = (int.Parse(Console.ReadLine()));
                        Console.Write("Sisi b : ");
                        f.sisib = (int.Parse(Console.ReadLine()));
                        Console.Write("Sisi c   : ");
                        f.sisic = (int.Parse(Console.ReadLine()));
                        Console.Write("Sisi d : ");
                        f.sisid = (int.Parse(Console.ReadLine()));
                        Console.Write("Diagonal 1 : ");
                        f.diagonal1 = (int.Parse(Console.ReadLine()));
                        Console.Write("Diagonal 2 : ");
                        f.diagonal2 = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas : {0} cm", f.luas_Layang());
                        Console.WriteLine("Keliling : {0} cm", f.kel_Layang());

                        break;
                    }
                case 7:
                    {
                        belahKetupat g = new belahKetupat();

                        Console.WriteLine("Menghitung Luas Belah Ketupat");
                        Console.WriteLine("-----------------------------");
                        Console.Write("Sisi : ");
                        g.sisi = (int.Parse(Console.ReadLine()));
                        Console.Write("Diagonal 1 : ");
                        g.diagonal1 = (int.Parse(Console.ReadLine()));
                        Console.Write("Diagonal 2 : ");
                        g.diagonal2 = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Luas : {0} cm", g.luas_belah());
                        Console.WriteLine("Keliling : {0} cm", g.kel_belah());

                        break;
                    }
            }
        }
    }
}
