using System;
using ClassLibrary;
namespace _1AprelTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employer1 = new Employee();
            employer1.Name = "Dilqem";
            employer1.SurName = "Abbasov";
            employer1._age = 18;
            employer1.SalaryOfHour = 100;
            employer1.WorkingHour = 5;
            Console.WriteLine(employer1.Name + " " + employer1.SurName + " ");
            employer1.CalculateSalary();

            string studentName = "Dilqem";
            string studentSurname = "Abbasov";
            int studentAge = 15;
            int sutdentIQ = 60;
            int sutdentLanguageRank = 80;


            if (studentAge >6 && studentAge<20)
            {
                
                Student student1 = new Student(studentName, studentSurname, studentAge, sutdentIQ, sutdentLanguageRank);
                
                Console.WriteLine(studentName + " " + studentSurname + " " + studentAge + " " +  " " + sutdentIQ + " " + sutdentLanguageRank);
                student1.ExamResult();
            }
            else
            {
                Console.WriteLine("Your age is not match");
            }
            
            


        }
    }
}
