using System;

namespace OOP_Demo
{
    interface IVegetable { }
    
     

    /*This class' modifier "abstract" is changing the class so that private information within it can be hidden.
     This information can still be used for method calling.*/
    abstract class Program : IVegetable 
    {
        
        static void carrot() { }
        static void carrot(int i) { }
        static void carrot(string str) { }

        static void Main(string[] args)
        {
            //carrot is able to have 3 values due to overloading which is a concept of polymorphism.
            //that means carrot can be a number or a dog even though it is actually a root vegetable.
            carrot(1);
            carrot("dog");
            carrot();
        }

        /*This is an example of inheritance
         The potato class inherits characteristics from class "Root".
         This inheritance allows potato to have to conform to the specifications of Root.*/
        class Potato : Root
        {

        }

        
        

        
    }
}
