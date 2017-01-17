using System;
using Zoolandia.Animals;

 namespace Zoolandia
 {
     public class Program
     {
          public static void Main(string[] args)
          {
              var MyDog = new Dog(); 
              MyDog.Color = "white";
              MyDog.Species = "pitbull";
              MyDog.Age = "old";
              Console.WriteLine(MyDog.Noise());

              var MyCat = new Cat(); 
              MyCat.Color = "gray";
              MyCat.Species = "tabby";
              MyCat.Age = "young";
              Console.WriteLine(MyCat.Noise());

             var MyBird = new Bird(); 
              MyBird.Color = "yellow";
              MyBird.Species = "toucan";
              MyBird.Age = "young";
              Console.WriteLine(MyBird.Noise());

              Console.WriteLine($"I have a Dog that is {MyDog.Color} and is a {MyDog.Species}. It is a {MyBird.Age}.");
          }
     }
 }