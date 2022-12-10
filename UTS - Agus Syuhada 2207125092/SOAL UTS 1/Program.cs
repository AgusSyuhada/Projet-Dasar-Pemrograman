/*
Nama    : Agus Syuhada
NIM     : 2207125092
Kelas   : Teknik Informatika - A
UNIVERSITAS RIAU
*/

using System;

namespace SoalUTS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Nama :");
            string nama = Console.ReadLine();
            Console.WriteLine("Nim :");
            string nim = Console.ReadLine();
            Console.WriteLine("Konsentrasi :");
            string konsentrasi = Console.ReadLine();

            Console.WriteLine("|**********************|");
            Console.WriteLine("|Nama:{0,17}|", nama);
            Console.WriteLine("|{0,22}|", nim);
            Console.WriteLine("|----------------------|");
            Console.WriteLine("|{0,22}|", konsentrasi);
            Console.WriteLine("|**********************|");
            Console.ReadKey();
        }
    }
}