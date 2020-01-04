using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodinisDarbas
{

    public class Metodas
    {
        public void Futbolas()
        {
            string results = "Manchester United 1 Chelsea 0,Arsenal 1 Manchester United 1,Manchester United 3 Fulham 1,Liverpool 2 Manchester United 1,Swansea 2 Manchester United 4";
            string[] Games = results.Split(',');
            string[] Itemai = new string[5];
            int LaimetiM = 0, Lost = 0, Goal = 0, GoalIn = 0, tie = 0;

            for (int i = 0; i < Games.Length; i++)
            {
                Itemai = Games[i].Split(' ');

                if (Itemai[0].Contains("Manchester") && Itemai[1].Contains("United"))
                {
                    if (Convert.ToInt32(Itemai[2]) > Convert.ToInt32(Itemai[4]))
                    {
                        LaimetiM++;
                    }
                    else

                    if (Convert.ToInt32(Itemai[2]) < Convert.ToInt32(Itemai[4]))
                    {
                        Lost++;
                    }

                    else
                        tie++;


                    Goal = Goal + Convert.ToInt32(Itemai[2]);
                    GoalIn = GoalIn + Convert.ToInt32(Itemai[4]);

                }
                else
                {
                    if (Convert.ToInt32(Itemai[1]) < Convert.ToInt32(Itemai[4]))
                    {
                        LaimetiM++;
                    }
                    else

                    if (Convert.ToInt32(Itemai[1]) > Convert.ToInt32(Itemai[4]))
                    {
                        Lost++;
                    }
                    else
                        tie++;

                    Goal = Goal + Convert.ToInt32(Itemai[4]);
                    GoalIn = GoalIn + Convert.ToInt32(Itemai[1]);
                }
            }
            Console.WriteLine("Games: {0}", Games.Length);
            Console.WriteLine("Games Won: {0}", LaimetiM);
            Console.WriteLine("Games Lost: {0}", Lost);
            Console.WriteLine("Lygiosios: {0}", tie);
            Console.WriteLine("Goals: {0}:{1}", Goal, GoalIn);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
