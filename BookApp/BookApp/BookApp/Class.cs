using System;
using System.Collections.Generic;
using System.Text;

namespace BookApp
{
    class Book
    {
        public string name;
        public string author;
        public int ID;
        public double price;

        public Book(string name, string author, int ID, double price)
        {
            this.name = name;
            this.author = author;
            this.ID = ID;
            this.price = price;
        }

        public void printInfo()
        {       Console.WriteLine($"Book name: {this.name} \n" +
                $"Author: {this.author} \n" +
                $"ID number: {this.ID} \n" +
                $"Price: {this.price} euro \n" +
                $"---------------------------------------- \n");

        }

        public string compareInfo(Book book)
        {
            if (this.price > book.price)
                return $"\n{this.name} ({this.price}e) is more expensive than {book.name} ({book.price}e). ";
            else if(this.price == book.price)
                return $"\nNo difference in price. ";
            else
                return $"\n{book.name} ({book.price}e) is more expensive than {this.name} ({this.price}e).";
        }
    }
}
