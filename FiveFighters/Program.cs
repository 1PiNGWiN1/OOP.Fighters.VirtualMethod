﻿using System;
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

        private bool TargetSpecialAttack()
        {
            int dividerHealth = 2;

            if (Health <= Health / dividerHealth)
            {
                return true;
            }

            return false;
        }

        public override void SpecialAttack()
        {
            int _upDamage = 10;

            if (TargetSpecialAttack() == true)
            {
                Armor += Armor;
                Damage += _upDamage;
            }
        }
    }

    class Warrior : Fighter
    {
        public Warrior(string name = "Воин", int damage = 8, int health = 110, int armor = 5) : base(name, damage, health, armor)
        {
        }

        public override void SpecialAttack()
        {
            base.SpecialAttack();
        }
    }

    class Wizard : Fighter
    {
        public Wizard(string name = "Маг", int damage = 4, int health = 55, int armor = 0) : base(name, damage, health, armor)
        {
        }

        public override void SpecialAttack()
        {
            base.SpecialAttack();
        }
    }

    class Assasin : Fighter
    {
        public Assasin(string name = "Ассасин", int damage = 15, int health = 60, int armor = 2) : base(name, damage, health, armor)
        {
        }

        public override void SpecialAttack()
        {
            base.SpecialAttack();
        }
    }

    class Vampire:Fighter
    {
        public Vampire(string name = "Вампир", int damage = 7, int health = 80, int armor = 0) : base(name, damage, health, armor)
        {
        }

        public override void SpecialAttack()
        {
            base.SpecialAttack();
        }
    }
}
