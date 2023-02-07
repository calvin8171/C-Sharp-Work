using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suji1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //comの部分
            List<int> com = new List<int>();

            Random random = new Random();

            while (com.Count < 3)
            {
                int randomNumber = random.Next(1, 10);

                if (!com.Contains(randomNumber))
                {
                    com.Add(randomNumber);
                }
            }

            //playerの部分
            for (int i = 1; i <= 10; i++)
            {
                int correct = 0;
                int wrongPlace = 0;
                int incorrect = 0;

                try
                {
                    Console.Write("[Round {0}] Input Number : ", i.ToString());
                    String playerInput = Console.ReadLine();

                    if (playerInput.Length < 3 || playerInput.Length > 3)
                    {
                        throw new playerInputOutOfRange("Unhandled exception. System.Exception: [Error] reason : Not the correct value");
                    }
                    
                    List<int> player = new List<int>();

                    for (int j = 0; j < 3; j++)
                    {
                        string str = playerInput.Substring(j, 1);
                        int playerNumber = int.Parse(str);
                        player.Add(playerNumber);
                    }

                    if (com[0] == player[0]) { correct++; }
                    else if (com[0] == player[1] || com[0] == player[2]) { wrongPlace++; }
                    else { incorrect++; }

                    if (com[1] == player[1]) { correct++; }
                    else if (com[1] == player[0] || com[1] == player[2]) { wrongPlace++; }
                    else { incorrect++; }

                    if (com[2] == player[2]) { correct++; }
                    else if (com[2] == player[0] || com[2] == player[1]) { wrongPlace++; }
                    else { incorrect++; }

                    Console.WriteLine("⇒ 〇({0}) △({1}) ×({2})", correct, wrongPlace, incorrect);

                    if (correct == 3)
                    {
                        Console.WriteLine("Result : Congratulation!!");
                        break;
                    }

                    else if (i == 10)
                    {
                        Console.WriteLine("Result : Failed   Answer : {0}{1}{2}", com[0], com[1], com[2]);
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Unhandled exception. System.Exception: [Error] reason : Not the correct value");
                }
                catch (playerInputOutOfRange ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    public class playerInputOutOfRange : Exception
    {
        public playerInputOutOfRange(string message)
            : base(message)
        {
        }
    }
}
