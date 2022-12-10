/*
Nama    : Agus Syuhada
NIM     : 2207125092
Kelas   : Teknik Informatika - A
UNIVERSITAS RIAU
*/

using System;

namespace SoalUTS4
{
    class Program
    {
        static Random pilihan = new Random();
        static int skorMenang;
        static int skorKalah;
        static int skorSeri;
        static bool playGame;

        static void Main(string[] args)
        {

            playGame = true;
            while (playGame)
            {
                Console.Clear();
                Console.WriteLine("Batu, Gunting, Kertas");
                Console.Write("\nChoose [b]atu, [g]unting, [k]ertas, or [e]xit:");

                string pilihanAnda = Console.ReadLine();
                if (pilihanAnda == "e")
                {
                    break;
                }

                int pilihanKomputer = pilihan.Next(0, 3);
                if (pilihanKomputer == 0)
                {
                    Console.WriteLine("Komputer memilih batu.");

                    switch (pilihanAnda)
                    {
                        case "b":
                            Console.WriteLine("Seri.");
                            skorSeri++;
                            break;
                        case "g":
                            Console.WriteLine("Anda kalah.");
                            skorKalah++;
                            break;
                        case "k":
                            Console.WriteLine("Anda menang.");
                            skorMenang++;
                            break;
                    }
                }
                else if (pilihanKomputer == 1)
                {
                    Console.WriteLine("Komputer memilih gunting.");

                    switch (pilihanAnda)
                    {
                        case "b":
                            Console.WriteLine("Anda menang.");
                            skorMenang++;
                            break;
                        case "g":
                            Console.WriteLine("Seri.");
                            skorSeri++;
                            break;
                        case "k":
                            Console.WriteLine("Anda kalah.");
                            skorKalah++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Komputer memilih kertas.");

                    switch (pilihanAnda)
                    {
                        case "b":
                            Console.WriteLine("Anda kalah.");
                            skorKalah++;
                            break;
                        case "g":
                            Console.WriteLine("Anda menang.");
                            skorMenang++;
                            break;
                        case "k":
                            Console.WriteLine("Seri.");
                            skorSeri++;
                            break;
                    }
                }
                Console.WriteLine($"Skor: {skorMenang} menang, {skorKalah} kalah, {skorSeri} seri");
                Console.WriteLine("Tekan Enter untuk melanjutkan permainan...");
                while (Console.ReadKey().Key != ConsoleKey.Enter)
                {
                    Console.Clear();
                    playGame = true;
                }
            }
        }
    }
}