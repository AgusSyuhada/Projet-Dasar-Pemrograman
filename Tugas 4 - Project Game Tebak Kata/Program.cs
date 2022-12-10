/*
Nama    : Agus Syuhada
NIM     : 2207125092
Kelas   : Teknik Informatika - A
UNIVERSITAS RIAU 2022
*/

using System;
using System.Collections.Generic;

namespace TebakKata
{
    class Program
    {
        static int Kesempatan = 5;
        static String KataMisteri = "DARWIN";
        static List<string> ListTebakan = new List<string> { };
        static bool GameStart;

        static void Main(string[] args)
        {
            Console.Clear();
            Intro();
            Console.WriteLine("\nTekan ENTER untuk mulai bermain...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            PlayGame();
            AskPlay();
            ShowEnd();
            Credit();
        }

        static void Intro()
        {

            if (Kesempatan <= 5)
            {
                Console.Clear();
                Console.WriteLine("===================================================================================");
                Console.WriteLine("Selamat datang di permainan Tebak Kata!!");
                Console.WriteLine($"Kamu punya {Kesempatan} kesempatan untuk menebak kata misteri kali ini");
                Console.WriteLine("Petunjuknya kata ini merupakan nama salah seorang tokoh yang mencetus Teori Evolusi");
                Console.WriteLine($"Kata tersebut terdiri dari {KataMisteri.Length} huruf");
                Console.WriteLine("Kata apakah yang dimaksud??");
                Console.WriteLine("===================================================================================");
            }
        }

        static void PlayGame()
        {
            while (Kesempatan > 0)
            {
                Intro();
                Console.WriteLine("");
                Console.WriteLine(CekHuruf(KataMisteri, ListTebakan));
                Console.Write("Silahkan masukkan huruf tebakanmu!! (A - Z) : ");
                string Input = Console.ReadLine().ToUpper();
                ListTebakan.Add(Input);
                if (CekJawaban(KataMisteri, ListTebakan))
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b\b\b\b");
                    Console.WriteLine("Selamat anda benar!!");
                    Console.WriteLine($"Kata misteri kali ini adalah {KataMisteri}");
                    break;
                }
                else if (KataMisteri.Contains(Input))
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b\b\b\b");
                    Console.WriteLine($"Benar! Huruf {Input} ada dalam kata ini");
                    Console.WriteLine("Tekan ENTER untuk menebak huruf selanjutnya...");
                    Console.WriteLine(CekHuruf(KataMisteri, ListTebakan));
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                }
                else
                {
                    Console.Write("...");
                    System.Threading.Thread.Sleep(500);
                    Console.Write("\b\b\b\b");
                    Console.WriteLine($"Salah! Huruf {Input} tidak ada dalam kata ini");
                    Kesempatan--;
                    if (Kesempatan > 1)
                    {
                        Console.WriteLine($"Kesempatan anda menjawab tersisa {Kesempatan} kesempatan");
                        Console.WriteLine("Tekan ENTER untuk menebak huruf selanjutnya...");
                    }
                    else if (Kesempatan == 1)
                    {
                        Console.WriteLine("Kesempatan anda telah habis");
                        Console.WriteLine("Tekan ENTER untuk melanjutkan...");
                        break;
                    }
                    while (Console.ReadKey().Key != ConsoleKey.Enter) ;
                }
            }
        }

        static bool CekJawaban(string KataRahasia, List<string> list)
        {
            bool status = false;
            for (int i = 0; i < KataRahasia.Length; i++)
            {
                string c = Convert.ToString(KataRahasia[i]);
                if (list.Contains(c))
                {
                    status = true;
                }
                else
                {
                    return status = false;
                }
            }
            return status;
        }

        static string CekHuruf(string KataRahasia, List<string> list)
        {
            string x = "";

            for (int i = 0; i < KataRahasia.Length; i++)
            {
                string c = Convert.ToString(KataRahasia[i]);
                if (list.Contains(c))
                {
                    x = x + c;
                }
                else
                {
                    x = x + "_";
                }
            }
            return x;
        }

        static void AskPlay()
        {
            Console.Write("\nApakah anda ingin bermain kembali (Y/N)");
            var Input = Console.ReadKey();
            switch (Input.Key)
            {
                case ConsoleKey.Y:
                    Kesempatan = 5;
                    ListTebakan.Clear();

                    Intro();
                    PlayGame();
                    AskPlay();
                    break;

                case ConsoleKey.N:
                    break;
            }
        }

        static void ShowEnd()
        {
            Console.Clear();
            Intro();
            Console.WriteLine("\nPermainan telah berakhir");
            Console.WriteLine($"Kata misteri yang dimaksud adalah {KataMisteri}");
            Console.WriteLine("Tekan ESC untuk keluar...");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
        }

        static void Credit()
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