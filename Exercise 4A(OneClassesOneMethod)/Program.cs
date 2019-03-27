using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4A_OneClassesOneMethod_
{
    class Horse
    {
        public string sound = "Hello I'm a horse, my name is Mr. Ed!!";
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
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
