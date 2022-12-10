//Program
using System;

//Wadah untuk kelas
namespace DasarPemograman2
{
    //Wadah Data dan Method
    class program
    {
        //Main Method
        static void Main(string[] args)
        {
            //Clear Console
            Console.Clear();

            //Deklarasi Variabel
            int KodeA;
            int KodeB;
            int KodeC;
            int KodeD;
            int JumlahKode;
            String TebakanPertama;
            String TebakanKedua;
            String TebakanKetiga;
            String TebakanKeempat;

            int HasilPenjumlahan;
            int HasilPengurangan;
            int HasilPerkalian;
            int HasilPembagian;

            //Inisialisasi Variabel
            KodeA = 2;
            KodeB = 4;
            KodeC = 6;
            KodeD = 8;
            JumlahKode = 4;

            //Operasi Aritmatika
            HasilPenjumlahan = KodeA + KodeB + KodeC + KodeD;
            HasilPengurangan = KodeA - KodeB - KodeC - KodeD;
            HasilPerkalian = KodeA * KodeB * KodeC * KodeD;
            HasilPembagian = KodeA / KodeB / KodeC / KodeD;

            //Intro    
            Console.WriteLine("Anda adalah seorang agen rahasia mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");
            Console.WriteLine("Password terdiri dari " + JumlahKode + " angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + HasilPenjumlahan);
            Console.WriteLine("- Jika dikurangkan hasilnya " + HasilPengurangan);
            Console.WriteLine("- Jika dikalikan maka hasilnya " + HasilPerkalian);
            Console.WriteLine("- Jika dibagikan hasilnya " + HasilPembagian);

            //Input User
            Console.Write("\nMasukkan Kode 1 : ");
            TebakanPertama = Console.ReadLine();
            Console.Write("Masukkan Kode 2 : ");
            TebakanKedua = Console.ReadLine();
            Console.Write("Masukkan Kode 3 : ");
            TebakanKetiga = Console.ReadLine();
            Console.Write("Masukkan Kode 4 : ");
            TebakanKeempat = Console.ReadLine();

            Console.WriteLine("Tebakan Anda : " + TebakanPertama + " " + TebakanKedua + " " + TebakanKetiga + " " + TebakanKeempat);

            //If Statement
            if (TebakanPertama == KodeA.ToString() && TebakanKedua == KodeB.ToString() && TebakanKetiga == KodeC.ToString() && TebakanKeempat == KodeD.ToString())
            {
                Console.WriteLine("Tebakan Anda Benar!");
            }
            else
            {
                Console.WriteLine("Tebakan Anda Salah!");
            }
        }
    }
}