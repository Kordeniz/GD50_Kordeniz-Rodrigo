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
            bool isCombat = true;
            int iDungeonLevel = 0;
            string sPlayerInput;
            int iPlayerInput;
            PlayerClassTemp Boi;
            Goblin Goblin = new Goblin();

            sPlayerInput = Console.ReadLine();
            iPlayerInput = PlayerNumberCheck(0, 4, sPlayerInput);

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

            Console.WriteLine(Goblin.iMonsterHealth);
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
                    Console.WriteLine("MIT Education in It's Best");

                }

                else
                {
                    Console.WriteLine("What do they Teach you In MIT 'Close Quarters Crowbar Combat'? Please Try Again");
                    Input = Console.ReadLine();
                    IsSane = false;
                }

            } while (!IsSane);

            return Type;
        }

    }
}
