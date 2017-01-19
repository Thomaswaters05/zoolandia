using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
       public string Name { get; set; }
       public string Color { get; set; }
       public string Species { get; set; }
       public int Age { get; set; }
       public string Size { get; set; }
    
        public virtual void Sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }

        public virtual void Food ()
        {
            Console.WriteLine("All animals eat food");
        }

    }
}