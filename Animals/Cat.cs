using System;

namespace Zoolandia.Animals
{
    
    class Cat : Animal
    {
        // Define simple properties for a Red Panda
       public string Color { get; set; }
       public string Species { get; set; }
       public string Age { get; set; }

       public string Noise()
       {
           return "Meow!!";
       }
    }
}