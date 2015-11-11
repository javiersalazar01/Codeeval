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
            char[] cadena;
            int cuadrado;
            int suma = 0;
            List<int> l = new List<int>();
            while (suma != 1)
            {
                cadena = line.ToCharArray();
                suma = 0;
                for (int i = 0; i < cadena.Length; i++)
                {
                    cuadrado = Convert.ToInt32(cadena[i].ToString());
                    cuadrado = cuadrado * cuadrado;
                    suma = suma + cuadrado;
                }
                if (!l.Contains(suma))
                {
                    l.Add(suma);
                }
                else 
                {
                    Console.WriteLine(0);
                    break;
                }
                line = Convert.ToString(suma);
                if (suma == 1)
                {
                    Console.WriteLine("1");
                }
            }
            // do something with line
        }
    }
}