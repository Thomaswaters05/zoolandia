using System;

namespace Zoolandia.Animals
{
    class Cat : Animal
    {
        //constructor function
        public Cat ()
        {
            this.name = "Stewie";

        }
       public string Noise()
       {
           return "Meow!!";
       }
         public override void Food()
        {
            Console.WriteLine("All cats eat cat food");
        }
    }
}