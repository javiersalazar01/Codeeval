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
            char[] letrass = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v','w','x','y' ,'z'}; 
            
            char[] arr = line.ToLower().ToCharArray();
            //Console.WriteLine(String.Join(",",arr));
            List<char> l = new List<char>();
            List<char> letras = new List<char>();
            List<char> l3 = new List<char>();
            letras.AddRange(letrass);
            for (int i = 0; i < arr.Length; i++)
            {
                if (!l.Contains(arr[i]))
                {
                    l.Add(arr[i]);
                    
                }
            }
            string res = "";
            for (int i = 0; i < letrass.Length; i++)
            {
                if (!l.Contains(letrass[i]))
                {
                    res = res + Convert.ToString(letrass[i]);
                }
            }

            if (res.Length == 0)
            {
                Console.WriteLine("NULL");
            }
            else 
            {
                Console.WriteLine(res);
            }
        }
    }
}