using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing7 //Paiza C099折り紙の貼り合わせ
{
    class Program
    {
        static void Main(string[] args)
        {
            String Input = Console.ReadLine();
            String[] paramsArr = Input.Split(' ');

            int paper = int.Parse(paramsArr[0]);
            int widthLength = int.Parse(paramsArr[1]);
            int overlapArea = 0; // to avoid compiler error (means the variable cannot be used inside the loop without defining it outside)

            for (int i = 1; i < paper; i++)
            {
                Input = Console.ReadLine();
                overlapArea += int.Parse(Input); // This is the way to add up the overlapArea
            }

            Console.WriteLine((paper * widthLength - overlapArea) * widthLength);

            Console.ReadLine();
        }
    }
}
