using System.Collections.Generic;
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string caso = reader.ReadLine();
            
            
            string [] arr = caso.Split(',');
            string final = "";
            List<int> nums = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int dato = Convert.ToInt32(arr[i]);
                if (!nums.Contains(dato))
                {
                    nums.Add(dato);
                }
               
            }

            int[] chilo = nums.ToArray();

            for (int i = 0; i < chilo.Length; i++)
            {
                if (i == chilo.Length - 1)
                {
                    final = final + chilo[i];
                }
                else 
                {
                    final = final + chilo[i] + ",";
                }
            }
            Console.WriteLine(final);
        }
    }
}