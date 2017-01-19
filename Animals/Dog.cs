using System;

namespace Zoolandia.Animals
{
    
    public class Dog : Animal
    { 
        //constructor function
         public Dog ()
        {
            this.Name = "Lois";

        }
       public string Noise()
       {
           return "RUFF!!";
       }
    }
}