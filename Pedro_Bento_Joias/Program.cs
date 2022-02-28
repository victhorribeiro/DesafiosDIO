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
            List<string> joiasBau = new List<string>();

            string joia = "";

            do
            {
                joia = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(joia))
                {
                    break;
                }
                else
                {
                    joiasBau.Add(joia);
                }
            }
            while (joiasBau.Count > 0);
            
            IEnumerable<string> distinctJoias = joiasBau.Distinct();

            Console.WriteLine(distinctJoias.Count());
            
            
        }
    }
}