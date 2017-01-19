using System;

namespace Zoolandia.Animals
{
   
    public class Bird : Animal
    {
        //constructor function
        public Bird ()
        {
            this.Name = "Peter";

        }
       public string Noise()
       {
           return "Chirp!!";
       }
        public override void Food()
        {
            Console.WriteLine("By golly, this is overriding this! Birds like bird food");
        }
    }
}