using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FiveFighters
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Fighter
    {
        protected string _name;
        protected int _damage;
        protected int _health;
        protected int _armor;

        public Fighter(string name, int damage, int health, int armor)
        {
            _name = name;
            _damage = damage;
            _health = health;
            _armor = armor;
        }

        public void ShowCharacters ()
        {
            Console.WriteLine($"Боец {_name}|" +
                $"Жизни: {_health}" +
                $"Броня: {_armor}" +
                $"Урон: {_damage}.");
        }

        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
        }

        public virtual void SpecialAttack()
        {
            //"Ульта"
        }
    }
}
