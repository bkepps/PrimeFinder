using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace prime_number_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check for prime numbers up to:");
            long checkTo = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Please enter location to output primes to:");
            Console.WriteLine("ex: C:\\Users\\bensk\\Desktop\\");
            string saveLocation = Console.ReadLine() + "Prime Numbers1.txt";
            Console.WriteLine(saveLocation);


            long x = 3;
            long ptest;
            List<long> primeNumbers = new List<long>
            {
                2
            };
            Console.WriteLine("Running . . .");

            while (x < checkTo)
            {
                
                for(int y = 0; y < primeNumbers.Count/2; y++)
                {
                    ptest = x % primeNumbers[y];
                    /*Console.Write("remainder of ");
                    Console.Write(x);
                    Console.Write(" / ");
                    Console.Write(primeNumbers[y]);
                    Console.Write(" is: ");
                    Console.WriteLine(ptest);*/
                    if (ptest == 0)
                    {
                        //Console.WriteLine("skipped");
                        goto Nextnum;
                        
                    }
                    
                }
                primeNumbers.Add(x);

            Nextnum:
                x++;
            }
            Console.WriteLine("Done");

            var pnString = primeNumbers.ConvertAll(g => g.ToString()).ToArray();
            System.IO.File.WriteAllLines(saveLocation, pnString);
            //System.Console.Beep(400, 1000);
            //System.Console.Beep(500, 1000);
            //System.Console.Beep(800, 1000);
            Console.ReadLine();
        }
    }
}
