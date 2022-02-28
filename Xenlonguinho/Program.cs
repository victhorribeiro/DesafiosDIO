using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int casosDeTeste = int.Parse(Console.ReadLine());

            for (int x = 0; x < casosDeTeste; x++)
            {
                int qtdeMinima = 0;

                int numeroEsferas = int.Parse(Console.ReadLine());
                if (2 <= numeroEsferas && numeroEsferas <= 1000)
                {
                    qtdeMinima = 0;

                    for (int i = numeroEsferas; i > 0; i--)
                    {
                        int qtdeDivisores = 0;

                        for (int j = i; j > 0; j--)
                        {
                            if (i % j == 0)
                            {
                                qtdeDivisores++;
                            }
                        }
                        if (qtdeDivisores % 2 == 0)
                        {
                            qtdeMinima++;
                        }
                    }
                    Console.WriteLine(qtdeMinima);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}