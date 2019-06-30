using MonsterEngine.Models;
using System;

namespace MonsterEngine.Services
{
    class MonsterService
    {
        public static Monster GetMonster()
        {
            Monster monster = new Monster(Name.GetName(), 150, 200, 55, 45, 10, 30, "Hairy thing with fangs.", true);
            return monster;
        }

        public static Monster NextMonster(int PlayerLevel)
        {
            Random rand = new Random();
            int addPoints = rand.Next(10);
            int baseValue = PlayerLevel * 10;
            int maxLife = 90 + baseValue;
            int life = 50 + baseValue;
            int hitChance = 50 + baseValue - addPoints;
            int block = 50 + baseValue - addPoints;
            int minDamage = 20 + PlayerLevel;
            int maxDamage = (minDamage * 2) + addPoints;
            string description = DescriptionHelper.GenerateDescription();
            string name = Name.GetName();
            bool hasPowerfulNose = hitChance % 2 > 0 ? true : false;

            Monster nextMonster = new Monster(name, life, maxLife, hitChance, block, minDamage, maxDamage, description, hasPowerfulNose);

            return nextMonster;
        }
    }
}
