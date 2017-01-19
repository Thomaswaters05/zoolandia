using System;

namespace Zoolandia.Animals
{
    
   public class Toucan : Bird
    { 
        public Toucan ()
        {
            this.Name = "Sam";
        }
       public Toucan (string myAnimalNoise)
       {
          this.Name = myAnimalNoise;
       }

       public Toucan (string size, int age)
       {
           this.Size = size;
           this.Age = age;
       }

    }
}

