using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{

  
    class Program
    {
        static void Main(string[] args)
        {
            //I created a farm in the Main() method.  I did not include my
            //animal classes.  I couldn't find a way create a messase for 
            //namespace that is missing.
            try
            {
                Animal dog = new Animal();
                dog.Speak();

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
            catch (System.Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}


