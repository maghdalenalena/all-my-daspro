﻿/*
MAGHDALENA-2207118825
TEKNIK INFORMATIKA-B
Enskripsi
*/

using System;
using System.Text.RegularExpressions;

namespace soal_no_4
{
    class Program
    {
        public static void Main(string[] args){
            String teks, enkripsi = "";
            String alfabet = "abcdefghijklmnopqrstuvwxyzabcABCDEFGHIJKLMNOPQRSTUVWXYZABC";
            Regex rgx = new Regex("[^A-Za-z ]"); 
            do{
                Console.Write("Teks : ");
                teks = Console.ReadLine();
            } while (String.IsNullOrEmpty(teks) || rgx.IsMatch(teks));

             foreach (Char t in teks){
                Char temp = ' ';
                for (int i = 0; i < alfabet.Length; i++){
                    Char c = alfabet[i];
                    if (t.Equals(c)){ 
                        temp = alfabet[i+3];
                        break;
                    } else if (t.Equals(' ')){
                        temp = ' ';
                        break;
                    }
                }
                enkripsi = enkripsi + temp; 
            }
            Console.WriteLine("Enkripsi : " + enkripsi); 
        }
    }
}