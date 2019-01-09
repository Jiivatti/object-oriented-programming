using System;

namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            Book Book1 = new Book("Bad Book", "Terribad Author", 15582, 72.50);
            Book Book2 = new Book("Kickass Book", "Me :----D", 99998, 89.90);
            Book Book3 = new Book("Beep Boop", "Mr.Roboto", 87602, 2.50);

            do
            {
                choice = userInterface();

                switch (choice.ToUpper())
                {
                    case "Q":
                        Book1.printInfo(); Book2.printInfo(); Book3.printInfo();
                        break;

                    case "W":
                        Console.WriteLine(Book1.compareInfo(Book2));
                        Console.WriteLine(Book1.compareInfo(Book3));
                        Console.WriteLine(Book2.compareInfo(Book1));
                        Console.WriteLine(Book2.compareInfo(Book3));
                        break;
                }
            } while (choice.ToUpper() != "F");

            string userInterface()
            {
                Console.WriteLine("\nPress [Q] for a list of all available books. ");
                Console.WriteLine("Press [W] to compare book prices. ");
                Console.WriteLine("Press [F] to quit the program. ");
                return Console.ReadLine();
            }
        }
    }
}
