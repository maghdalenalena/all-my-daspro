/* 
MAGHDALENA-2207112588
TEKNIK INFORMATIKA-B
Konventer Mata Uang
*/

using System;

namespace soal_no_2
{
    class Program
    {
        public static void Main(string[] args){
            float rate, usd;
            Console.WriteLine("Rate USD ke RP: ");
            rate = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Jumlah USD : ");
            usd = float.Parse(Console.ReadLine());
            Console.WriteLine("Hasil Konversi : " + rate*usd);
        }
    }
}
