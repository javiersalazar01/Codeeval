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
                    string[] arr = line.Split(';');
                    int rows = Convert.ToInt32(arr[0]);
                    int coul = Convert.ToInt32(arr[1]);
                    string[] numbersString = arr[2].Split(' ');
                    string[,] matrix = new string[rows, coul];
                    int k = 0;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            matrix[i, j] = numbersString[k];
                            k++;
                        }
                    }

                    int arri = 0, comA = 0, terA = matrix.GetLength(1);
                    int der = matrix.GetLength(1) - 1, comD = 1, terD = matrix.GetLength(0);
                    int aba = matrix.GetLength(0) - 1, comAb = matrix.GetLength(1) - 2, terAb = 0;
                    int izq = 0, comIz = matrix.GetLength(0) - 2, terI = 1;
                    int count = 0;
                    string res = "";
                    bool end = true;
                    int m = 1;
                    while (end)
                    {

                        if (m == 5)
                        {
                            m = 1;
                        }
                            switch (m)
                            {
                                case 1:
                                    for (int j = comA; j < terA; j++)
                                    {
                                        res = res + " " + matrix[arri, j];
                                        count++;
                                    }
                                    arri++;
                                    comA++;
                                    terA--;
                                    if (count == (rows * coul)) { end = false; }
                                    break;
                                case 2:
                                    for (int i = comD; i < terD; i++)
                                    {
                                        res = res + " " + matrix[i, der];
                                        count++;
                                    }
                                    der--;
                                    terD--;
                                    comD++;

                                    if (count == (rows * coul)) { end = false; }
                                    break;
                                case 3:
                                    for (int j = comAb; j >= terAb; j--)
                                    {
                                        res = res + " " + matrix[aba, j];
                                        count++;
                                    }
                                    aba--;
                                    comAb--;
                                    terAb++;
                                    if (count == (rows * coul)) { end = false; }
                                    break;
                                case 4:
                                    for (int i = comIz; i >= terI; i--)
                                    {
                                        res = res + " " + matrix[i, izq];
                                        count++;
                                    }
                                    izq++;
                                    comIz--;
                                    terI++;
                                    if (count == (rows * coul)) { end = false; }
                                    break;
                            }
                            m++;
                        
                    }
                    Console.WriteLine(res.Trim());
        }
    }
}