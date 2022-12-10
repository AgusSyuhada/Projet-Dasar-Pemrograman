/*
Nama    : Agus Syuhada
NIM     : 2207125092
Kelas   : Teknik Informatika - A
UNIVERSITAS RIAU 2022
*/

using System;

namespace GameAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Selamat Datang di Game Adventure");
            Console.WriteLine("Silahkan Masukkan Username Kamu...");
            Novice player = new Novice();
            player.Name = Console.ReadLine().ToUpper();
            Console.WriteLine($"Hi {player.Name}, Siap untuk memulai permainan? [Y/N]");
            var input = Console.ReadKey();
            while(true)
            {
                Console.SetCursorPosition(0,Console.CursorTop);
                if(input.Key == ConsoleKey.N || input.Key == ConsoleKey.Y)
                {
                    break;
                }

                input = Console.ReadKey();
            }
            if (input.Key == ConsoleKey.N)
            {
                Console.WriteLine("Selamat Tinggal....");
                Console.ReadKey();
                Credit();
                Console.ReadKey();
            }
            else
            {
                bool play = true;
                while(play)
                {
                    Console.Clear();
                    Console.WriteLine($"{player.Name} memasuki dunia petualangan.....");
                    Enemy enemy = new Enemy("Goblin");
                    Console.WriteLine($"{player.Name} sedang menghadapai {enemy.Name}");
                    Console.WriteLine($"{enemy.Name} menyerang kamu....");
                    Console.WriteLine("Pilih tindakan anda");
                    Console.WriteLine("1. Serangan Tunggal");
                    Console.WriteLine("2. Serangan Ayunan");
                    Console.WriteLine("3. Memulihkan Energi");
                    Console.WriteLine("4. Melarikan Diri");

                    while (!player.IsDead && !enemy.IsDead && !player.IsRunningAway)
                    {
                        string playerAction = Console.ReadLine();
                        switch (playerAction)
                        {
                            case "1":
                                Console.WriteLine($"{player.Name} melakukan Serangan Tunggal");
                                enemy.GetHit(player.AttackPower);
                                player.Experience += 0.3f;
                                enemy.Attack(enemy.AttackPower);
                                player.GetHit(enemy.AttackPower);
                                Console.WriteLine("========================================");
                                Console.WriteLine($"Darah Pemain : {player.Health} | Darah Musuh : {enemy.Health}");
                                Console.WriteLine("========================================\n");
                                break;
                            case "2":
                                player.Swing();
                                player.Experience += 0.9f;
                                if (player.AttackPower > 0)
                                {
                                    enemy.GetHit(player.AttackPower);
                                }
                                if (player.SkillSlot == 0)
                                {
                                    enemy.Attack(enemy.AttackPower);
                                    player.GetHit(enemy.AttackPower);
                                }
                                Console.WriteLine("========================================");
                                Console.WriteLine($"Darah Pemain : {player.Health} | Darah Musuh : {enemy.Health}");
                                Console.WriteLine("========================================\n");
                                break;
                            case "3":
                                player.Recharge();
                                Console.WriteLine("Memulihkan Energi....");
                                enemy.Attack(enemy.AttackPower);
                                player.GetHit(enemy.AttackPower);
                                Console.WriteLine("========================================");
                                Console.WriteLine($"Darah Pemain : {player.Health} | Darah Musuh : {enemy.Health}");
                                Console.WriteLine("========================================\n");
                                break;
                            case "4":
                                Console.WriteLine($"{player.Name} melarikan diri....");
                                player.RunningAway();  
                                break;
                        }
                    }
                    if(enemy.IsDead)
                    {
                        Console.WriteLine($"{player.Name} mendapatkan {player.Experience} EXP point.");
                    }
                    
                    Console.WriteLine();
                    Console.WriteLine($"Apakah kamu masih ingin bermain? [Y/N]");
                    var input1 = Console.ReadKey();
                    while(play)
                    {
                        Console.SetCursorPosition(0,Console.CursorTop);
                        if (input1.Key == ConsoleKey.Y || input1.Key == ConsoleKey.N)
                        {
                            if (player.IsRunningAway || player.IsDead)
                            {
                                player.IsRunningAway = false;
                                player.IsDead = false;
                                player.Experience += 0;
                            }
                            player.Health = 100;
                            break;
                        }

                        input1 = Console.ReadKey(); 
                    }
                    if (input1.Key == ConsoleKey.N)
                    {
                        play = false;
                        Credit();
                        Console.ReadKey();
                    }
                }
            }
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

    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Experience { get; set; }
        public bool IsRunningAway { get; set; }
        Random rnd = new Random();
        
        public Novice()
        {
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            Experience = 0f;
            Name = "Pemula";
        }
        public void Swing()
        {
            if (SkillSlot > 0)
            {
                Console.WriteLine("WUSHHHH!!!");
                AttackPower = AttackPower + rnd.Next(3, 11);
                SkillSlot--;
            }
            else
            {
                Console.WriteLine("Kamu tidak memiliki energi!");
                AttackPower =  0;
            }
        }
        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name} mendapatkan serangan sebesar {hitValue}");
            Health = Health - hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }
        public void Recharge()
        {
            SkillSlot = 3;
            AttackPower = 1;
        }
        public void Die()
        {
            Console.WriteLine("Kamu Mati. Permainan Berakhir");
            IsDead = true;
        }
        public void RunningAway()
        {
            IsRunningAway =  true;
        }
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Health = 50;
            Name = name;
        }
        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1, 10);
        }
        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name} mendapatkan serangan sebesar {hitValue}");
            Health = Health - hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }
        }
        public void Die()
        {
            Console.WriteLine($"{Name} telah mati");
            IsDead = true;
        }
    }
}