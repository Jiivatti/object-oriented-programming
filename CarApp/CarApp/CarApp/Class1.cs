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
                $"\nCar brand: {this.brand}\nSpeed: {this.speed}kmph\n");
        }

        public string AskData()
        {
                Console.WriteLine("\nInsert car brand: ");
                this.brand = Console.ReadLine();
                Console.WriteLine("\nInsert car speed: ");
                string speedValue = Console.ReadLine();

                if (speedValue.Length > 0) //(!string.IsNullOrEmpty(speedValue))
                {
                    this.speed = int.Parse(speedValue);
                    return $"\nYour car brand is set as {this.brand}.\n" +
                    $"Your speed is set as {this.speed}.\n";
                }
                    else
                    {
                        this.speed = 0;
                        return $"Please set the brand and speed.";
                    }

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
