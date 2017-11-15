using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianFractions
{
    class Fraction : IComparable<Fraction>
    {

        public Fraction(int nominator, int denominator)
        {
            this.Denominator = denominator;
            this.Nominator = nominator;
        }

        public int Denominator { get; set; }

        public int Nominator { get; set; }

        public int CompareTo(Fraction other)
        {
            return (this.Nominator * other.Denominator).CompareTo(other.Nominator * this.Denominator);
        }

        public static Fraction operator - (Fraction first,Fraction second)
        {
            int newNominator = first.Nominator * second.Denominator - first.Denominator * second.Nominator;
            int newDenominator = first.Denominator * second.Denominator;
            return new Fraction(newNominator, newDenominator);
        }

        public override string ToString()
        {
            return this.Nominator + "/" + this.Denominator;
        }
    }
}
