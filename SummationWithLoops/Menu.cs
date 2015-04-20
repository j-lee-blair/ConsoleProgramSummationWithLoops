using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Menu
    {
        public void WriteMenuText()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("                     MAIN MENU                         ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Whole Numbers with For                  : 1");
            Console.WriteLine("Floating Point Numbers with While       : 2");
            Console.WriteLine("Currency Converter with Do While Loop   : 3");
            Console.WriteLine("Work Schedule                           : 4");
            Console.WriteLine("Exit program                            : 0");
            Console.WriteLine("-----------------------------------------------------");
        }

        public void start()
        {
            Console.Clear();
            WriteMenuText();
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 0:
                    {
                        break;
                    }

                case 1:
                    {
                        WholeNumbersForAdd sumObj = new WholeNumbersForAdd();
                        sumObj.Start();
                        Console.WriteLine(sumObj.ShowResults());
                        Console.ReadLine();
                        break;
                    }

                case 2:
                    {
                        FloatingPointNumbersWhileAdd addObj = new FloatingPointNumbersWhileAdd();
                        Console.Write(addObj.WriteProgramInfo());
                        addObj.Start();
                        Console.WriteLine(addObj.ShowResults());
                        Console.ReadLine();
                        break;
                    }

                case 3:
                    {
                        CurrencyConverter convObj = new CurrencyConverter();
                        convObj.Start();
                        Console.WriteLine(convObj.ShowResults());
                        Console.ReadLine();
                        break;
                    }

                case 4:
                    {
                        WorkingSchedule workObj = new WorkingSchedule();
                        Console.Write(workObj.DisplayViewOption());
                        workObj.Start();
                        Console.ReadLine();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid option. Press Any key to continue.");
                        Console.ReadLine();
                        break;
                    }
            }
        }
    }
}

