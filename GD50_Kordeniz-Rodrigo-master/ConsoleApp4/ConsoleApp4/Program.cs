using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int iDungeonLevel = 0;
            string sPlayerInput;
            int iPlayerInput;
            PlayerClassTemp Boi;
            sPlayerInput = Console.ReadLine();
            iPlayerInput = PlayerNumberCheck(0, 4, sPlayerInput);
            Random rMonsterSelected = new Random();
            sPlayerInput = Console.ReadLine();
            int iMonsterType;
            MonsterTemplate Monster;
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

            for (iDungeonLevel = 0; iDungeonLevel < 5; iDungeonLevel++)
            {
                iMonsterType = rMonsterSelected.Next(1, 4);

                if (iMonsterType == 1)
                {
                    Monster = new Goblin();
                    Console.WriteLine("A Gob Gob Boi Appears");
                }
                else if (iMonsterType == 2)
                {
                    Monster = new Elf();
                    Console.WriteLine("A Pointi Boi Appears");
                }
                else if (iMonsterType == 3)
                {
                    Console.WriteLine("A Fliyng Mice Boi Appears");
                    Monster = new Bat();
                }
                else
                {
                    Monster = new Goblin();
                }

                while (Monster.MonsterHealth > 0 && Boi.Health > 0)
                {
                    Boi.Health -= Monster.MonsterAttackTemp(Boi.Dodge);

                    if (Boi.Health > 0)
                    {
                        sPlayerInput = Console.ReadLine();
                        iPlayerInput = PlayerNumberCheck(0, 4, sPlayerInput);
                        Monster.MonsterHealth -= Boi.AttackTemp(iPlayerInput, Monster.Dodge);
                        Console.WriteLine(Monster.MonsterHealth);
                    }
                    else
                    { }

                }
                if (Boi.Health > 0)
                {
                    Console.WriteLine("Moving to Next Floor");
                    Thread.Sleep(250);
                    Console.Write(".");
                    Thread.Sleep(1500);
                    Console.Write(".");
                    Thread.Sleep(2000);
                    Console.Write(".");
                    Boi.Health += 25;
                }


            }










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
