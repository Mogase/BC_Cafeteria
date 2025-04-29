using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Cafeteria
{
    public class Student
    {
        string firstName;
        string surname;
        string residence;
        int yearsOnCampus;
        public double MonthlyAllowance;
        double averageMark;

        public Student(string firstName, string surname, string residence, int yearsOnCampus, double monthlyAllowance, double averageMark)
        {
            this.firstName = firstName;
            this.surname = surname;
            this.residence = residence;
            this.yearsOnCampus = yearsOnCampus;
            this.MonthlyAllowance = monthlyAllowance;
            this.averageMark = averageMark;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Residence { get => residence; set => residence = value; }
        public int YearsOnCampus { get => yearsOnCampus; set => yearsOnCampus = value; }
        public double MonthlyAllowance1 { get => MonthlyAllowance; set => MonthlyAllowance = value; }
        public double AverageMark { get => averageMark; set => averageMark = value; }
    }
}
