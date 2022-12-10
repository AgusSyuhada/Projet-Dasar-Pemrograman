/*
Nama    : Agus syuhada
NIM     : 2207125092
Kelas   : Teknik Informatika - A
UNIVERSITAS RIAU
*/

using System;

namespace SoalUTS3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lamaPeminjaman;
            int lamaPeminjaman1;
            int lamaPeminjaman2;
            int lamaPeminjaman3;
            int totalDenda;
            int totalDenda1;
            int totalDenda2;

            Console.Clear();
            Console.Write("Input jumlah hari peminjaman : ");
            lamaPeminjaman = Convert.ToInt32(Console.ReadLine());

            lamaPeminjaman1 = lamaPeminjaman - 5;
            totalDenda = 10000;

            lamaPeminjaman2 = lamaPeminjaman - 10;
            totalDenda1 = 20000;
            int Denda1 = 50000;
            int denda2 = totalDenda1 * lamaPeminjaman2;
            denda2 = denda2 + Denda1;

            lamaPeminjaman3 = lamaPeminjaman - 30;
            totalDenda2 = 30000;
            int Denda2 = 400000;
            int denda3 = totalDenda2 * lamaPeminjaman3;
            denda3 = denda3 + Denda1 + Denda2;

            if (lamaPeminjaman > 5 && lamaPeminjaman <= 10)
            {
                Console.Write("Total denda : Rp." + totalDenda *lamaPeminjaman1);
            }
            else if (lamaPeminjaman <= 5)
            {
                Console.Write("Totaldenda : Rp.0");
            }
            else if (lamaPeminjaman > 10 && lamaPeminjaman <= 30)
            {
                Console.Write("Total denda : Rp." + denda2);
            }
            else
            {
                Console.WriteLine("Keanggotaan anda dibatalkan");
                Console.Write("Total denda : Rp." + denda3);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}