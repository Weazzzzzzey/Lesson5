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

    public class Listai
    {
        Random rnd = new Random();
        List<int> T = new List<int>();
        List<string> S = new List<string>();
        List<string> Sv = new List<string>();
        List<string> Izimybes = new List<string>();
        List<int> Pazymiai = new List<int>();


        public void PazimiuUzpildymas()
        {
            Pazymiai.Add(2);
            Pazymiai.Add(3);
            Pazymiai.Add(4);
            Pazymiai.Add(7);
            Pazymiai.Add(6);
            Pazymiai.Add(8);
            Pazymiai.Add(9);
            Pazymiai.Add(0);
            Pazymiai.Add(2);
        }

        public void Pasirinkimai()
        {

            bool veikimas = true;
            while (veikimas)
            {

                Console.WriteLine("Pazymiai: ");
                foreach (var item in Pazymiai)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Galimybes:");
                Console.WriteLine("1 - Prideti nauja pazimi.");
                Console.WriteLine("2 - Panaikinti pazimi.");
                Console.WriteLine("3 - Prideti nauja pazimi, pasirinktoje vietoje.");
                Console.WriteLine("4 - Pazimiu vidurkis.");
                Console.WriteLine("5 - Baigti darba.");

                int ivedimas = 100;

                if (!int.TryParse(Console.ReadLine(),out ivedimas))
                {
                    Console.WriteLine("Ivestas netinkamas pasirinkimas");
                }
                switch (ivedimas)
                {
                    case 1:
                        Console.Write("Iveskite pazimi: ");
                        Pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Pazymiai.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Pasirinkite indexa, o tada irasykite pazimi: ");
                        Pazymiai.Insert(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Write("Vidurkis ");
                        decimal vid = (decimal)Pazymiai.Sum()/Pazymiai.Count();
                        Console.WriteLine(Math.Round(vid,2));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        veikimas = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }



        public void IzimybiuVardai()
        {
            Izimybes.Add("Johnny");
            Izimybes.Add("Bree");
            Izimybes.Add("Cheder");
            Izimybes.Add("Iron");
            Izimybes.Add("Rock");
        }

        public void IPerdirbimas()
        {
            Izimybes.Add("Napoleonas");
            Izimybes.Add("Asteriksas");

            Izimybes.RemoveAt(2);
            //-------------------

            for (int i = 0; i < Izimybes.Count; i++)
            {
                if (Izimybes[i] == "Napoleonas")
                {
                    Izimybes[i] = "Kleopatra";
                    break;
                }
            }

            if (Izimybes.Contains("Asteriksas"))
            {
                Izimybes[Izimybes.IndexOf("Asteriksas")] = "Asteriksas2";
            }

            //-------------------

            foreach (var item in Izimybes)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void StudentuIvedimas()
        {
            S.Add("Pirmas Studentas");
            S.Add("Antras Studentas");
            S.Add("Trecias Studentas");
            S.Add("Ketvirtas Studentas");
            Sv.Add("Penktas Studentas");
            Sv.Add("Sestas Studentas");
            Sv.Add("Septintas Studentas");
            Sv.Add("Astuntas Studentas");
        }

        public void Apdorojimas()
        {
            S.AddRange(Sv);
            S.Sort();

            foreach (var item in S)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void uzpildymas()
        {
            for (int i = 0; i < 10; i++)
            {
                T.Add(rnd.Next(30));
            }
        }

        public void isvedimas()
        {
            foreach (var item in T)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }

    }

    public class Laisvalaikis
    {
        public void Panasumas()
        {
            List<int> Sarasas = new List<int>();
            List<int> Panasus = new List<int>();

            Sarasas.Add(1);
            Sarasas.Add(2);
            Sarasas.Add(4);
            Sarasas.Add(3);
            Sarasas.Add(5);
            //Sarasas.Add(1);
            //Sarasas.Add(0);
            //Sarasas.Add(0);

            Panasus.Add(4);
            Panasus.Add(3);
            Panasus.Add(5);


            for (int i = 0; i < Sarasas.Count; i++)
            {
                if (Sarasas[i] == Panasus[0])
                {
                    
                    if (i != Sarasas.Count-2)
                    {
                        if (Sarasas[i + 1] == Panasus[1] && Sarasas[i + 2] == Panasus[2])
                        {
                            Console.WriteLine("Panasumas Rastas");
                        }
                        else
                            Console.WriteLine("Atitikmenu nerasta");
                    }
                    
                }
            }

            Console.ReadLine();


        }

        public void DNA()
        {
            //aaucg
            List<string> RNA = new List<string>();
            RNA.Add("A");
            RNA.Add("A");
            RNA.Add("U");
            RNA.Add("C");
            RNA.Add("G");

            // G = C
            // RNA A=U ir DNA A=T

            List<string> DNA = new List<string>();
            for (int i = 0; i < RNA.Count; i++)
            {
                if (RNA[i] == "A")
                {
                    DNA.Add("A-T");
                }
                else if(RNA[i] == "U")
                {
                    DNA.Add("T=A");
                }
                else if (RNA[i] == "C")
                {
                    DNA.Add("C=G");
                }
                else if (RNA[i] == "G")
                {
                    DNA.Add("G=C");
                }


            }

            foreach (var item in DNA)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public void simtasK()
        {
            Random rnd = new Random();
            List<int> simtasT = new List<int>();

            var Watch = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < 100000; i++)
            {
                simtasT.Add(rnd.Next(100000));
            }

            simtasT.Sort();

            Watch.Stop();
            var Laikas = Watch.ElapsedMilliseconds;
            Console.WriteLine("Uzpildymas ir rusiavimas kartu uztrunka {0} Ms", Laikas);
            Console.ReadLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Laisvalaikis L = new Laisvalaikis();
            L.simtasK();
        }
    }
}
