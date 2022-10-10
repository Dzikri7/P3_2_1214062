using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mtk = false;

            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("            MENU            ");
                Console.WriteLine(" 1. Menghitung Luas Persegi Panjang ");
                Console.WriteLine(" 2. Menghitung Keliling Persegi Panjang ");
                Console.WriteLine(" ");

                int opsi;
                Console.Write(" Opsi Pilihan : ");

                double panjang, lebar, hasil;
                hasil = 0;

                opsi = int.Parse(Console.ReadLine());

                if (opsi < 1 || opsi > 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("  ---Opsi Tidak Tersedia---  ");
                }

                switch (opsi)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("  ---MENGHITUNG LUAS PERSEGI PANJANG---  ");
                        Console.WriteLine("");
                        Console.Write(" Masukkan Panjang (cm) : ");
                        panjang = double.Parse(Console.ReadLine());
                        Console.Write(" Masukkan Lebar (cm)   : ");
                        lebar = double.Parse(Console.ReadLine());
                        hasil = panjang * lebar;
                        Console.WriteLine(" Luas Persegi Panjang Adalah =  {0} cm", hasil);
                        break;

                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("  ---MENGHITUNG KELILING PERSEGI PANJANG---  ");
                        Console.WriteLine("");
                        Console.Write(" Masukkan Panjang (cm) : ");
                        panjang = double.Parse(Console.ReadLine());
                        Console.Write(" Masukkan Lebar (cm)   : ");
                        lebar = double.Parse(Console.ReadLine());
                        hasil = (2 * panjang) + (2 * lebar);
                        Console.WriteLine(" Keliling Persegi Panjang Adalah =  {0} cm", hasil);
                        break;
                }

                Console.WriteLine("");
                Console.Write(" Ingin Mengulang Kembali? (Y/T) : ");
                var y = char.Parse(Console.ReadLine());

                if (y == 'Y' || y == 'y')
                {
                    mtk = false;
                }
                else
                {
                    mtk = true;
                }
                Console.Clear();
            } while (!mtk);
        }
    }
}
