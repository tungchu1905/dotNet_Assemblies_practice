using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Staff_Library
{
    public class Staff 
    {
        int id;
        string name;
        int age;
        int rate_Salary;
        int basic_Salary;

        public Staff()
        {
        }

        public Staff(int id, string name, int age, int rate_Salary, int basic_Salary)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Rate_Salary = rate_Salary;
            this.Basic_Salary = basic_Salary;

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public int Rate_Salary { get => rate_Salary; set => rate_Salary = value; }
        public int Basic_Salary { get => basic_Salary; set => basic_Salary = value; }

        public virtual int Calculate_Salary()
        {
            return Rate_Salary * Basic_Salary;
        }
        public virtual int Calculate_Salary(int Allowance )
        {
            return Rate_Salary * Basic_Salary +
                (Rate_Salary * Basic_Salary * Allowance) / 100;
        }
        public virtual void ShowInfor()
        {
            Console.WriteLine("ID: " + Id +
                "\nName: " + Name +
                "\nAge: " + Age +
                "\nTotalSalary: " + (Calculate_Salary()+ Calculate_Salary(Calculate_Salary())));
        }
    }
   
}
