using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to boigeon!\nhere you take control of a good boi and you must face all evil bois");
            bool isCombat = true;
            int iDungeonLevel = 0;
            string sPlayerInput;
            int iPlayerInput;
            PlayerClassTemp Boi;
            Goblin Goblin = new Goblin();
            Console.WriteLine("Please, select your class\n1 for Fat Boi,\n2 for Stabby Boi,\n3 for Wise Boi.");
            sPlayerInput = Console.ReadLine();
            iPlayerInput = PlayerNumberCheck(0, 4, sPlayerInput);
            Console.WriteLine("Please name your Boi");
            sPlayerInput = Console.ReadLine();

            //Charater Creation
            switch (iPlayerInput)
            {
                case 1:
                    {
                        Boi = new Fat_Boi(sPlayerInput);
                        break;
                    }
                case 2:
                    {
                        Boi = new Stabby_Boi(sPlayerInput);
                        break;
                    }
                case 3:
                    {
                        Boi = new Wise_Boi(sPlayerInput);
                        break;
                    }
                default:
                    {
                        Boi = new Wise_Boi(sPlayerInput);
                        break;
                    }
            }

            Console.WriteLine("You are now a Boi named {0}, go get them!", sPlayerInput);
            Console.WriteLine("Monster's remaining health");
            Console.WriteLine(Goblin.iMonsterHealth);
            Console.WriteLine("Select Attack:\n1 for normal Attack,\n2 for Special Attack,\n3 for Special Attack 2");
            sPlayerInput = Console.ReadLine();
            iPlayerInput = PlayerNumberCheck(0, 4, sPlayerInput);
            Goblin.iMonsterHealth -= Boi.AttackTemp(iPlayerInput, Goblin.Dodge);

            Console.WriteLine(Goblin.iMonsterHealth);
            Console.ReadLine();
        }

        static int PlayerNumberCheck(int Min, int Max, String Input)
        {
            int Type;
            bool IsSane;
            do
            {
                IsSane = Int32.TryParse(Input, out Type);
                if (IsSane && Type > Min && Type < Max)
                {
                    Console.WriteLine("Nicely done M'Boi");
                }

                else
                {
                    Console.WriteLine("My BOI, type it correctly this time :3");
                    Input = Console.ReadLine();
                    IsSane = false;
                }

            } while (!IsSane);

            return Type;
        }


    }
}
