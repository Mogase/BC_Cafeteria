using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC_Cafeteria
{
    internal class Program
    {
        public static List<Student> studentDetailsList = new List<Student>();

        enum Menu
        {
            CaptureDetails = 1,
            CheckDiscount = 2,
            ShowQualification = 3,
            Exit = 4
        }

        static void Main(string[] args)
        {


            int choice;

            while (true)
            {

                Console.WriteLine("Select an Option");
                Console.WriteLine("1. Capture Details");
                Console.WriteLine("2. Check Discount");
                Console.WriteLine("3. Show Qualification");
                Console.WriteLine("4. Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        CaptureDetails();
                        //Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        CheckDiscount();
                        break;

                    case 3:
                        Console.Clear();
                        ShowQualification();
                        break;

                    case 4:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please pick correct number");
                        Console.WriteLine();
                        break;
                }
            
            }
           
        }
        public static void CaptureDetails()
        {
            char YesNo;

            do
            {
                Console.WriteLine("Enter your First Name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your surname");
                string surname = Console.ReadLine();
                Console.WriteLine("Are you a residence student");
                string residence = Console.ReadLine().ToUpper();
                Console.WriteLine("Years on campus:");
                int yearsOnCampus = int.Parse(Console.ReadLine());
                Console.WriteLine("What is your monthly allowance:");
                double monthlyAllowance = double.Parse(Console.ReadLine());
                Console.WriteLine("What is your average marks accross all subjects");
                double averageMark = double.Parse(Console.ReadLine());

                Student student = new Student(firstName, surname, residence, yearsOnCampus, monthlyAllowance, averageMark);
                studentDetailsList.Add(student);

                Console.WriteLine("Do you want to Continue? Y/N");
                YesNo = char.ToUpper(Console.ReadKey().KeyChar);
                Console.Clear();

            } while (YesNo == 'Y');


        }
        public static void CheckDiscount()
        {
            List<Student> grantedDiscount = new List<Student>();
            List<Student> deniedDiscount = new List<Student>();

            foreach (var student in studentDetailsList)
            {
                if (student.Residence == "YES" && student.YearsOnCampus > 1 && student.AverageMark >= 85 && student.MonthlyAllowance1 <= 1000)
                {
                    grantedDiscount.Add(student);
                }
                else
                {
                    deniedDiscount.Add(student);
                }
            }
            Console.WriteLine($"Number of applicants granted the discount: {grantedDiscount.Count}");
            Console.WriteLine($"Number of applicants whose Discount was denied: {deniedDiscount.Count}");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
        }
        public static void ShowQualification()
        {
            Console.WriteLine("Qualification Status for Applicants:");

            foreach (var student in studentDetailsList)
            {
                string qualificationStatus = "Denied";

                if (student.Residence == "YES" && student.YearsOnCampus > 1 && student.AverageMark > 85 && student.MonthlyAllowance <= 1000)
                {
                    qualificationStatus = "Granted";
                }

                Console.WriteLine($"Name: {student.FirstName} {student.Surname}, Qualification Status: {qualificationStatus}");
            }
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
        }
        public static void DisplayList()
        {
            foreach (var student in studentDetailsList)
            {
                Console.WriteLine($"First Name: {student.FirstName}, Surname: {student.Surname}, residence student: {student.Residence}, Years on campus: {student.YearsOnCampus}, student monthly allowance: {student.MonthlyAllowance}, average mark across all subjects: {student.AverageMark}");
            }


        }

    }
}
