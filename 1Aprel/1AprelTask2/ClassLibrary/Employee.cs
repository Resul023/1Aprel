using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Employee : Person
    {
        private int _salaryOfHour;
        private int _workingHour;
        public int SalaryOfHour
        {
            get
            {
                return this._salaryOfHour;
            }


            set
            {
                this._salaryOfHour = value;
            }

        }
        public int WorkingHour
        {
            get
            {
                return this._workingHour;
            }
            set
            {
                this._workingHour = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public string SurName
        {
            get
            {
                return this._surName;
            }
            set
            {
                this._surName = value;
            }
        }

       
        public void CalculateSalary()
        {
            int result = 0;
            result = this._workingHour * this._salaryOfHour;
            if ( _age>=18 )
            {
                if (result > 250)
                {
                    Console.WriteLine($"This salary {result} is match with your limit");
                }
                else
                {
                    Console.WriteLine("This salary is not enough");
                }
            }
            else
            {
                Console.WriteLine("Your age is not enough for work");
            }

        }
    }
}
