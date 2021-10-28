using System;
using System.Threading;

namespace ConsoleApp3
{
    public class Character
    {
        public string Name { get; set; }
        private int Hp { get; set; }
        private int Damage { get; set; }
        private int Kevlar { get; set; }

        public Character(string name, int hp, int damage, int kevlar)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
            Kevlar = kevlar;
        }

        public static bool Dead(Character person)
        {
            if (person.Hp == 0 || person.Hp < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool TheFight(Character person1, Character person2)
        {
            bool result = false;
            Random rand = new Random();
            int random;
            person1.Hp += person1.Kevlar;
            person2.Hp += person2.Kevlar;

            while (Dead(person1) != true || Dead(person2) != true)
            {
                random = rand.Next();

                if (random % 2 == 0)
                {
                    person1.Hp -= person2.Damage;
                }
                else
                {
                    person2.Hp -= person1.Damage;
                }

            }
            if (Dead(person1) == true)
            {
                result = true;
            }
            else if (Dead(person2) == true)
            {
                result = false;
            }
            return result;
        }
        public override string ToString()
        {
            return Name + ' ' + Hp + ' ' + Damage + ' ' + Kevlar;
        }
    }
}
