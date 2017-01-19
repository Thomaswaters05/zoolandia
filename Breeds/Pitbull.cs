using System;

namespace Zoolandia.Animals
{
    
   public class Pitbull : Dog
    { 
        public Pitbull ()
        {
            this.Name = "Milli";
        }
       public Pitbull (string myAnimalNoise)
       {
          this.Name = myAnimalNoise;
       }

       public Pitbull (string size, int age)
       {
           this.Size = size;
           this.Age = age;
       }

    }
}