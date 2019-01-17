using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpCls[] employees = new EmpCls[3];

            employees[0] = new EmpCls("Goon Underling", 215552, "Worker Bee", 1000);
            employees[1] = new EmpCls("Guy", 101052, "Mystery", 5000);
            employees[2] = new EmpCls("Billy Bawb", 599092, "The coffee guy", 8000);

            
            string choice = null;
            string choice2 = null;
            
            do
            {
                choice = UI();
                switch (choice.ToUpper())
                {
                    case "Q":
                        employees[0].PrintInfo(employees);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "W":
                        choice2 = UI2();
                        do
                        {
                            switch (choice2.ToUpper())
                            {
                                case "Q":
                                    Console.WriteLine(employees[0].CompareSal(employees[0], employees[1]));
                                    Console.ReadKey();
                                    Console.Clear();
                                    choice2 = "F";
                                    break;

                                case "W":
                                    Console.WriteLine(employees[0].CompareSal(employees[0], employees[2]));
                                    Console.ReadKey();
                                    Console.Clear();
                                    choice2 = "F";
                                    break;

                                case "E":
                                    Console.WriteLine(employees[0].CompareSal(employees[1], employees[2]));
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
                Console.WriteLine("[Q] -- List of all employees");
                Console.WriteLine("[W] -- Compare salaries\n");
                Console.WriteLine("[F] -- Close program\n");

                return Console.ReadLine();
            }
            string UI2()
            {
                Console.Clear();
                Console.WriteLine($"[Q] -- {employees[0].name} to {employees[1].name}");
                Console.WriteLine($"[W] -- {employees[0].name} to {employees[2].name}");
                Console.WriteLine($"[E] -- {employees[1].name} to {employees[2].name}\n");
                Console.WriteLine($"[F] -- Return to previous screen\n");

                return Console.ReadLine();
            }
        }
    }
}
