using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janken1
{
    class Program
    {
        public static String getLetter(int i)
        {
            switch (i)
            {
                case 1: return "グー";
                case 2: return "パー";
                case 3: return "チョキ";
                default:
                    throw new Exception(String.Format("正しい入力ではありません。（input:{0})", i.ToString())); 
            }
        }
        static void Main(string[] args)
        {
            String player_hand;
            Random rnd = new Random();

            for (int i = 0; i <= 1; i++) 
            {
                Console.WriteLine("入力してください。(1:グー,2:パー,3:チョキ)"); 
                player_hand = Console.ReadLine();
                int player_choice;
                player_choice = Int32.TryParse(player_hand, out player_choice) ? player_choice : -1; 
                                                                                                     
                int com_choice = rnd.Next(1, 4);
                String letter = String.Format("{0} : {1}", getLetter(com_choice), com_choice.ToString());

                if (player_choice > 3 || player_choice < 1)
                {
                    Console.WriteLine("正しい入力ではありません。(input:{0}))", player_hand);
                }
                else if (player_choice == com_choice)
                {
                    Console.WriteLine("引き分け (COM：{0})", letter);
                } 
                else if (
                    (player_choice == 1 && com_choice == 3) ||
                    (player_choice == 2 && com_choice == 1) ||
                    (player_choice == 3 && com_choice == 2)
                ) 
                {
                    Console.WriteLine("結果：勝（COM：{0})", letter);
                }
                else
                {
                    Console.WriteLine("結果：敗（COM：{0})", letter);
                }
            }
        }
    }
}
