using System;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars();
            Cars car2 = new Cars();
            Console.WriteLine(car1.AskData());
            string choice = null;


            do
            {
                choice = userInterface();

                switch (choice.ToUpper())
                {
                    case "Q":
                        Console.WriteLine(car2.AskData());
                        break;

                    case "W":
                        car1.ShowCarInfo();
                        if (car2.brand != null)
                        {
                            car2.ShowCarInfo();
                        } else break;
                        break;

                    case "R":
                        Console.WriteLine(car1.Accelerate());
                        if (car2.speed != 0)
                        {
                            Console.WriteLine(car2.Accelerate());
                        } else break;
                        break;

                    case "E":
                        Console.WriteLine(car1.Decelerate());
                        if (car2.speed != 0)
                        {
                            Console.WriteLine(car2.Decelerate());
                        } else break;
                        break;
                }
            } while (choice.ToUpper() != "F");



            string userInterface()
            {
                Console.WriteLine("[Q] Add another car");
                Console.WriteLine("[W] Show registered cars");
                Console.WriteLine("[E] Decelerate car(s)");
                Console.WriteLine("[R] Turbo boost car(s)");
                Console.WriteLine("[F] End program");
                return Console.ReadLine();
            }
        }
    }
}
