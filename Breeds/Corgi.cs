using System;

namespace Zoolandia.Animals
{
    
   public class Corgi : Dog
    { 
        public Corgi ()
        {
            this.Name = "Foxi";
        }
       public Corgi (string myAnimalNoise)
       {
          this.Name = myAnimalNoise;
       }

       public Corgi (string size, int age)
       {
           this.Size = size;
           this.Age = age;
       }

    }
}

       
       