using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class WholeNumbersForAdd
    {
        private int numOfInput;
        private int sum;

        public void Start()
        {
            WriteProgramInfo();
            SumNumbers();
        }

        private void ReadInput()
        {
            Console.WriteLine("Number of values to sum?\n");
            numOfInput = int.Parse(Console.ReadLine());
        }

        private void WriteProgramInfo()
        {
            Console.WriteLine("++++++ Summation of whole numbers ++++++");
            Console.WriteLine("         Using a for-statement\n\n");
        }

        private void SumNumbers()
        {
            ReadInput();
            //adds index to sum and increments index numberOfInput times
            for (int i = 0; i < numOfInput; i++)
            {
                sum += i;
            }
        }

        public string ShowResults()
        {
            return String.Format("----------------------------------\nThe sum is: \t {0}\nPress any key to contine.", sum);
        }
    }
}

