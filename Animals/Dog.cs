using System;

namespace Zoolandia.Animals
{
    
    class Dog : Animal
    {
        // Define simple properties for a Red Panda
       public string Color { get; set; }
       public string Species { get; set; }
       public string Age { get; set; }

       public string Noise()
       {
           return "RUFF!!";
       }
    }
}