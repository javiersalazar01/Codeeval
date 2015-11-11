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
            //string line = "12,ab";
            string[] arr = line.Split(',');
            double n = Convert.ToDouble(arr[0]);
            char[] cadena = arr[1].ToCharArray();
            List<char> l = new List<char>();
            foreach (char i in cadena)
            {
                if (!l.Contains(i))
                {
                    l.Add(i);
                }
            }
            char[] orden = l.ToArray();
            Array.Sort(orden);

            double iter = Math.Pow(orden.Length,n);

            int [] reloj = new int[Convert.ToInt32(n)]; 
            for (int i = 0; i < reloj.Length; i++)
			{
			    reloj[i] = 0;
			}


            for (int i = 0; i < iter; i++)
            {
                for (int k = reloj.Length-1; k >= 0; k--)
                {
                    Console.Write(orden[reloj[k]]);
                }
                reloj[0]++;
                if (i < iter - 1)
                {
                   Console.Write(","); 
                }
                

                for (int j = 1; j < reloj.Length; j++)
                {
                    if (reloj[j-1] == orden.Length)
                    {
                        reloj[j - 1] = 0;
                        reloj[j] = reloj[j] + 1;
                    }
                    
                }
                
            }
            Console.WriteLine();
        }
    }
}