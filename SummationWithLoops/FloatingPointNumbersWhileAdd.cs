using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class FloatingPointNumbersWhileAdd
    {
        private double sum;

        public void Start()
        {
            ReadInputAndSumNumber();
        }

        public string WriteProgramInfo()
        {
            return string.Format("++++++ Summation of floating numbers ++++++\nUsing a while-statement\n\n");
        }

        private void ReadInputAndSumNumber()
        {
            bool done = false;

            while (!done)
            {
                Console.Write("Write an amount to sum or zero to finish: ");
                double number = ReadInput();

                if (Math.Round(number, 7) == 0.0)
                {
                    return;
                }

                else sum += number;
            }
        }

        private double ReadInput()
        {
            double num = double.Parse(Console.ReadLine());
            return num;
        }

        public string ShowResults()
        {
            return string.Format("----------------------------------\nThe sum is: \t {0}\nPress any key to contine.", sum);
        }
    }
}
