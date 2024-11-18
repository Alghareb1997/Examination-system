using ConsoleApp1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher();
        Student student = new Student();
        Exam exam = new Exam();
        bool choice = true;

        do
        {
            Console.WriteLine("\n1. Add Teacher");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Make Exam");
            Console.WriteLine("4. Take Exam");
            Console.WriteLine("5. Your Marks");
            Console.WriteLine("6. Exist ......");
            Console.Write("Enter your choice: ");
            int Check = int.Parse(Console.ReadLine());

            switch (Check)
            {
                case 1:
                    Console.Write("Enter teacher's name: ");
                    string teacherName = Console.ReadLine();

                    Console.Write("Enter teacher's age: ");
                    int teacherAge = int.Parse(Console.ReadLine());

                    Console.Write("Enter teacher's subject: ");
                    string teacherSubject = Console.ReadLine();

                    Console.Write("Enter  teacher's Id number: ");
                    int teacherId = int.Parse(Console.ReadLine());

                    while (teacher.CheckId(teacherId))
                    {
                        Console.Write("Enter teacher's Id number: ");
                        teacherId = int.Parse(Console.ReadLine());
                    }

                    Teacher.Teachers.Add(new Teacher() { Name = teacherName, Age = teacherAge, Subject = teacherSubject,Id=teacherId });

                   
                    break;

                case 2:
                    Console.Write("Enter student's name: ");
                    string Studentname = Console.ReadLine();

                    Console.Write("Enter student's age: ");
                    int Studentage = int.Parse(Console.ReadLine());

                    Console.Write("Enter student's Id number: ");
                    int Studentid = int.Parse(Console.ReadLine());

                    while (student.CheckId(Studentid))
                    {
                        Console.Write("Enter student's Id number: ");
                         Studentid = int.Parse(Console.ReadLine());
                    }
                    Student.Students.Add(new Student() { Name=Studentname,Age=Studentage,Id = Studentid });

               
                    break;
                case 3:
                    Console.WriteLine("   Lets make Exam ");
                    Console.WriteLine("   Entre the number of Questions");
                    int Number = int.Parse(Console.ReadLine());
                    Question.MakeQuestion(Number);
                    break;

                case 4:
                    Console.WriteLine("   Lets start Exam ......");
                    Console.WriteLine(" Duration is : 3 Hours");
                    DateTime dateTime = DateTime.Now;
                    dateTime = dateTime.AddHours(3);
                    Console.WriteLine($" Exam will end at{dateTime}");

                    exam.DisplayExam();

                    
                    break;
                case 5:
                    Console.WriteLine("Your marks");
                    Question.Calculatemarks();
                    break;

                case 6: 
                    choice = false;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
           
        } while (choice);
    }
}