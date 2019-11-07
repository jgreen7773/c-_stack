using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Person1 = new Human("Jamie");
            Human Person2 = new Human("Stimple", 2, 2, 2, 250);
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"{Person1.Name} has attacked {Person2.Name}, who now has {Person1.Attack(Person2)} health");
            Console.WriteLine($"Person 1: {Person1.Name}, {Person1.health}");
            Console.WriteLine($"Person 2: {Person2.Name}, {Person2.health}");
        }
    }

    class Human{
        public string Name{get;set;}
        public int Strength{get;set;}
        public int Intelligence{get;set;}
        public int Dexterity{get;set;}
        private int Health{get;set;}

        public int health{
            get { return Health; }
            set { Health = value; }
        }

        public Human(string name){
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity,int health){
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

// Now add a new method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter.
// The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker).
// This method should return the remaining health of the target object.

        public int Attack(Human target){
            target.Health -= (5 * target.Strength);
            return target.Health;
        }
    }
}
