using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyApp
{
    class Company
    {
        public string title;
        public string address;
        public string phone;
        public double income;
        public double expenses;


        public Company()
        {
            this.title = null;
            this.address = null;
            this.phone = null;
            this.income = 0;
            this.expenses = 0;
        }

        public Company(string title, string address, string phone, double income, double expenses)
        {
            this.title = title; this.address = address;
            this.phone = phone; this.income = income; this.expenses = expenses;
        }


        public Company(Company previousCompany)
        {
            title = previousCompany.title;
            address = previousCompany.address;
            phone = previousCompany.phone;
            income = previousCompany.income;
            expenses = previousCompany.expenses;
        }

        public void Outcome(Company company)
        {
                double outcome = 0;
                outcome = company.income - company.expenses;
                outcome = outcome / company.expenses;
                outcome = outcome * 100;
                outcome = Math.Round(outcome, 1);
            

                if (outcome < 100)
                {
                    Console.WriteLine($"With a profit margin of {outcome}%," +
                        $" {company.title} is not doing well.");
                }
                else if (outcome >= 100 && outcome <= 200)
                {
                    Console.WriteLine($"With a profit margin of {outcome}%," +
                        $" {company.title} is scraping by.");
                }
                else if (outcome > 200 && outcome < 300)
                {
                    Console.WriteLine($"With a profit margin of {outcome}%," +
                        $" {company.title} is doing reasonably well.");
                }
                else
                {
                    Console.WriteLine($"With a profit margin of {outcome}%," +
                        $" {company.title} is doing great!");
                }
        }

        public string displayInfo()
        {
            return $"Company name: {this.title}\n" +
                $"Address: {this.address}\nPhone number: {phone}\n" +
                $"Income: {income}\nExpenses: {expenses}\n";
        }
    }
}
