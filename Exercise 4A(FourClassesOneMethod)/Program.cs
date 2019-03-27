using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4A_FourClassesOneMethod_
{

    class Horse
    {
        public string sound = "Hello I'm a horse, my name is Mr. Ed!!";
        public void Speak()
        {
            Console.WriteLine($"Name {sound}");
        }
    }


    class Goat
    {
        public string sound = "Hello I'm a goat, my name is Corneilus, and I say Baaaa!!";
        public void Speak()
        {
            Console.WriteLine($"Name {sound}");
        }
    }

    class Pig
    {
        public string sound = "Hello, I'm a pig, I say Oink!!!";
        public void Speak()
        {
            Console.WriteLine($"Name {sound}");
        }
    }

    class Chicken
    {
        public string sound = "Hello I'm a chicken, my name is Cheating Tom Brady, cluck,cluck I paid the Refs off!!";
        public void Speak()
        {
            Console.WriteLine($"Name {sound}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Horse horse = new Horse();
                horse.Speak();
                Console.ReadKey();

                Goat goat = new Goat();
                goat.Speak();
                Console.ReadKey();

                Pig pig = new Pig();
                pig.Speak();
                Console.ReadKey();

                Chicken chicken = new Chicken();
                chicken.Speak();
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

