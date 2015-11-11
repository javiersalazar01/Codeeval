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
            string[] arr = line.Split(',');
            string palabra = arr[0];
            string filtro = arr[1].Trim();
            bool algo = true;
            string res = "";
            for (int i = 0; i < palabra.Length; i++)
            {
                algo = true;
                for (int j = 0; j < filtro.Length; j++)
                {
                    if (palabra[i] == filtro[j])
                    {
                        algo = false;
                    }
                }
                if (algo)
                {
                    res = res + palabra[i];
                }
            }

            Console.WriteLine(res);
        }
    }
}