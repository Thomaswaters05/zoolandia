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
              
              Console.WriteLine("");
              Console.WriteLine("Zoolandia 2 Below:");

              //ZOOLANDIA 2
              MyBird.Food(); //you do not do console.write bc you used that in your animal object
              MyCat.Food();  //this will return what is in our cat virtual void
              MyDog.Food(); //you arent overriding so it will return the default animal food()

              //constructor examples below
              var MyCatsName = new Cat();
              Console.WriteLine($"My cats name is {MyCat.name}.");
              var MyDogsName = new Dog();
              Console.WriteLine($"My dogs name is {MyDogsName.name}.");
              var MyBirdsName = new Bird();
              Console.WriteLine($"My birds name is {MyBirdsName.name}.");
              
          }
     }
 }