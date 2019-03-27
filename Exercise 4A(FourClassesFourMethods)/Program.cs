using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4A_FourClassesFourMethods_
{
    // I created a class for a Horse, Goat, Pig and a Chicken.  All the different animials have 
    //four methods.  
    class Horse
    {
        public string sound = "Hello I'm a horse, my name is Mr. Ed!!";
        public void Speak()
        {
            Console.WriteLine($"{sound}");
        }

        public string transporation = "I move with four legs";
        public void Move()
        {
            Console.WriteLine($"{transporation}");
        }

        public string product = "I can give you a ride across the field";
        public void Action()
        {
            Console.WriteLine($"{product}");
        }

        public string food = "I like to eat hay!";
        public void Eat()
        {
            Console.WriteLine($"{food}");
            Console.WriteLine();
        }
    }


    class Goat
    {
        public string sound = "Hello I'm a goat, my name is Corneilus, and I say Baaaa!!";
        public void Speak()
        {
            Console.WriteLine($"{sound}");
        }
        public string transporation = "I like to climb on things";
        public void Move()
        {
            Console.WriteLine($"{transporation}");
        }

        public string product = "You can cook me up, and put me in a Gyro";
        public void Action()
        {
            Console.WriteLine($"{product}");
        }

        public string food = "I like to eat grass and old shoes.";
        public void Eat()
        {
            Console.WriteLine($"{food}");
            Console.WriteLine();
        }
    }

    class Pig
    {
        public string sound = "Hello, I'm a pig, I say Oink!!!";
        public void Speak()
        {
            Console.WriteLine($"{sound}");
        }
        public string transporation = "I like to roll around in the mud.";
        public void Move()
        {
            Console.WriteLine($"{transporation}");
        }

        public string product = "You can turn me into bacon.";
        public void Action()
        {
            Console.WriteLine($"{product}");
        }

        public string food = "I like to eat slop and soggy bread.";
        public void Eat()
        {
            Console.WriteLine($"{food}");
            Console.WriteLine();
        }
    }

    class Chicken
    {
        public string sound = "Hello I'm a chicken, my name is Cheating Tom Brady, cluck,cluck I paid the Refs off!!";
        public void Speak()
        {
            Console.WriteLine($"{sound}");
        }
        public string transporation = "I'm stuck in a cage most of the day";
        public void Move()
        {
            Console.WriteLine($"{transporation}");
        }

        public string product = "You can turn me into a sandwich.";
        public void Action()
        {
            Console.WriteLine($"{product}");
        }

        public string food = "I like to eat bird feed.";
        public void Eat()
        {
            Console.WriteLine($"{food}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        //I created four classes of animals that each have four methods.
            try
            {
                Horse horse = new Horse();
                horse.Speak();
                horse.Move();
                horse.Action();
                horse.Eat();
                Console.ReadKey();

                Goat goat = new Goat();
                goat.Speak();
                goat.Move();
                goat.Action();
                goat.Eat();
                Console.ReadKey();

                Pig pig = new Pig();
                pig.Speak();
                pig.Move();
                pig.Action();
                pig.Eat();
                Console.ReadKey();

                Chicken chicken = new Chicken();
                chicken.Speak();
                chicken.Move();
                chicken.Action();
                chicken.Eat();
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
