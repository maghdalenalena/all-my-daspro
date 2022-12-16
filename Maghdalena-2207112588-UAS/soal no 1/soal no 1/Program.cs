/* 
MAGHDALENA-2207112588
TEKNIK INFORMATIKA-B
NameTag
*/

using System;

namespace soal_no_1
{
    class Program
    {
       public static void Main(string[] args){
        String nama, nim, konsentrasi; 
            Console.WriteLine("Nama :"); 
            nama = Console.ReadLine();
            Console.WriteLine("NIM :");
            nim = Console.ReadLine(); 
            Console.WriteLine("Konsentrasi :");
            konsentrasi = Console.ReadLine();

            Console.WriteLine("|*******************************|");
            Console.WriteLine("{0,-8} {1,24}", "|Nama: ", nama+"|");
            Console.WriteLine("{0,-16} {1,16}","|", nim+"|");
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("{0,-16} {1,16}","|", konsentrasi+"|");
            Console.WriteLine("|*******************************|");
        }
    }
}
