﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            int kesalahan = 0;
            String jawaban = "";
            bool salah = false, menang = false, kalah = false, benar = false;
            Console.Clear(); 
            string[] soal = new string[10];
            soal[0] = "sheep";
            soal[1] = "goat";
            soal[2] = "computer";
            soal[3] = "america";
            soal[4] = "watermelon";
            soal[5] = "icecream";
            soal[6] = "jasmine";
            soal[7] = "pineapple";
            soal[8] = "orange";
            soal[9] = "mango";
            Random randGen = new Random(); 
            var random = randGen.Next(0, 9);
            string soalGame = soal[random]; 
            char[] guess = new char[soalGame.Length]; 
            for (int p = 0; p < soalGame.Length; p++) {
                guess[p] = '_';
            }
 
            while (menang == false && kalah == false)
            {
                Console.Write("Huruf tebakan : ");
                char playerGuess = char.Parse(Console.ReadLine()); 
                for (int j = 0; j < soalGame.Length; j++) 
                {
                    if (playerGuess == soalGame[j]) { 
                        benar = true; 
                        guess[j] = playerGuess;
                    } else if (j == soalGame.Length - 1 && benar == false){ 
                        salah = true; 
                    }
                }
                Console.Clear();
                jawaban = new String(guess); 
                if (salah == true) { 
                    Console.WriteLine("Tebakan anda salah!");
                    kesalahan++; 
                    salah = false; 
                }
                benar = false; 
                Console.WriteLine(guess);
                Console.WriteLine();
                switch (kesalahan) // ini mirip dengan if else dan sebenarnya bisa menggunakan if else kalau mau, bedanya switch ini langsung ngecek isi dari variabel yang dimasukkan, contohnya di sini kesalahan
                {
                    case 1: // kalau kesalahannya satu, maka ini yang dijalankan
                        Console.WriteLine("|__");
                        break;
                    case 2: // kalau kesalahannya dua, ini yang dijalankan
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 3: // dan seterusnya
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 4:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 5:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 6:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 7:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 8:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |");
                        Console.WriteLine("|__");
                        break;
                    case 9:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("|__");
                        break;
                    case 10:
                        Console.WriteLine("____");
                        Console.WriteLine(" |/      |");
                        Console.WriteLine(" |      (_)");
                        Console.WriteLine(" |      \\|/");
                        Console.WriteLine(" |       |");
                        Console.WriteLine(" |      / \\");
                        Console.WriteLine("|__");
                        break;

                    default:
                        break;
                }

                if (jawaban == soalGame) { 
                    Console.WriteLine("Selamat, anda menang!"); 
                    menang = true;
                } else if (kesalahan == 10 && jawaban != soalGame) { 
                    Console.WriteLine("Anda kurang beruntung!"); 
                    kalah = true;
                }
            }
        }
    }
}
