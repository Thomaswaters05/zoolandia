using System;

namespace Zoolandia.Animals
{
    
    class Dog : Animal
    { 
        //constructor function
         public Dog ()
        {
            this.name = "Lois";

        }
       public string Noise()
       {
           return "RUFF!!";
       }
    }
}