using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Staff_Library;

namespace ConsoleManage
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff s = new Staff();
            ArrayList list = new ArrayList();
            Offical_Staff staff1 = new Offical_Staff();
            Console.WriteLine("---- Human Resource Management ----");
            Console.WriteLine("-----------------------\nInput Office staff: #1");
            Console.Write("ID: ");
            staff1.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            staff1.Name = Console.ReadLine();
            Console.Write("Age: ");
            staff1.Age = int.Parse(Console.ReadLine());
            Console.Write("Rate salary: ");
            staff1.Rate_Salary = int.Parse(Console.ReadLine());
            Console.Write("Basic salary: ");
            staff1.Basic_Salary = int.Parse(Console.ReadLine());
            Console.Write("Allowence: ");
            staff1.Calculate_Salary(int.Parse(Console.ReadLine()));
            Console.Write("Number non-working day: ");
            staff1.Number_NonWorkingDay = int.Parse(Console.ReadLine());
            Console.Write("Money decrease: ");
            staff1.Money_Decrease = int.Parse(Console.ReadLine());
            list.Add(staff1);
            //staff1.ShowInfor();
            Offical_Staff staff2 = new Offical_Staff();
            Console.WriteLine("--------------------------\nInput Office staff: #2");
            Console.Write("ID: ");
            staff2.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            staff2.Name = Console.ReadLine();
            Console.Write("Age: ");
            staff2.Age = int.Parse(Console.ReadLine());
            Console.Write("Rate salary: ");
            staff2.Rate_Salary = int.Parse(Console.ReadLine());
            Console.Write("Basic salary: ");
            staff2.Basic_Salary = int.Parse(Console.ReadLine());
            Console.Write("Allowence: ");
            staff2.Calculate_Salary(int.Parse(Console.ReadLine()));
            Console.Write("Number non-working day: ");
            staff2.Number_NonWorkingDay = int.Parse(Console.ReadLine());
            Console.Write("Money decrease: ");
            staff2.Money_Decrease = int.Parse(Console.ReadLine());
            list.Add(staff2);
            Console.WriteLine("------------------------------\nInformation of Office staff: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Offical_Staff)
                {
                    Offical_Staff o = (Offical_Staff)list[i];
                    o.ShowInfor();
                    Console.WriteLine("------------");
                }
            }



            Manage manage1 = new Manage();
            Console.WriteLine("----------------------------\nInput Manage: #1");
            Console.Write("ID: ");
            manage1.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            manage1.Name = Console.ReadLine();
            Console.Write("Age: ");
            manage1.Age = int.Parse(Console.ReadLine());
            Console.Write("Rate salary: ");
            manage1.Rate_Salary = int.Parse(Console.ReadLine());
            Console.Write("Basic salary: ");
            manage1.Basic_Salary = int.Parse(Console.ReadLine());
            Console.Write("Allowence: ");
            manage1.Calculate_Salary(int.Parse(Console.ReadLine()));
            Console.Write("Number Bussiness day: ");
            manage1.Number_BusinessDay = int.Parse(Console.ReadLine());
            Console.Write("Money increase: ");
            manage1.Money_Increase = int.Parse(Console.ReadLine());
            list.Add(manage1);

            Manage manage2 = new Manage();
            Console.WriteLine("--------------------------\nInput Manage: #2");
            Console.Write("ID: ");
            manage2.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            manage2.Name = Console.ReadLine();
            Console.Write("Age: ");
            manage2.Age = int.Parse(Console.ReadLine());
            Console.Write("Rate salary: ");
            manage2.Rate_Salary = int.Parse(Console.ReadLine());
            Console.Write("Basic salary: ");
            manage2.Basic_Salary = int.Parse(Console.ReadLine());
            Console.Write("Allowence: ");
            manage2.Calculate_Salary(int.Parse(Console.ReadLine()));
            Console.Write("Number Bussiness day: ");
            manage2.Number_BusinessDay = int.Parse(Console.ReadLine());
            Console.Write("Money increase: ");
            manage2.Money_Increase = int.Parse(Console.ReadLine());
            list.Add(manage2);

            Console.WriteLine("------------------------------------\nInformation of Manage: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Manage)
                {
                    Manage o = (Manage)list[i];
                    o.ShowInfor();
                    Console.WriteLine("------------");
                }
            }
        }
    }
}
