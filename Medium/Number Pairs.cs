
using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if (null == line)
                continue;
            string[] sep = new string[] { ";" };
            string[] split = line.Split(sep, StringSplitOptions.None);
            int numSum = Convert.ToInt32(split[1]);
            string numeros = split[0];
            string[] arrNums = numeros.Split(new string[] { "," }, StringSplitOptions.None);
            string res = "";

            for (int i = 0; i < arrNums.Length; i++)
            {
                for (int j = i + 1; j < arrNums.Length; j++)
                {
                    int first = Convert.ToInt32(arrNums[i]);
                    int second = Convert.ToInt32(arrNums[j]);
                    if (first + second == numSum)
                    {
                        res = res + first + "," + second + ";";
                    }

                }
            }


            if (res.Length == 0)
            {
                Console.WriteLine("NULL");
            }
            else
            {

                Console.WriteLine(res.Remove(res.Length - 1, 1));
            }
        }
    }
}