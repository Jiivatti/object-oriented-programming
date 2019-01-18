using System;

namespace CompanyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = null;
            string choice2 = null;
            Company company1 = new Company("Snoy", "Moon Avenue 54, 99952 Luna", "+554124635", 1226000, 248000);
            Company company2 = new Company("Microshil", "Shimmyshammy Road 1, Imaginationland",
                "+8616608621", 22800, 9500);
            Company company3 = new Company("Nintentodd","Akihabaramichi 553, 5523 Tokyo",
                "+995571250", 150200, 47900);
            Company company4 = new Company("Ouya", "Scam Street 21, ???? Incognito", "+124456270" , 14800, 11000);
            Company company5 = new Company(null, null, null, 0, 0);
            

            do
            {
                choice = UI();
                switch (choice.ToUpper())
                {
                    case "Q":
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine(company1.displayInfo());
                        Console.WriteLine(company2.displayInfo());
                        Console.WriteLine(company3.displayInfo());
                        Console.WriteLine(company4.displayInfo());
                        if (company5.title != null)
                        {
                            Console.WriteLine(company5.displayInfo());
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "W":
                        Console.WriteLine("--------------------------------");
                        company1.Outcome(company1);
                        company2.Outcome(company2);
                        company3.Outcome(company3);
                        company4.Outcome(company4);
                        if (company5.title != null)
                        {
                            company5.Outcome(company5);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "E":
                        Console.Clear();
                        choice2 = UI2();
                        do
                        {
                            switch (choice2.ToUpper())
                            {
                                case "Q":
                                    company5 = new Company(company1);
                                    Console.WriteLine($"Company {company5.title} was copied.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    choice2 = "F";
                                    break;
                                case "W":
                                    company5 = new Company(company2);
                                    Console.WriteLine($"Company {company5.title} was copied.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    choice2 = "F";
                                    break;
                                case "E":
                                    company5 = new Company(company3);
                                    Console.WriteLine($"Company {company5.title} was copied.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    choice2 = "F";
                                    break;
                                case "R":
                                    company5 = new Company(company4);
                                    Console.WriteLine($"Company {company5.title} was copied.");
                                    Console.ReadKey();
                                    Console.Clear();
                                    choice2 = "F";
                                    break;
                            }

                        } while (choice2.ToUpper() != "F");

                        
                        break;
                }



            } while (choice.ToUpper() != "F");
            
            string UI()
            {
                Console.WriteLine("[Q] -- List all companies");
                Console.WriteLine("[W] -- List profit margins");
                Console.WriteLine("[E] -- Copy existing data");
                Console.WriteLine("[F] -- Close program");
                Console.WriteLine("--------------------------------");
                return Console.ReadLine();
            }
            string UI2()
            {
                Console.WriteLine($"[Q] -- Copy {company1.title}");
                Console.WriteLine($"[W] -- Copy {company2.title}");
                Console.WriteLine($"[E] -- Copy {company3.title}");
                Console.WriteLine($"[R] -- Copy {company4.title}");
                Console.WriteLine("[F] -- Return to previous screen");
                Console.WriteLine("--------------------------------");
                return Console.ReadLine();
            }

        }
    }
}
