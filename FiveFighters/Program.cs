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
            Druid druid = new Druid();
                        
            druid.ShowCharacters();

            Console.WriteLine();

            druid.SpecialAttack();            
            druid.ShowCharacters();
        }
    }

    abstract class Fighter
    {
        protected string Name;
        protected int Damage;
        protected int Health;
        protected int Armor;

        public Fighter(string name, int damage, int health, int armor)
        {
            Name = name;
            Damage = damage;
            Health = health;
            Armor = armor;
        }

        public void ShowCharacters()
        {
            Console.WriteLine($"Боец {Name}|" +
                $"Жизни: {Health} " +
                $"Броня: {Armor} " +
                $"Урон: {Damage}.");
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public virtual void SpecialAttack()
        {
            //"Ульта"
        }
    }

    class Druid : Fighter
    {
        public Druid(string name = "Друид", int damage = 10, int health = 75, int armor = 3) : base(name, damage, health, armor)
        {
        }

        //private bool TargetSpecialAttack()
        //{
        //    if (Health <=)
        //}

        public override void SpecialAttack()
        {
            Armor += Armor;
            Damage += 10;
        }
    }
}
