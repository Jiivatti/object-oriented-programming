using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    class Cars
    {
        public string brand;
        public double speed;


        public Cars()
        {
            this.brand = null;
            this.speed = 0;
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"---------------------" +
                $"\nCar brand: {this.brand}\nTop speed: {this.speed}kmph\n");
        }

        public string AskData()
        {
            Console.WriteLine("\nInsert car brand: ");
            this.brand = Console.ReadLine();
            Console.WriteLine("\nInsert car speed: ");
            this.speed = int.Parse(Console.ReadLine());
            return $"\nYour car brand is now {this.brand}, and it's top speed is {this.speed}kmph\n---------------------";
        }

        public string Accelerate()
        {
            this.speed = this.speed * 1.1;
            this.speed = Math.Round(this.speed, 1);
            return $"\nTurbo boosted {this.brand}'s speed to {this.speed}kmph\n";
        }

        public string Decelerate()
        {
            this.speed = this.speed * 0.90;
            this.speed = Math.Round(this.speed, 1);
            return $"\nDecelerated {this.brand}'s speed to {this.speed}kmph\n";
        }
    }
}
