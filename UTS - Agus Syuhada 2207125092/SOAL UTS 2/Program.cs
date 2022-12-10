/*
Nama    : Agus Syuhada
NIM     : 2207125092
Kelas   : Teknik Informatika - A
UNIVERSITAS RIAU
*/

using System;

namespace SoalUTS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Random rnd = new Random();
            int rNo = rnd.Next(1, 101);
            bool playGame = false;
            int guesses = 0;
            while (!playGame)
            {
                Console.Write("Tebak angka antara 1-100 :");
                int initial = Convert.ToInt32(Console.ReadLine());
                guesses += 1;
                if (initial == rNo)
                {
                    Console.WriteLine("Anda benar!");
                    Console.Write("Bye...");
                    Console.Read();
                    break;
                }
                else if (initial < rNo)
                {
                    Console.WriteLine("Salah. Nilai terlalu rendah");
                }
                else
                {
                    Console.WriteLine("Salah. Nilai terlalu tinggi");
                }
            }
        }
    }
}