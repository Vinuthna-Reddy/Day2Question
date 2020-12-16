using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter min");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("enter max");
            int max = int.Parse(Console.ReadLine());
            for (int num = min; num <= max; num++)
            {
                int ctr = 0;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num); 
            }
            Console.Write("\n");
            
        }
    }
    }

