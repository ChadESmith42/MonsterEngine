using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterEngine.Models
{
    public class Monster : Character
    {
        private int _minDamage;


        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public bool HasPowerfulNose { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }//end get
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : 1;
            }//end set
        }//end MinDamage property

        //Ctor
        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool hasPowerfulNose)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            HitChance = hitChance;
            Block = block;
            Description = description;
            HasPowerfulNose = hasPowerfulNose;
        }//end ctor;



        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }


    }//end Monster
}
