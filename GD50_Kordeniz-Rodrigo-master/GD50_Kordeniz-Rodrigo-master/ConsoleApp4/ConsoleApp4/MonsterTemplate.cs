using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MonsterTemplate
    {
        public string sMonsterName; // Name of the monster
        public int iMonsterHealth; // Health of the monster
        protected int iMinimumDamage; // Minimum damage of player
        protected int iMaximumDamage; // Maximum damage of player
        protected int iMonsterDodgeValue; // Dodge value of player
        protected int iMonsterAccuracy; // Hit chance of player
        protected bool isDead;
        Random rRNGesus = new Random();// Rand(iMinimumDamage,iMaximumDamage);

        public int Dodge
        {
            get
            {
                return iMonsterDodgeValue;
            }

            set
            {
                iMonsterDodgeValue = value;
            }
        }

        public int MonsterHealth
        {
            get
            {
                return iMonsterHealth;
            }

            set
            {
                iMonsterHealth = value;
                if(iMonsterHealth>0)
                {
                    isDead = false;
                }
                else
                {
                    isDead = true;
                }
            }
        }

        public bool MonsterAttack(int PlayerDodge)
        {
            int iTempAttackRoll = 0;
            iTempAttackRoll = rRNGesus.Next(1, 21);
            iTempAttackRoll = +iMonsterAccuracy;

            if (iTempAttackRoll >= PlayerDodge)
            {
                Console.WriteLine("Bad boi hit you");
                return true;

            }

            else
            {
                Console.WriteLine("Bad boi missed! YEAH BOI");
                return false;

            }

        }
        public int MonsterDamage(bool MonsterAttack)
        {

            if (MonsterAttack)
            {
                return rRNGesus.Next(iMinimumDamage, ((iMaximumDamage + 1)));

            }

            else
            {
                Console.WriteLine("Missed");
                return 0;
            }

        
        }
        public int MonsterAttackTemp(int PlayerDodge)
        {
            bool isSuccess = MonsterAttack(PlayerDodge);
            return MonsterDamage(isSuccess);
        }

    }
    class Goblin : MonsterTemplate
    {
        public Goblin()
        {
            sMonsterName = "Gob Gob Boi";
            iMonsterHealth = 20;
            iMinimumDamage = 9;
            iMaximumDamage = 16;
            iMonsterDodgeValue = 4;
            iMonsterAccuracy = 7;
        }
    }
    class Elf : MonsterTemplate
    {
        public Elf()
        {
            sMonsterName = "Pointi Boi";
            iMonsterHealth = 30;
            iMinimumDamage = 11;
            iMaximumDamage = 20;
            iMonsterDodgeValue = 6;
            iMonsterAccuracy = 8;
        }
    }
    class Bat : MonsterTemplate
    {
        public Bat()
        {
            sMonsterName = "Fliyng Mice Boi";
            iMonsterHealth = 15;
            iMinimumDamage = 8;
            iMaximumDamage = 15;
            iMonsterDodgeValue = 7;
            iMonsterAccuracy = 9;
        }
    }
}
