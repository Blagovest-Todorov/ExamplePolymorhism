using System;

namespace _16.OopPolymorhismExample
{
    class Program  //  polymorphism allows us the reusability of the code! 
    {
        static void Main(string[] args)
        {

            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();


            myAnimal.AnimalSound();
            myPig.AnimalSound();   //polymorphyism --child method replaces the parent method implementation.
            myDog.AnimalSound();


        }
    }
    class Animal // Base Parent class
    {
        public virtual void AnimalSound()  //virtual keyword -access modifier 
                                           // virtual-allows access and modifies the parent method to be overriden into the child class
        {
            Console.WriteLine("The animal makes a sound! ");
        }
    }

    class Dog : Animal //derived class
    {
        public override void AnimalSound()  // overiding method, replaces the method from the paren class
        {
            Console.WriteLine("the dog is bow-wow ! ");
        }
    }

    class Pig : Animal  // derived class
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Pig is squeeking ! ");
        }
    }



}
