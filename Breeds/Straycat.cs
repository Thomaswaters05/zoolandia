using System;

namespace Zoolandia.Animals
{
    
   public class StrayCat : Cat
    { 
        public StrayCat ()
        {
            this.Name = "EwGrossYo";
        }
       public StrayCat (string myAnimalNoise)
       {
          this.Name = myAnimalNoise;
       }

       public StrayCat (string size, int age)
       {
           this.Size = size;
           this.Age = age;
       }

    }
}