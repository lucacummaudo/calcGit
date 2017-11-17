using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculatrice
{
    /// <summary>
    /// Simple Multiplication class
    /// </summary>
    public class Multiplication
    {
        private double val1;
        private double val2;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="a">First value</param>
        /// <param name="b">Second value</param>
        public Multiplication(double a, double b)
        {
            this.val1 = a;
            this.val2 = b;
        }

        /// <summary>
        /// Add the two setted values (Additionne les 2 valeurs définies)
        /// </summary>
        /// <returns>Result of sum</returns>
        public double Multipli()
        {
            return val1 * val2;
        }

        /// <summary>
        /// Get the first value(Lecture)
        /// </summary>
        /// <returns>value</returns>
        public double getVal1()
        {
            return this.val1;
        }

        /// <summary>
        /// Get the second value(Lecture)
        /// </summary>
        /// <returns>value</returns>
        public double getVal2()
        {
            return this.val2;
        }

        /// <summary>
        /// Set the first value(Ecriture)
        /// </summary>
        /// <param name="val">value</param>
        public void setVal1(double val)
        {
            this.val1 = val;
        }

        /// <summary>
        /// Set the second value(Ecriture)
        /// </summary>
        /// <param name="val">value</param>
        public void setVal2(double val)
        {
            this.val2 = val;
        }

        public string Affiche()
        {
            return "The sum of " + val1.ToString()
                   + " and " + val2.ToString()
                   + " is " + Multipli().ToString();
        }
    }
}
