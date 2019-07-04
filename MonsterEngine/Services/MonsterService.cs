using MonsterEngine.Models;
using System;

namespace MonsterEngine.Services
{
    class MonsterService
    {

        /// <summary>
        /// Next monster.
        /// </summary>
        /// <param name="PlayerLevel">Int player level</param>
        /// <returns>Monster based on player's level.</returns>
        public static Monster GetMonster(int PlayerLevel)
        {
            Random rand = new Random();
            int addPoints = rand.Next(10);
            int baseValue = PlayerLevel * 10;
            int maxLife = 90 + baseValue;
            int life = 50 + baseValue - addPoints;
            int hitChance = (50 + (baseValue / 200)) - addPoints;
            int block = (50 + (baseValue / 200)) + addPoints;
            int minDamage = 20 + PlayerLevel + addPoints;
            int maxDamage = (minDamage * 2) + addPoints;
            string description = DescriptionHelper.GenerateDescription();
            string name = Name.GetName();
            bool hasPowerfulNose = hitChance % 3 == 0 ? true : false;

            Monster getMonster = new Monster(name, life, maxLife, hitChance, block, minDamage, maxDamage, description, hasPowerfulNose);

            return getMonster;
        }
    }
}
