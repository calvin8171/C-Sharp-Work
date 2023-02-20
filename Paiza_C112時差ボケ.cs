using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C112時差ボケ
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int day = int.Parse(input);

            int departureTime = 0;
            int flightTime = 0;
            int arrivalTime = 0;

            int totalHour = 0;
            int shortestHour = 0;
            int longestHour = 0;

            for (int i = 0; i < day; i++)
            {
                input = Console.ReadLine();
                String[] paramsArr = input.Split(' ');

                departureTime = int.Parse(paramsArr[0]);
                flightTime = int.Parse(paramsArr[1]);
                arrivalTime = int.Parse(paramsArr[2]);

                totalHour = (departureTime + flightTime + (24 - arrivalTime));

                if (i == 0) // learnt how to use i == 0 as a starting statement of variables 
                {
                    shortestHour = totalHour;
                    longestHour = totalHour;
                }
                else if (totalHour > longestHour)
                {
                    longestHour = totalHour;
                }
                else if (totalHour < shortestHour)
                {
                    shortestHour = totalHour;
                }
            }
            Console.WriteLine(shortestHour);
            Console.WriteLine(longestHour);
            
            Console.ReadLine();
        }
    }
}
