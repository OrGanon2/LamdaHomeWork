using System;

namespace LamdaHomeWork
{
    public delegate void MyFirstDelegate();
    public delegate void Greet(string Name);
    class Program
    {
      
        
    
     
        static void Main(string[] args)
        {
            Greet Hello = (string Name) => { Console.WriteLine($"welcome{Name}"); };
            Hello("Bennet");
            MyFirstDelegate Shalom = () => { Console.WriteLine("Shalom"); };
            Shalom();
            Greet Shalom2 = (string Name) => { Console.WriteLine($"Shalom{Name}"); };
            Shalom2("Efraim");

            MyFirstDelegate Print2 = () => { Console.WriteLine("Another Function Called With same Delegate"); } ;
             Print2();

            MyFirstDelegate Moshe = delegate () { };


            Dele Add = (int a, int b) => {return a + b; };
            Dele Sub = (int a, int b) => { return a - b; };
            Console.WriteLine(Add(5, 3));
            Console.WriteLine(Sub(5, 2));

        }
    }
}
