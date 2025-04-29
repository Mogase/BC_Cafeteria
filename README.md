Belgium Campus Cafeteria Discount Qualification System.
This C# console application helps Belgium Campus Cafeteria determine whether students qualify for a high-performing student discount. The application captures student details such as name, residence status, years on campus, monthly allowance, and average marks, then evaluates if they meet the criteria for a discount.

Table of Contents
1. Project Overview
2. Functional Requirements
3. Features
4. How to Use
5. Enum: Menu Options
6. Project Structure
7. Technologies Used

Project Overview:
The Belgium Campus Cafeteria offers a discount to students who meet specific criteria. This C# console application allows users to enter student details, check if they qualify for the discount, and generate statistics based on their qualification status.

Functional Requirements:
Capture Student Details: The user can input student records interactively. For each student, the following information is collected:

> Full Name
> Residence Student (Yes/No)
> Years on Campus
> Years at Current Residence
> Monthly Allowance/Salary
> Average Mark across all subjects

Discount Qualification: The system evaluates whether a student qualifies for the discount based on the following criteria:

> The student must be a residence student and have stayed on campus for more than a year.
> The student’s average mark must be over 85%.
> The student’s monthly allowance must not exceed R1000.
> Qualification Stats: The program tracks how many students qualified for the discount and how many were denied.

Features
> Capture Student Details: Allows users to input an unlimited number of student records, capturing all the necessary details interactively in the console.
> Check Discount Qualification: Evaluates each student's eligibility for a discount based on pre-defined criteria.
> Display Qualification Stats: Provides statistics on the number of students who received the discount and those who did not.
> Menu-Driven Interface: The program operates through a simple text-based menu with options to:

1. Capture student details.
2. Check discount qualification.
3. Show qualification stats.
4. Exit the program.

How to Use
Clone or download this repository.
Open the project in Visual Studio or another C#-compatible IDE.
Build and run the application.
The program will present a console menu with the following options:
Capture Details: Enter student data interactively. You will be prompted to input student information until you choose to stop.
Check Discount Qualification: Evaluate the eligibility of all the students captured for the discount.
Show Qualification Stats: Display how many students were granted the discount versus those who were denied.
Exit: Close the application.

Follow the console prompts to input student details and select menu options.

Enum: Menu Options
The application uses an Enum to handle menu options, which are as follows:
public enum Menu
{
    CaptureDetails = 1,
    CheckDiscountQualification = 2,
    ShowQualificationStats = 3,
    Exit = 4
}
Each option corresponds to a specific action in the application, and users interact with the program through these menu choices.

Project Structure

/BelgiumCampusCafeteriaDiscountSystem
    ├── Program.cs            # Main program file with logic
    ├── Student.cs            # Class representing a student
    ├── DiscountEvaluator.cs  # Class for evaluating discount eligibility
    ├── DiscountStats.cs      # Class for generating qualification statistics
    ├── Menu.cs               # Enum that handles menu options
    └── README.md             # Project documentation
Program.cs: The main entry point of the application that drives the logic for the menu and operations.

Student.cs: A class that holds the details of a student.

DiscountEvaluator.cs: Contains the logic to evaluate whether a student qualifies for the discount.

DiscountStats.cs: Manages and displays the statistics for students who qualify or not.

Menu.cs: Contains the enum that defines the available menu options.

Technologies Used
C#
.NET (Core or Framework, depending on your environment)
Console Application (Text-based interface)

