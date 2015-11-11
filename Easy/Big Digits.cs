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
            //string line = "3.1415926";
            char[] arr = line.ToCharArray();
            
            string[] cero = { "-**--", "*--*-", "*--*-", "*--*-", "-**--", "-----" };
            string[] uno = { "--*--", "-**--", "--*--", "--*--", "-***-", "-----" };
            string[] dos = { "***--", "---*-", "-**--", "*----", "****-", "-----" };
            string[] tres = { "***--", "---*-", "-**--", "---*-", "***--", "-----" };
            string[] cuatro = { "-*---", "*--*-", "****-", "---*-", "---*-", "-----" };
            string[] cinco = { "****-", "*----", "***--", "---*-", "***--", "-----" };
            string[] seis = { "-**--", "*----", "***--", "*--*-", "-**--", "-----" };
            string[] siete = { "****-", "---*-", "--*--", "-*---", "-*---", "-----" };
            string[] ocho = { "-**--", "*--*-", "-**--", "*--*-", "-**--", "-----" };
            string[] nueve = { "-**--", "*--*-", "-***-", "---*-", "-**--", "-----" };


            string res = "";


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (Char.IsDigit(arr[j]))
                    {
                        int num = Convert.ToInt32(Convert.ToString(arr[j]));
                        switch (num)
                        {
                            case 0:
                                res = res + cero[i];
                                
                                break;
                            case 1:

                                res = res + uno[i];
                                break;
                            case 2:

                                res = res + dos[i];
                                break;
                            case 3:
                                res = res + tres[i];
                                break;
                            case 4:
                                res = res + cuatro[i];
                                break;
                            case 5:

                                res = res + cinco[i];
                                break;
                            case 6:

                                res = res + seis[i];
                                break;
                            case 7:

                                res = res + siete[i];
                                break;
                            case 8:

                                res = res + ocho[i];
                                break;
                            case 9:

                                res = res + nueve[i];
                                break;
                        }
                    }
                }

                
               res = res + '\n';
            }
            Console.WriteLine(res);
        }
    }
}