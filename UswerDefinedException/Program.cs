using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UswerDefinedException
{
    class Calculate
    {
        int sum = 0;
        int count = 0;
        internal float average;

        public void FindAverage(params int[] values)
        {
            count = values.Length;

            if (count == 0)
            {
                throw (new CountIsZeroException("Count is zero for finding average, Try again!!!"));
            }
            else
            {
                foreach (int x in values)
                {
                    sum += x;

                }
                average = sum / count;
            }

        }
    }

    public class CountIsZeroException : ApplicationException
    {
        public CountIsZeroException(string message) : base(message)
        {

        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Handling User Defined Exception ");
            Calculate calc = new Calculate();

            try
            {
                calc.FindAverage();
            }
            catch (CountIsZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The average is {0}  ", calc.average);
            }
            Console.ReadKey();
        }
    }
}


