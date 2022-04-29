using System;

namespace Roleplay
{
    public class Sword
    {
        private int attackValue;

        public int AttackValue
        {
            get
            {
                return this.attackValue;
            }
            set
            {
                if (value > 0)
                {
                    this.attackValue = value;
                }
                else
                {
                    this.attackValue = 0;
                }
            }
        }

        private int defenseValue;

        public int DefenseValue
        {
            get
            {
                return this.defenseValue;
            }
            set
            {
                if (value > 0)
                {
                    this.defenseValue = value;
                }
                else
                {
                    this.defenseValue = 0;
                }
            }
        }

        public Sword(int attack, int defense)
        {   
            if (attack > 0)
                this.attackValue = attack;
            else
                this.attackValue = 0;
            
            if (defense > 0)
                this.defenseValue = defense;
            else
                this.defenseValue = 0;
        }
    }
}