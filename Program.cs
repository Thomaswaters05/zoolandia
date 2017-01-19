using System;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
     {
          public static void Main(string[] args)
          {
              //ZOOLANDIA 1
              Console.WriteLine("Zoolandia 1 Below:");
              Console.WriteLine("");

              var MyDog = new Dog(); 
              MyDog.Color = "white";
              MyDog.Species = "pitbull";
              MyDog.Age = 7;
              Console.WriteLine(MyDog.Noise());

              var MyCat = new Cat(); 
              MyCat.Color = "gray";
              MyCat.Species = "tabby";
              MyCat.Age = 8;
              Console.WriteLine(MyCat.CatNoise(2));

             var MyBird = new Bird(); 
              MyBird.Color = "yellow";
              MyBird.Species = "toucan";
              MyBird.Age = 9;
              Console.WriteLine(MyBird.Noise());
              
              Console.WriteLine($"I have a Dog that is {MyDog.Color} and is a {MyDog.Species}. It is a {MyBird.Age}.");
              
              Console.WriteLine("");
              Console.WriteLine("Zoolandia 2 Below:");

              //ZOOLANDIA 2
              MyBird.Food(); //you do not do console.write bc you used that in your animal object
              MyCat.Food();  //this will return what is in our cat virtual void
              MyDog.Food(); //you arent overriding so it will return the default animal food()

              //constructor method below
              var MyCatsName = new Cat();
              Console.WriteLine($"My cats name is {MyCat.Name}.");
              var MyDogsName = new Dog();
              Console.WriteLine($"My dogs name is {MyDogsName.Name}.");
              var MyBirdsName = new Bird();
              Console.WriteLine($"My birds name is {MyBirdsName.Name}.");
              

              Console.WriteLine("");
              Console.WriteLine("Zoolandia 3 Below:");

              //ZOOLANDIA 3
              //overloaded constructor method below
              var MyOverloadCat = new Cat("Gordon");
              Console.WriteLine(MyOverloadCat.Name);
            
             
              Console.WriteLine(MyCat.CatNoise(2));


              Console.WriteLine("");
              Console.WriteLine("Zoolandia 4 Below:");
              //ZOOLANDIA 4
              //overloaded constructor methods with total zoo below

              var Foxi = new Corgi("GROWL!");
              Console.WriteLine(Foxi.Name);

              var DogSizeAge = new Corgi("small ",  5);
              Console.WriteLine(DogSizeAge.Name);
              Console.WriteLine(DogSizeAge.Size + DogSizeAge.Age);
              
              var CatSizeAge = new Orangecat("small ",  7);
              Console.WriteLine(CatSizeAge.Name);
              Console.WriteLine(CatSizeAge.Size + CatSizeAge.Age);
  

              var BirdSizeAge = new Toucan("small ",  9);
              Console.WriteLine(BirdSizeAge.Name);
              Console.WriteLine($"My bird is {BirdSizeAge.Size}and {BirdSizeAge.Age} years old.");


              Console.WriteLine("");
              Console.WriteLine("Zoolandia 5-6 Below:");
              //ZOOLANDIA 4
              //overloaded constructor methods with total zoo below
             var FinalAnimal = new Corgi();
             FinalAnimal.Eats();

          }
     }
 }