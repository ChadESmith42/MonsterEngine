using MonsterEngine.Models;
using System;

namespace MonsterEngine.Services
{
    class MonsterService
    {
        /// <summary>
        /// Gets a monster.
        /// </summary>
        /// <returns>Creates the first monster in the game.</returns>
        public static Monster GetMonster()
        {
            Monster monster = new Monster(Name.GetName(), 150, 200, 55, 45, 10, 30, "Hairy thing with fangs.", true);
            return monster;
        }

        /// <summary>
        /// Next monster.
        /// </summary>
        /// <param name="PlayerLevel">Int player level</param>
        /// <returns>Monster based on player's level.</returns>
        public static Monster NextMonster(int PlayerLevel)
        {
            Random rand = new Random();
            int addPoints = rand.Next(10);
            int baseValue = PlayerLevel * 10;
            int maxLife = 90 + baseValue;
            int life = 50 + baseValue - addPoints;
            int hitChance = (50 + baseValue) - addPoints;
            int block = (50 + baseValue) + addPoints;
            int minDamage = 20 + PlayerLevel + addPoints;
            int maxDamage = (minDamage * 2) + addPoints;
            string description = DescriptionHelper.GenerateDescription();
            string name = Name.GetName();
            bool hasPowerfulNose = hitChance % 2 > 0 ? true : false;

            Monster nextMonster = new Monster(name, life, maxLife, hitChance, block, minDamage, maxDamage, description, hasPowerfulNose);

            return nextMonster;
        }
    }
}
