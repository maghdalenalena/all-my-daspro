/*Maghdalena-2207112588
Teknik Informatika-B
Program Game Dadu
*/
using System;

namespace dadu
{
    class Program
    {
        static void Intr()
        {
            Console.WriteLine("Pada game ini anda dan komputer akan bermain 10 ronde");
            Console.WriteLine("Setiap putaran dadu akan dilempar menghasilkan nilai tertentu");
            Console.WriteLine("Nilai dadu tertinggi akan menjadi pemenang ronde tersebut");
            Console.WriteLine("Siapa yang akan menang? Selamat berjuang");
            Console.WriteLine("Mulai main...");
        }

        static void Main(string[] args)
        {
            int pemainRandomNum;
            int computerRandomNum;

            int pemainPoints = 0;
            int computerPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ronde "+(i+1));
                   
                Console.WriteLine("tekan tombol spasi");

                Console.ReadKey();

                pemainRandomNum = random.Next(1,7);
                Console.WriteLine("kamu mendapatkan angka"+pemainRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                computerRandomNum = random.Next(1,7);
                Console.WriteLine("computer mendapatkan angka "+computerRandomNum);

                if(pemainRandomNum > computerRandomNum)
                {
                    pemainPoints++;
                    Console.WriteLine("kamu memenangkan permainan!");
                }else if(pemainRandomNum < computerRandomNum)
                {
                    computerPoints++;
                    Console.WriteLine("computer memenangkan permainan"!);
                }else{
                    Console.WriteLine("permainan seri!");
                }
                Console.WriteLine("skor kamu : " +pemainPoints+ ".computer : " +computerPoints+ ".");
                Console.WriteLine();
            }

            if(pemainPoints > computerPoints){
                Console.WriteLine("Congrats You Win!");
            }else if(pemainPoints < computerPoints){
                Console.WriteLine("You Lose!");
            }else{
                Console.WriteLine("Draw!");
            }

            Console.ReadKey();
        }
    }
}
