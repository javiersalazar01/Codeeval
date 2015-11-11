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
                    //string line = "1000000000";
                    int[] actu = new int[line.Length];
                    for (int i = 0; i < line.Length; i++)
                    {
                        actu[i] = Convert.ToInt32(Convert.ToString(line[i]));
                    }
                    string[] units = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
                    string[] teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                    string[] tens = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
                    string hun = "Hundred";
                    string tho = "Thousand";
                    string mi = "Million";
                    string bil = "Billion";
                    string dol = "Dollars";
                    string res = "";
                    int j = line.Length;

                    for (int i = 0; i < actu.Length; i++)
                    {
                        switch (j)
                        {
                            case 1:

                                if (actu.Length == 1)
                                {
                                    res = res + units[actu[i] - 1] + dol;
                                }
                                else
                                {
                                    if (actu[i - 1] == 1)
                                    {
                                        res = res + teens[actu[i]] + dol;
                                    }
                                    else
                                    {
                                        if (actu[i] != 0)
                                        {
                                            res = res + units[actu[i] - 1] + dol;
                                        }
                                        else
                                        {
                                            if (actu.Length == 2)
                                            {
                                                res = res + dol;
                                            }
                                            else if (actu[i - 2] != 0 || actu[i - 1] != 0)
                                            {
                                                res = res + dol;
                                            }

                                        }
                                    }
                                }
                                break;
                            case 2:
                                if (actu[i] > 1)
                                {
                                    res = res + tens[actu[i] - 2];
                                }

                                break;
                            case 3:
                                if (actu[i] != 0)
                                {

                                    res = res + units[actu[i] - 1] + hun;
                                }
                                break;
                            case 4:

                                if (actu.Length == 4)
                                {
                                    res = res + units[actu[i] - 1] + tho;
                                }
                                else
                                {
                                    if (actu[i - 1] == 1)
                                    {
                                        res = res + teens[actu[i]] + tho;
                                    }
                                    else
                                    {
                                        if (actu[i] != 0)
                                        {
                                            res = res + units[actu[i] - 1] + tho;
                                        }
                                        else
                                        {
                                            if (actu.Length == 5)
                                            {
                                                res = res + tho;
                                            }
                                            else if (actu[i - 2] != 0 || actu[i-1] != 0)
                                            {
                                                res = res + tho;
                                            }
                                            
                                        }
                                    }
                                }

                                break;
                            case 5:
                                if (actu[i] > 1)
                                {
                                    res = res + tens[actu[i] - 2];
                                }
                                break;
                            case 6:
                                if (actu[i] != 0)
                                {
                                    res = res + units[actu[i] - 1] + hun;
                                }

                                break;
                            case 7:

                                if (actu.Length == 7)
                                {
                                    res = res + units[actu[i] - 1] + mi;
                                }
                                else
                                {
                                    if (actu[i - 1] == 1)
                                    {
                                        res = res + teens[actu[i]] + mi;
                                    }
                                    else
                                    {
                                        if (actu[i] != 0)
                                        {
                                            res = res + units[actu[i] - 1] + mi;
                                        }
                                        else
                                        {
                                            if (actu.Length == 8)
                                            {
                                                res = res + mi;
                                            }
                                            else if (actu[i - 2] != 0 || actu[i-1] != 0)
                                            {
                                                res = res + mi;
                                            }
                                            
                                        }
                                    }
                                }
                                
                                break;
                            case 8:
                                if (actu[i] > 1)
                                {
                                    res = res + tens[actu[i] - 2];
                                }
                                break;
                            case 9:
                                if (actu[i] != 0)
                                {
                                    res = res + units[actu[i] - 1] + hun;
                                }
                                break;
                            case 10:
                                if (actu[i] != 0)
                                {
                                    res = res + units[actu[i] - 1] + bil;
                                }
                                break;

                        }
                        j--;
                    }
                    if (!res.Contains(dol))
                    {
                        res = res + dol;
                    }
                    Console.WriteLine(res);
        }
    }
}