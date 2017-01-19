using System;

namespace Zoolandia.Animals
{
    
   public class Orangecat : Cat
    { 
        public Orangecat ()
        {
            this.Name = "Catewie";
        }
       public Orangecat (string myAnimalNoise)
       {
          this.Name = myAnimalNoise;
       }

       public Orangecat (string size, int age)
       {
           this.Size = size;
           this.Age = age;
       }

    }
}