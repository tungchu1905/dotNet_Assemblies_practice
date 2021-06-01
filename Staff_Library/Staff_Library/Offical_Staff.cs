using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Staff_Library
{
    public class Offical_Staff : Staff
    {
        int number_NonWorkingDay;
        int money_Decrease;

        public Offical_Staff()
        {
        }
        public int Number_NonWorkingDay { get => number_NonWorkingDay; set => number_NonWorkingDay = value; }
        public int Money_Decrease { get => money_Decrease; set => money_Decrease = value; }
        public Offical_Staff(int id, string name, int age, int rate_Salary, int basic_Salary, int number_nonwork, int money_decrease) 
            : base(id, name, age, rate_Salary, basic_Salary) {
            Number_NonWorkingDay = number_nonwork;
            Money_Decrease = money_decrease;
        }
        public override int Calculate_Salary()
        {
            return base.Calculate_Salary() - (Number_NonWorkingDay*Money_Decrease);
        }

        public override int Calculate_Salary(int Allowance)
        {
            return base.Calculate_Salary(Allowance) - (Number_NonWorkingDay*Money_Decrease);
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
        }


    }
    public class Manage : Staff
    {
        int number_BusinessDay;
        int money_Increase;

        public Manage()
        {
        }
        public int Number_BusinessDay { get => number_BusinessDay; set => number_BusinessDay = value; }
        public int Money_Increase { get => money_Increase; set => money_Increase = value; }
        public Manage(int id, string name, int age, int rate_Salary, int basic_Salary, int number_business, int money_insc) 
            : base(id, name, age, rate_Salary, basic_Salary)
        {
            Number_BusinessDay = number_business;
            Money_Increase = money_insc;
        }

        public override int Calculate_Salary()
        {
            return base.Calculate_Salary() + (Number_BusinessDay*Money_Increase);
        }

        public override int Calculate_Salary(int Allowance)
        {
            return base.Calculate_Salary(Allowance) + (Money_Increase*Number_BusinessDay);
        }

        public override void ShowInfor()
        {
            base.ShowInfor();
        }
    }
}
