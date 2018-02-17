using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MonsterTemplate
    {
        protected string sMonsterName; // Name of the monster
        protected int iMosnterHealth; // Health of the monster
        protected int iMinimumDamage; // Minimum damage of player                                                                   // Rand(iMinimumDamage,iMaximumDamage);
        protected int iMaximumDamage; // Maximum damage of player
        protected int iMonsterDodgeValue; // Dodge value of player
        protected int iMonsterAccuracy; // Hit chance of player
        Random rRNGesus = new Random();
    }
}
