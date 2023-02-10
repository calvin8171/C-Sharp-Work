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
            int overlapArea = 0; 

            for (int i = 1; i < paper; i++)
            {
                Input = Console.ReadLine();
                overlapArea += int.Parse(Input);
            }

            Console.WriteLine((paper * widthLength - overlapArea) * widthLength);

            Console.ReadLine();
        }
    }
}
