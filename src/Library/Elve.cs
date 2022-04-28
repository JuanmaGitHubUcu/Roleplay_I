
using System;
using System.Linq;

namespace Roleplay
{
    public class Elve
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }

        private int health = 80;

        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                if (value > 0)
                {
                    this.health = value;
                }
                else
                {
                    health = 0;
                }
            }
        }

        public Boots boots;
        
        public Bow bow;

        public Elve(string aName)
        {
            aName = name;
        }

        public void ChangeBow(Bow bow)
        {
            this.bow = bow;
        }

        public void RemoveBow(Bow bow)
        {
            this.bow = null;
        }

        public void ChangeBoots(Boots boots)
        {
            this.boots = boots;
        }

        public void RemoveBoots(Boots boots)
        {
            this.boots = null;
        }
        
        public int GetAttack(Bow bow)
        {
            return this.bow.AttackValue;
        }

        public void DamageReceived(int damage)
        {
            int totalDefense = this.bow.defenseValue + this.boots.DefenseValue;
            if( totalDefense < damage)
            {
                damage -= totalDefense;
                this.health -= damage;
            }
        }

        public void attack()
        {
        }

        public void Heal()
        {
            this.health = 80;
        }
    }
}