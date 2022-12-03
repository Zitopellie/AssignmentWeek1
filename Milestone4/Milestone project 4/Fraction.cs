using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_project_4
{
    public   class Fraction
    {

        string fractionToParse = "";
        public Fraction()
        {
            fractionToParse = "0/0";

        }

        public Fraction(string frctionToParse)
        {
           fractionToParse = frctionToParse;
        }

        public  double Parse( )
        {

            string fraction = fractionToParse;
            double result;

            if (double.TryParse(fraction, out result))
            {
                return result;
            }

            string[] split = fraction.Split(new char[] { ' ', '/' });

            if (split.Length == 2 || split.Length == 3)
            {
                int a, b;

                if (int.TryParse(split[0], out a) && int.TryParse(split[1], out b))
                {
                    if (split.Length == 2)
                    {
                        return (double)a / b;
                    }

                    int c;

                    if (int.TryParse(split[2], out c))
                    {
                        return a + (double)b / c;
                    }
                }
            }

            throw new FormatException("Not a valid fraction.");
        }
    }
}
