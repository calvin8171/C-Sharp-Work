using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C115渋滞の距離
{
    class Program
    {
        static void Main(string[] args)
        {
            String Input = Console.ReadLine();
            String[] paramsArr = Input.Split(' ');

            int carNumber = int.Parse(paramsArr[0]);
            int carDistance = int.Parse(paramsArr[1]);
            int congestionDistance = 0;
            int totalDistance = 0;

            for (int i = 1; i < carNumber; i++)
            {
                Input = Console.ReadLine();
                congestionDistance = int.Parse(Input); //Leave it like this to make sure congestionDistance changed per loop.

                if (congestionDistance <= carDistance)
                {
                    totalDistance += congestionDistance; //totalDistance here add up the congestionDistance
                }
            }
            Console.WriteLine(totalDistance);

            Console.ReadLine();
        }
    }
}
