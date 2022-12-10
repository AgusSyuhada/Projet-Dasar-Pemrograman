/*
NAMA    : AGUS SYUHADA
NIM     : 2207125092
KELAS   : TEKNIK INFORMATIKA - A
UNIVERSITAS RIAU 2022
*/

using System;

namespace BatlleTank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();

            int panjangRuang = 5;
            char tank = 't';
            char rumput = '~';
            char hit = 'X';
            char miss = 'O';
            int jumlahTank = 3;

            char[,] ruang = buatRuang(panjangRuang, rumput, tank, jumlahTank);

            printRuangan(ruang, rumput, tank);

            int jumlahTankTersembunyi = jumlahTank;
            while (jumlahTankTersembunyi > 0)
            {
                int[] tebakanPosisi = getPosisiTebakan(panjangRuang);
                char pebaruiRuang = verifikasiTebakan(tebakanPosisi, ruang, tank, rumput, hit, miss);
                
                if (pebaruiRuang == hit)
                {
                    jumlahTankTersembunyi--;
                }
                ruang = pebaruiRuangan(ruang, tebakanPosisi, pebaruiRuang);
                printRuangan(ruang, rumput, tank);
            }
            Console.WriteLine("Permainan berakhir, Sampai jumpa...\nTekan ESC untuk keluar...");
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            credit();
        }

        private static char[,] buatRuang(int panjangRuang, char rumput, char tank, int tankTotal)
        {
            char[,] ruangan = new char[panjangRuang, panjangRuang];
            
            for (int baris = 0; baris < panjangRuang; baris++)
            {
                for (int kolom = 0; kolom < panjangRuang; kolom++)
                {
                    ruangan[baris, kolom] = rumput;
                }
            }

            return letakkanTank(ruangan, tankTotal, rumput, tank);
        }

        private static char[,] letakkanTank(char[,] ruang, int jumlahTank, char rumput, char tank)
        {
            int letakTank = 0;
            int panjangRuang = 5;

            while (letakTank < jumlahTank)
            {
                int[] lokasiTank = tentukanKoordinatTank(panjangRuang);
                char posisiZ = ruang[lokasiTank[0], lokasiTank[1]];

                if (posisiZ == rumput)
                {
                    ruang[lokasiTank[0], lokasiTank[1]] = tank;
                    letakTank++;
                }
            }

            return ruang;
        }

        private static int[] tentukanKoordinatTank(int panjangRuang)
        {
            Random rng = new Random();
            int[] koordinat = new int[2];
            
            for (int i = 0; i < koordinat.Length; i++)
            {
                koordinat[i] = rng.Next(panjangRuang);
            }

            return koordinat;
        }

        private static void printRuangan(char[,] ruang, char rumput, char tank)
        {
            Console.Write("  ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + " ");
            }
            Console.WriteLine();

            for (int baris = 0; baris < 5; baris++)
            {
                Console.Write(baris + 1 + " ");
                for (int kolom = 0; kolom < 5; kolom++)
                {
                    char posisi = ruang[baris, kolom];
                    if (posisi == tank)
                    {
                        Console.Write(rumput + " ");
                    }
                    else
                    {
                        Console.Write(posisi + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        static int[] getPosisiTebakan(int panjangRuang)
        {
            int baris;
            int kolom;

            do
            {
                Console.Write("PILIH BARIS : ");
                baris = Convert.ToInt32(Console.ReadLine());
            }
            while (baris < 0 || baris > panjangRuang + 1);

            do
            {
                Console.Write("PILIH KOLOM : ");
                kolom = Convert.ToInt32(Console.ReadLine());
            }
            
            while (kolom < 0 || kolom > panjangRuang + 1);
            return new[] { baris - 1, kolom - 1 };
        }

        private static char verifikasiTebakan(int[] tebakKoordinat, char[,] ruang, char tank, char rumput, char hit, char miss)
        {
            string pesan;
            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            char target = ruang[baris, kolom];

            if (target == tank)
            {
                pesan = "Duar... Sasaran berhasil diledakkan!!";
                target = hit;
            }
            else if (target == rumput)
            {
                pesan = "Wush... Sasaran meleset!!";
                target = miss;
            }
            else
            {
                pesan = "Area ini sudah aman!!!";
            }
            Console.WriteLine(pesan);
            Console.WriteLine("   ");
            return target;
        }

        private static char[,] pebaruiRuangan(char[,] ruang, int[] tebakKoordinat, char pebaruiRuang)
        {
            int baris = tebakKoordinat[0];
            int kolom = tebakKoordinat[1];
            ruang[baris, kolom] = pebaruiRuang;
            return ruang;
        }

        static void credit()
        {
            Console.Clear();
            Console.WriteLine("========================================\n");
            Console.WriteLine("Terimakasih sudah bermain permainan ini");
            Console.WriteLine("Dibuat oleh.");
            Console.WriteLine("Nama     : Agus Syuhada");
            Console.WriteLine("NIM      : 2207125092");
            Console.WriteLine("Kelas    : Teknik Informatika - A");
            Console.WriteLine("\n========================================\n");
        }
    }
}