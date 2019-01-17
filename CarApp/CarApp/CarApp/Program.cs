using System;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars();
            Cars car2 = new Cars();

            do
            {
                Console.WriteLine(car1.AskData());
            } while (car1.speed <= 0 || car1.brand == null);
            
            string choice = null;


            do
            {
                choice = userInterface();

                switch (choice.ToUpper())
                {
                    case "Q":
                        do
                        {
                            Console.WriteLine(car2.AskData());
                        } while (car2.speed <= 0);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "W":
                        car1.ShowCarInfo();
                        if (car2.brand != null)
                        {
                            car2.ShowCarInfo();
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        
                    case "R":
                        if (car1.speed <= 0)
                        {
                            Console.WriteLine("\nCan't accelerate that, chief.\n");
                        }
                        
                        else
                        {
                            Console.WriteLine(car1.Accelerate());

                            if (car2.speed != 0 || car2.speed > 0)
                            {
                                Console.WriteLine(car2.Accelerate());
                            }
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "E":
                        if (car1.speed <= 0)
                        {
                            Console.WriteLine("\nCan't accelerate that, chief.\n");
                        }

                        else
                        {
                            Console.WriteLine(car1.Decelerate());
                            if (car2.speed != 0 || car2.speed > 0)
                            {
                                Console.WriteLine(car2.Decelerate());
                            }

                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (choice.ToUpper() != "F");



            string userInterface()
            {
                Console.WriteLine("\n[Q] Add another car");
                Console.WriteLine("[W] Show registered car(s)");
                Console.WriteLine("[E] Decelerate car(s)");
                Console.WriteLine("[R] Turbo boost car(s)");
                Console.WriteLine("[F] End program\n----------------------");
                return Console.ReadLine();
                
            }
        }
    }
}
