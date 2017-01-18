using System;

namespace Zoolandia.Animals
{
    class Animal
    {
        public string name { get; set; }
         // Define simple properties for a Red Panda
       public string Color { get; set; }
       public string Species { get; set; }
       public string Age { get; set; }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }

        public virtual void Food ()
        {
            Console.WriteLine("All animals eat food");
        }

    }
}