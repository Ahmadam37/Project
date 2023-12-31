﻿using System;

namespace StudentGradeEntrySystem
{

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            
            string fullName;
            int sGrade;
            
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter Student Name");
                fullName = Console.ReadLine();
                Console.WriteLine("Enter Student Grade");
                sGrade = int.Parse(Console.ReadLine());
                students[i] = new Student(fullName, sGrade);

                Console.WriteLine("Do you Want to Add new?(Y/N)");
               string message = Console.ReadLine();
                if (message.ToLower() != "y")
                {
                    break;
                }

            }

                foreach(var item in students)
                {
                if (item == null)
                {
                    break;
                }
                    Console.WriteLine("Name: {0}, Grade: {1}", item.Name, item.Grade);


                    if (item.Grade > 60)
                    {
                        Console.WriteLine("Status: Failed");
                    }
                    else
                    {
                        Console.WriteLine("Status: Passed");
                    }

                }

            

        }
     
    }
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
    }

}