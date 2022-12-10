/*
Nama    : Agus Syuhada
NIM     : 2207125092
Kelas   : Teknik Informatika - A
UNIVERSITAS RIAU 2022
*/

using System;

namespace AduDadu
{
    class Program
    {
        static int DaduAnda;
        static int DaduKomputer;
        static int SkorAnda;
        static int SkorKomputer;
        static int SkorSeri;
        static int Ronde = 1;
        static bool GameStart;

        static void Main(string[] args)
        {
            Console.Clear();

            GameStart = true;
            while (GameStart)
            {
                if (Ronde <= 10)
                {
                    if (Ronde == 1)
                    {
                        Intro();
                    }
                    PlayGame();
                }
                else if (Ronde == 10)
                {
                    ShowEnd(false);
                    GameStart = (false);
                }
                else
                {
                    ShowEnd(true);
                    GameStart = (false);
                }
            }
            Console.WriteLine("\nTekan ESC untuk keluar");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
            Console.Clear();
            Credit();
        }

        static void Int()
        {
            Random Dadu = new Random();
            DaduKomputer = Dadu.Next(1, 7);
            DaduAnda = Dadu.Next(1, 7);
        }

        static void Intro()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("Pada  game  ini  anda  dan  komputer  akan  bermain  10  ronde");
            Console.WriteLine("Setiap  putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai  dadu  tertinggi akan  menjadi  pemenang  ronde tersebut");
            Console.WriteLine("Siapa  yang  akan  menang?  Selamat  Bermain!!");
            Console.WriteLine("==============================================================");
            Console.WriteLine("\nTekan ENTER untuk mulai bermain...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }

        static void PlayGame()
        {
            Int();
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"\n\n=========================[ Ronde {Ronde} ]==========================");
            Console.WriteLine("Komputer melempar dadu...");
            Console.Write("...");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b\b\b\b");
            Console.WriteLine($"- Nilai Komputer : {DaduKomputer}");
            Console.WriteLine("Silahkan lempar dadu anda...");
            Console.ReadKey();
            Console.Write("...");
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b\b\b\b");
            Console.WriteLine($"- Nilai Anda     : {DaduAnda}");

            if (DaduAnda > DaduKomputer)
            {
                SkorAnda++;
                Console.WriteLine("Anda memenangkan ronde ini");
                Console.WriteLine($"Skor - Anda : {SkorAnda}.          Komputer : {SkorKomputer}.          Seri : {SkorSeri}");
                if (Ronde < 10)
                {
                    Console.WriteLine("Tekan ENTER untuk melanjutkan ke ronde berikutnya...");
                }
                else if (Ronde == 10)
                {
                    Console.WriteLine("Tekan ENTER untuk melihat skor akhir...");
                }
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Ronde++;
            }
            else if (DaduAnda < DaduKomputer)
            {
                SkorKomputer++;
                Console.WriteLine("Komputer memenangkan ronde ini");
                Console.WriteLine($"Skor - Anda : {SkorAnda}.          Komputer : {SkorKomputer}.          Seri : {SkorSeri}");
                if (Ronde < 10)
                {
                    Console.WriteLine("Tekan ENTER untuk melanjutkan ke ronde berikutnya...");
                }
                else if (Ronde == 10)
                {
                    Console.WriteLine("Tekan ENTER untuk melihat skor akhir...");
                }
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Ronde++;
            }
            else
            {
                SkorSeri++;
                Console.WriteLine("Ronde ini seri!");
                Console.WriteLine($"Skor - Anda : {SkorAnda}.          Komputer : {SkorKomputer}.          Seri : {SkorSeri}");
                if (Ronde < 10)
                {
                    Console.WriteLine("Tekan ENTER untuk melanjutkan ke ronde berikutnya...");
                }
                else if (Ronde == 10)
                {
                    Console.WriteLine("Tekan ENTER untuk melihat skor akhir...");
                }
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Ronde++;
            }
        }

        static void ShowEnd(bool b)
        {
            if (SkorAnda > SkorKomputer)
            {
                Console.WriteLine("\nPermainan selesai");
                Console.WriteLine($"Skor Akhir- Anda : {SkorAnda}.     Komputer : {SkorKomputer}.          Seri : {SkorSeri}");
                Console.WriteLine("Selamat!! Anda menang!!");
            }
            else if (SkorAnda < SkorKomputer)
            {
                Console.WriteLine("\nPermainan selesai");
                Console.WriteLine($"Skor Akhir - Anda : {SkorAnda}.    Komputer : {SkorKomputer}.          Seri : {SkorSeri}");
                Console.WriteLine("Sayang sekali!! Anda kalah!!");
            }
            else
            {
                Console.WriteLine("\nPermainan selesai");
                Console.WriteLine($"Skor Akhir - Anda : {SkorAnda}.    Komputer : {SkorKomputer}.          Seri : {SkorSeri}");
                Console.WriteLine("Permainan ini seri!!");
            }
        }

        static void Credit()
        {
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