using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace EmployeeApp
{
    public class EmpCls
    {
        public string name;
        public float id;
        public string pos;
        public double sal;

        public EmpCls()
        {
            this.name = null;
            this.id = 0;
            this.pos = null;
            this.sal = 0;
        }

        public EmpCls(string name, float id, string pos, double sal)
        {
            this.name = name;
            this.id = id;
            this.pos = pos;
            this.sal = sal;
        }

        public void PrintInfo(EmpCls[] emp)
        {
            foreach (EmpCls i in emp)
            {
                Console.WriteLine($"\nEmployee name: {i.name}\nEmployee ID: {i.id}" +
                    $"\nMonthly salary: {i.sal}$\nPosition in company: {i.pos}\n");
            }
        }

        public string CompareSal(EmpCls emp, EmpCls emp2)
        {
            if (emp.sal > emp2.sal)
            {
                return $"\nEmployee {emp.name} has the higher salary of {emp.sal}$" +
                    $"\nEmployee {emp2.name} has the lower salary of {emp2.sal}$";
            }
            else
            {
                return $"\nEmployee {emp2.name} has the higher salary of {emp2.sal}$" +
                    $"\nEmployee {emp.name} has the lower salary of {emp.sal}$";
            }
        }
        

        
    }
}
