using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class WorkingSchedule
    {
        const int maxWeeks = 52;
        int currentWeek;

        public void Start()
        {
            DisplayWorkingWeekInterval();
        }

        public string DisplayViewOption()
        {
            return String.Format("1 Show a list of the weekends to work\n2 Show a list of the nights to work\n0 Return to Main Menu");
        }

        private void DisplayWorkingWeekInterval()
        {
            bool isNight = (Console.ReadLine() == "2");
            if (!isNight)
            {
                Console.WriteLine("\n\nSchedule of working weekends:\n\n");
                for (int startWeekends = 6; startWeekends < maxWeeks; startWeekends++)
                {
                    currentWeek = startWeekends;
                    //modulus function shows only numbers exactly divisible by x
                    if (currentWeek % 3 == 0)
                    {
                        Console.Write("Week:\t {0}\t", currentWeek);
                    }
                }
            }

            else
            {
                Console.WriteLine("\n\nSchedule of working nights:\n\n");
                for (int startNights = 1; startNights < maxWeeks; startNights++)
                {
                    currentWeek = startNights;
                    //modulus function shows only numbers exactly divisible by x
                    if (currentWeek % 5 == 0)
                    {
                        Console.Write("Week:\t {0}\t", currentWeek);
                    }
                }
            }
        }
    }
}
