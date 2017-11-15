using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianFractions
{
    class Program
    {
        private static List<Fraction> result = new List<Fraction>();

        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split('/');
            int nominator = int.Parse(line[0]);
            int denominator = int.Parse(line[1]);

            if (nominator >= denominator)
            {
                Console.WriteLine("Error ( fraction is equal or greater then 1)");
                return;
            }

            Fraction target = new Fraction(nominator, denominator);

            Fraction bigestEgyptian = new Fraction(1, 2);

            CalculateFraction(target, bigestEgyptian);

            Console.WriteLine("{0} = {1}",target,string.Join(" + ",result));
        }

        private static void CalculateFraction(Fraction target, Fraction fraction)
        {
            while (target.CompareTo(fraction) != 0)
            {
                if (target.CompareTo(fraction) < 0)
                {
                    while (target.CompareTo(fraction) < 0)
                    {
                        Fraction newfraction = new Fraction(fraction.Nominator, fraction.Denominator + 1);

                        fraction = newfraction;
                    }
                }
                else
                {
                    result.Add(fraction);
                    target = target - fraction;
                }
            }

            result.Add(fraction);   
        }
    }
}
