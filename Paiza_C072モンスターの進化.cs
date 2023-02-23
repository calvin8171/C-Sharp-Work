using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C072モンスターの進化
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String input2 = Console.ReadLine();
            String[] paramsArr = input.Split(' ');

            int attack = int.Parse(paramsArr[0]);
            int defend = int.Parse(paramsArr[1]);
            int speed = int.Parse(paramsArr[2]);

            int monsterNumber = int.Parse(input2);

            string monsterName = "";
            int minAttack = 0;
            int maxAttack = 0;
            int minDefend = 0;
            int maxDefend = 0;
            int minSpeed = 0;
            int maxSpeed = 0;
            int evolutedMonster = 0; // outside the for loop value will be kept as it is, will not be reset

            for (int i = 0; i < monsterNumber; i++)
            {
                int isValidateAttack = 0;  // variable inside the for loop will be reset in each round
                int isValidateDefend = 0;
                int isValidateSpeed = 0;
                input = Console.ReadLine();
                String[] paramsArr2 = input.Split(' '); //pay attention to the variable, need to be paramsArr2

                monsterName = paramsArr2[0]; // here is string
                minAttack = int.Parse(paramsArr2[1]);
                maxAttack = int.Parse(paramsArr2[2]);
                minDefend = int.Parse(paramsArr2[3]);
                maxDefend = int.Parse(paramsArr2[4]);
                minSpeed = int.Parse(paramsArr2[5]);
                maxSpeed = int.Parse(paramsArr2[6]);

                if (attack >= minAttack && attack <= maxAttack)
                {
                    isValidateAttack++;
                }

                if (defend >= minDefend && defend <= maxDefend)
                {
                    isValidateDefend++;
                }

                if (speed >= minSpeed && speed <= maxSpeed)
                {
                    isValidateSpeed++;
                }

                if (isValidateAttack >= 1 && isValidateDefend >= 1 && isValidateSpeed >= 1)
                {
                    Console.WriteLine(monsterName);
                    evolutedMonster++;
                }
            }

            if (evolutedMonster == 0)
            {
                Console.WriteLine("no evolution");
            }

            Console.ReadLine();
        }
    }
}
