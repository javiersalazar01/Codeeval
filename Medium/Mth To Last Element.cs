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
            string[] nums = line.Split(' ');
            int valor = Convert.ToInt32(nums[nums.Length - 1]);
            if (valor <= nums.Length - 1)
            {
                Console.WriteLine(nums[nums.Length - 1 - valor]);
            }
        }
    }
}