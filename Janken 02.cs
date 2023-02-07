using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Janken2
{
    public class Class1
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

            int draw = 0;
            int player_win = 0;
            int player_lost = 0;

            Console.Write("回数を入力してください：");
            String play_time = Console.ReadLine();
            int play_timeChoice;
            play_timeChoice = Int32.TryParse(play_time, out play_timeChoice) ? play_timeChoice : -1;

            if (play_timeChoice <= -1)
            {
                Console.WriteLine("正しい入力ではありません。(input:{0}))", play_time);
            }

            for (int i = 1; i <= play_timeChoice; i++)
            {
                Console.WriteLine("[{0}]回戦 入力してください。(1:グー,2:パー,3:チョキ)", i.ToString());
                player_hand = Console.ReadLine();
                int player_choice;
                player_choice = Int32.TryParse(player_hand, out player_choice) ? player_choice : -1;

                int com_choice = rnd.Next(1, 4);
                String letter = String.Format("{0} : {1}", getLetter(com_choice), com_choice.ToString());

                if (player_choice > 3 || player_choice < 1)
                {
                    throw new Exception(String.Format("正しい入力ではありません。（input:{0})", player_hand));
                }
                else if (player_choice == com_choice)
                {
                    Console.WriteLine("[{0}]回戦 引き分け (COM：{1})", i.ToString(), letter);
                    draw++;
                }
                else if (
                    (player_choice == 1 && com_choice == 3) ||
                    (player_choice == 2 && com_choice == 1) ||
                    (player_choice == 3 && com_choice == 2)
               )
                {
                    Console.WriteLine("[{0}]回戦 結果：勝 (COM：{1})", i.ToString(), letter);
                    player_win++;
                }
                else
                {
                    Console.WriteLine("[{0}]回戦 結果：敗 (COM：{1})", i.ToString(), letter);
                    player_lost++;
                }
            }
            Console.WriteLine("戦績：{0}勝、{1}敗、{2}引き分け", player_win, player_lost, draw);
        }
    }
}
