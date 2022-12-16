
/*
Create by Maghdalena - 2207112588
*/
using System;

namespace daspro
{
    class Program
    {

        /* kenapa deklarasi diluar function main karna supaya bisa digunakan di 
        function lain dan kenapa ditambah  kan static supaya bisa di akses dari dalam function.
        */

        // menambahkan class random 
        static Random random = new Random();

        // deklarasi variabel
        static int kodeA;
        static int kodeB;
        static int kodeC;
        static int hasilTambah;
        static int hasilKurang;
        static int hasilKali;
        static int kesempatan = 3;
        static int level = 1;

        static string tebakanA;
        static string tebakanB;
        static string tebakanC;
        static bool bGameOver = true;

        // kenapa ditambahkan cancel supaya menghentikan while
        static bool cancel = false;

        static int jumlahKode = 3;

        //Main Method
        static void Main(string[] args){
            intro();

            while(bGameOver){
                PlayGame();

                // menghentikan while
                if(cancel == true){
                    break;
                }
            }
        }

        static void intro(){
            // intro
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server...");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui..");
        }

        static void PlayGame(){

            // menrandom
            // cara kerja random 1 itu adalah nilai awal, dan nilai itu kedua itu adalah nilai akhir
            kodeA = random.Next(1, level);
            kodeB = random.Next(1, level);
            kodeC = random.Next(1, level);

            // operasi aritmatika
            int hasilTambah = kodeA+kodeB+kodeC;
            int hasilKurang = kodeA-kodeB-kodeC;
            int hasilKali = kodeA*kodeB*kodeC;

            Console.WriteLine("- level " + level);
            Console.WriteLine("- Password terdiri dari " + jumlahKode + " angka");
            Console.WriteLine("- Jika ditambahkan hasilnya " + hasilTambah);
            Console.WriteLine("- Jika dikurangkan hasilnya " + hasilKurang);
            Console.WriteLine("- Jika dikalikan hasilnya " + hasilKali);

            //input user
            Console.WriteLine("Masukkan Kode Pertama : ");
            tebakanA = Console.ReadLine();
            Console.WriteLine("Masukkan Kode Kedua : ");
            tebakanB = Console.ReadLine();
            Console.WriteLine("Masukkan Kode Ketiga : ");
            tebakanC = Console.ReadLine();
            Console.WriteLine("Tebakan anda " + tebakanA + " " + tebakanB + " " + tebakanC + "?");

            if(tebakanA == kodeA.ToString() && tebakanB == kodeB.ToString() && tebakanC == kodeC.ToString()){
                Console.WriteLine("Anda benar!");

                // tambah level
                level = level + 1;

                if(level > 5){
                    Console.WriteLine("Congrats you win");
                    cancel = true;
                }

            }else{
                Console.WriteLine("Anda salah!");

                // kurang kesempatan
                kesempatan = kesempatan - 1;

                if(kesempatan < 1){
                    cancel = true;
                }

                // jika ingin menghentikan while
                // cancel = true;
            }
        }
    }
}