using System;

namespace Zoolandia.Animals
{
    
   public class Parakeet : Bird
    { 
        public Parakeet ()
        {
            this.Name = "Gus";
        }
       public Parakeet (string myAnimalNoise)
       {
          this.Name = myAnimalNoise;
       }

       public Parakeet (string size, int age)
       {
           this.Size = size;
           this.Age = age;
       }

    }
}