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
            int basee = Convert.ToInt32(nums[0]);
            long exp = Convert.ToInt64(nums[1]);
            long uno = 0, dos = 0, tres = 0, cuatro = 0, cinco = 0, seis = 0, siete = 0,
                ocho = 0, nueve = 0, cero = 0;

            long div4 = exp / 4;
            long residuo4 = exp % 4;

            long div2 = exp / 2;
            long residuo2 = exp % 2;

            switch (basee)
            {
                case 2:
                    dos = div4;
                    cuatro = div4;
                    ocho = div4;
                    seis = div4;
                    switch (residuo4)
	                    {
                            case 1:
                                dos++;
                                break;
                            case 2:
                                cuatro++;
                                dos++;
                                break;
                            case 3:
                                ocho++;
                                cuatro++;
                                dos++;
                                break;
	                    }
                    break;

                case 3:
                    tres = div4;
                    nueve = div4;
                    siete = div4;
                    uno = div4;
                    switch (residuo4)
                    {
                        case 1:
                            tres++;
                            break;
                        case 2:
                            nueve++;
                            tres++;
                            break;
                        case 3:
                            siete++;
                            nueve++;
                            tres++;
                            break;
                    }
                    break;

                case 4:
                    cuatro = div2;
                    seis = div2;
                    if (residuo2 == 1)
                    {
                        cuatro++;
                    }
                    break;

                case 5:
                    cinco = exp;
                    break;

                case 6:
                    seis = exp;
                    break;

                case 7:
                    siete = div4;
                    nueve = div4;
                    tres = div4;
                    uno = div4;
                    switch (residuo4)
                    {
                        case 1:
                            siete++;
                            break;
                        case 2:
                            nueve++;
                            siete++;
                            break;
                        case 3:
                            tres++;
                            nueve++;
                            siete++;
                            break;
                    }
                    break;

                case 8:
                    ocho = div4;
                    cuatro = div4;
                    dos = div4;
                    seis = div4;
                    switch (residuo4)
                    {
                        case 1:
                            ocho++;
                            break;
                        case 2:
                            cuatro++;
                            ocho++;
                            break;
                        case 3:
                            dos++;
                            cuatro++;
                            ocho++;
                            break;
                    }
                    break;

                case 9:
                    nueve = div2;
                    uno = div2;
                    if (residuo2 == 1)
                    {
                        nueve++;
                    }
                    break;

                
            }
            Console.WriteLine("0: " + cero + ", 1: " + uno + ", 2: " + dos + ", 3: " + tres + ", 4: " + cuatro + ", 5: " + cinco
                + ", 6: " + seis + ", 7: " + siete + ", 8: " + ocho + ", 9: " + nueve);
        }
    }
}