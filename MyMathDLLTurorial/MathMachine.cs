using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathDLLTurorial
{
    public class MathMachine
        
    {

        /// <summary>
        /// Adds two different integers 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>integer</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Returns the result of integer b subracted from integer a
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int subract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Returns the result of integers b and c subracted from integer a
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int subract(int a, int b, int c)
        {
            return a - (b + c);
        }

        /// <summary>
        /// returns the result of int a multiplied by int b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// returns the result of int a multiplied by int b and int c
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        /// <summary>
        /// returns the result of int a divided by int b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public double divide(int a, int b)
        {
            double da = a;
            double db = b;
            return da / db;
        }

        /// <summary>
        /// Returns the result of int a divided by int b and then by int c
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double divide(int a, int b, int c)
        {
            double da = a;
            double db = b;
            double dc = c;
            return (da / db) / dc;
        }
    }
}
