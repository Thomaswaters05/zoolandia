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
        //overloaded constructor function(s) below
       public Cat (string newName)
        {
            this.name = newName;

        }
          public string CatNoise (int numOfMeows)
       {
           string noise = "";
           for (var i = 0; i < numOfMeows; i++)
           {
               noise += "MEOW!!";
           }
           return noise;
       }
         public override void Food()
        {
            Console.WriteLine("All cats eat cat food");
        }
    }
}