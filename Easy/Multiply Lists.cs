using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            //string line = "9 0 6 | 15 14 9";
            string[] entradas = line.Split(new char[]{'|',});
            string[] izq = entradas[0].Split(' '); 
            string[] der = entradas[1].Split(' ');
            for (int i = 0; i < izq.Length - 1; i++)
            {
                Console.Write(Convert.ToInt32(izq[i]) * Convert.ToInt32(der[i + 1]) + " ");
            }
            Console.WriteLine();
        }
    }
}