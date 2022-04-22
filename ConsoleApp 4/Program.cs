using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y = 2022;
            int M = 2;
            int D = 20;
            int NJ;
            if (Y % 4 == 0 && Y % 100 != 0 || Y % 400 == 0)
            {
                if (M > 2)
                {
                    if (M % 2 == 0)
                    {
                        NJ = M / 2 * 31 + (M / 2 - 1) * 30 - 1 + D;
                    }
                    else
                    {
                        if (M >= 8)
                        {
                            NJ = (M + 1) / 2 * 31 + ((M - 1) / 2 - 1) * 30 - 1 + D;
                        }
                        else
                        {
                            NJ = (M - 1) / 2 * 30 + (M - 1) / 2 * 30 - 1 + D;
                        }
                    }
                }
                else
                {
                    NJ = (M - 1) * 31 + D;
                }
            }
            else
            {
                if (M > 2)
                {
                    if (M % 2 == 0)
                    {
                        NJ = M / 2 * 31 + (M / 2 - 1) * 30 - 2 + D;
                    }
                    else
                    {
                        if (M >= 8)
                        {
                            NJ = (M + 1) / 2 * 31 + ((M - 1) / 2 - 1) * 30 - 2 + D;
                        }
                        else
                        {
                            NJ = (M - 1) / 2 * 31 + (M - 1) / 2 * 30 - 2 + D;
                        }
                    }
                }
                else
                {
                    NJ = (M - 1) * 31 + D;
                }
            }
            Console.Write("NJ={0}", NJ);
            Console.ReadKey();
        }
    }
}
