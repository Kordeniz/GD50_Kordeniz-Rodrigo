using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PlayerClassTemp
    {

        protected string sCharacterName; // Name of the character
        protected int iCharacterHealth; // Health of the character
        protected int iCharacterMaxHealth; // Max Health;
        protected int iMinimumDamage; // Minimum damage of player                                                                   
        protected int iMaximumDamage; // Maximum damage of player
        protected int iPlayerDodgeValue; // Dodge value of player
        protected int iPlayerAccuracy; // Hit chance of player
        protected Random rRNGesus = new Random(); // Rand(iMinimumDamage,iMaximumDamage);
        protected int iExperiance;
        protected int iLevel;

        public string Name
        {
            get
            {
                return sCharacterName;
            }

            set
            {
                sCharacterName = value;

                if (sCharacterName.Length == 0 || sCharacterName == null)
                {
                    sCharacterName = "Sir Montgomery Alexander Massachusetts Maximilian Finnegan Rasuuuuumus Hård";
                }
            }
        }

        public int Health
        {
            get
            {
                return iCharacterHealth;
            }

            set
            {
                iCharacterHealth = value;

                if (iCharacterHealth <= 0)
                {
                    iCharacterHealth = 0;
                    //Call death function
                }

                else if (iCharacterHealth > iCharacterMaxHealth)
                {
                    iCharacterHealth = iCharacterMaxHealth;
                    Console.WriteLine("You reached max health");
                }


            }
        }

        public int Level
        {
            get
            {
                return iLevel;
            }
            set
            {
                if(iExperiance>iLevel*1000)
                {
                    iLevel++;
                    iExperiance -= 1000;
                }

                else
                {

                }
                
            }
        }

        public bool PlayerAttack(int EnemyDodge)
        {
            int iTempAttackRoll = 0;
            iTempAttackRoll = rRNGesus.Next(1, 21);
            iTempAttackRoll = +iPlayerAccuracy;

            if (iTempAttackRoll >= EnemyDodge)
            {
                Console.WriteLine("Get it Ma Boi");
                return true;
                
            }

            else
            {
                Console.WriteLine("Better Luck Next Time Ma Boi");
                return false;

            }

        }

        public int PlayerDamage(bool PlayerAttack)
        {

            if (PlayerAttack)
            {
                return rRNGesus.Next(iMinimumDamage, ((iMaximumDamage + 1)));

            }

            else
            {
                return 0;
                Console.WriteLine("Missed");
            }
        }

        public bool PlayerDodge(int EnemyAttack)
        {
            int iTempDefendRoll = 0;
            iTempDefendRoll = rRNGesus.Next(1, 21);
            iTempDefendRoll =+ iPlayerDodgeValue;

            if (iTempDefendRoll >= EnemyAttack)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void PlayerTakesDamage(bool PlayerDodge, int EnemyDamage)
        {
            if (PlayerDodge)
            {
                Console.WriteLine("Dodged");

            }

            else
            {
                Health -= EnemyDamage;
                Console.WriteLine("Taken {0} Damage", EnemyDamage);
            }
        }

        public virtual int SpecialAttack()
        {
            return 0;
        }

        public virtual int SpecicalAttack_2()
        {
            return 0;
        }

        

    }

    class Fat_Boi : PlayerClassTemp
    {
        public Fat_Boi(string InputName)
        {
            iCharacterHealth = 100;
            iCharacterMaxHealth = 100;
            iMinimumDamage = 10;
            iMaximumDamage = 16;
            iPlayerDodgeValue = 5;
            iPlayerAccuracy = 6;
            iLevel = 1;
           
        }

        public override int SpecialAttack()
        {
            Console.WriteLine("Fat Boi Special Smash!!!!!");
            return (Health / 5);
        }

        public override int SpecicalAttack_2()
        {
            Console.WriteLine("Fat Boi Ultimate Attack");
            return iMaximumDamage;
        }


    }

    class Stabby_Boi : PlayerClassTemp
    {
        public Stabby_Boi(string InputName)
        {
            iCharacterHealth = 50;
            iCharacterMaxHealth = 50;
            iMinimumDamage = 13;
            iMaximumDamage = 22;
            iPlayerDodgeValue = 10;
            iPlayerAccuracy = 11;
            iLevel = 1;
        }

        public override int SpecialAttack()
        {
            int iTempCrit = 0;
            iTempCrit = rRNGesus.Next(1, 7);
            
            if(iTempCrit>4)
            {
                return Convert.ToInt32(iMaximumDamage * 2.5);
            }

            else
            {
                return 0;
            }
        }

        public override int SpecicalAttack_2()
        {
            return iPlayerDodgeValue+ iPlayerAccuracy;
        }


    }
}
