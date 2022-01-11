using System;

namespace Basiclearning; 
    internal class Program
    {
        static void Main(string[] args)
        {
            int A , B;
            Console.WriteLine("please enter the Number1");  
            A = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("please enter the Number2");  
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("Ad");
            Console.WriteLine("Sub");
            Console.WriteLine("Mul");
            Console.WriteLine("Div");
            Console.Write("Your option? ");  
            switch (Console.ReadLine())
    {
            case "Ad":
                Console.WriteLine($"Your result: {A} + {B} = " + (A + B));
                break;
            case "Sub":
                Console.WriteLine($"Your result: {A} - {B} = " + (A-B));
                break;
            case "Mul":
                Console.WriteLine($"Your result: {A} * {B} = " + (A * B));
                break;
            case "Div":
                Console.WriteLine($"Your result: {A} / {B} = " + (A /B));
                break;
    }   
        }
    }
