using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
             //string line = "negaive zero";
            string [] arr = line.Split(' ');
            Hashtable h = new Hashtable();
            Stack<int> sta = new Stack<int>();
            Stack<int> res = new Stack<int>();
            h.Add("zero",0);
            h.Add("one", 1);
            h.Add("two", 2);
            h.Add("three", 3);
            h.Add("four", 4);
            h.Add("five", 5);
            h.Add("six", 6);
            h.Add("seven", 7);
            h.Add("eight", 8);
            h.Add("nine", 9);
            h.Add("ten", 10);
            h.Add("eleven", 11);
            h.Add("twelve", 12);
            h.Add("thirteen", 13);
            h.Add("fourteen", 14);
            h.Add("fifteen", 15);
            h.Add("sixteen", 16);
            h.Add("seventeen", 17);
            h.Add("eighteen", 18);
            h.Add("nineteen", 19);
            h.Add("twenty", 20);
            h.Add("thirty", 30);
            h.Add("forty", 40);
            h.Add("fifty", 50);
            h.Add("sixty", 60);
            h.Add("seventy", 70);
            h.Add("eighty", 80);
            h.Add("ninety", 90);
            h.Add("hundred", 100);
            h.Add("thousand", 1000);
            h.Add("million", 1000000);
            int sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "negative")
                {
                    
                }
                else if (arr[i] == "thousand" || arr[i] == "million")
                {
                    sum = 0;
                    count = sta.Count;
                    for (int j = 0; j < count; j++)
                    {
                        sum = sum + sta.Pop();
                    }

                    res.Push(sum * Convert.ToInt32(h[arr[i]]));
                    sta.Clear();
                }
                else if (arr[i] == "hundred")
                {
                    sum = 0;
                    count = sta.Count;
                    for (int j = 0; j < count; j++)
                    {
                        sum = sum + sta.Pop();
                    }
                    sta.Push(Convert.ToInt32(sum  * 100));
                }
                else
                {
                    sta.Push(Convert.ToInt32(h[arr[i]]));
                    
                }
            }

            if (sta.Count != 0)
            {
                
                sum = 0;
                count = sta.Count;
                for (int i = 0; i < count; i++)
                {
                    sum = sum + sta.Pop();
                }

                count = res.Count;
                for (int i = 0; i < count; i++)
                {
                    sum = sum + res.Pop();
                }
               
            }
            else
            {
                sum = 0;
                count = res.Count;
                for (int i = 0; i < count; i++)
                {
                    sum = sum + res.Pop();
                }
            }


            if (arr[0] == "negative")
            {
                sum = sum * -1;
            }
            Console.WriteLine(sum);
    }
}
}