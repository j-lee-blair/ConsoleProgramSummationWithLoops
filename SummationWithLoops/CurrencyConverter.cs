using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class CurrencyConverter
    {
        private string currency;
        private decimal result;
        private decimal rate;
        private decimal sum;

        public void Start()
        {
            WriteProgramInfo();
            CalculateConversion();
        }

        public void WriteProgramInfo()
        {
            SumAmount();

            Console.Write("\n\nEnter name of currency: ");
            currency = Console.ReadLine();

            Console.Write("Enter conversion rate: ");
            rate = decimal.Parse(Console.ReadLine());
        }

        private void SumAmount()
        {
            decimal value = 0;
            bool done = false;
            while (!done)
            {
                Console.Write("Write an amount or zero to finish: ");
                value = decimal.Parse(Console.ReadLine());

                if (Math.Round(value, 7) == 0)
                {
                    return;
                }
                else sum += value;
            }
        }

        private decimal CalculateConversion()
        {
            result = rate * sum;
            return result;
        }

        public string ShowResults()
        {
            return string.Format("----------------------------------\nConversion rate: {0}\n{1} is valued at: {2}\nPress any key to contine.",  rate, currency, result);
        }
    }
}
