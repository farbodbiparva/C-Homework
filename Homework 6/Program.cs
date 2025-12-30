using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string StudentID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static Dictionary<string, Student> students = new Dictionary<string, Student>();
    static string filePath = @"C:\UNI.txt";

    static void Main()
    {
        LoadFromFile();

        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Enter Student Info");
            Console.WriteLine("2. Show Student Info");
            Console.WriteLine("3. Delete Student Info");
            Console.WriteLine("4. EXit");
            Console.Write("Enter numbers 1-4 for choices above: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    ShowStudents();
                    break;
                case "3":
                    RemoveStudent();
                    break;
                case "4":
                    SaveToFile();
                    Console.WriteLine("Saved Succesfuly Exiting...");
                    return;
                default:
                    Console.WriteLine("Unidentified Number!");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Student ID: ");
        string id = Console.ReadLine();

        if (students.ContainsKey(id))
        {
            Console.WriteLine("a Student with this ID already Exists!");
            return;
        }

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        students[id] = new Student
        {
            StudentID = id,
            Name = name,
            Age = age
        };

        Console.WriteLine("Student Succesfuly Added.");
    }

    static void ShowStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No Student Files Found.");
            return;
        }

        foreach (var student in students.Values)
        {
            Console.WriteLine($"ID: {student.StudentID} | Name: {student.Name} | Age: {student.Age}");
        }
    }

    static void RemoveStudent()
    {
        Console.Write("Enter Student ID to Remove: ");
        string id = Console.ReadLine();

        if (students.Remove(id))
            Console.WriteLine("Student Removed.");
        else
            Console.WriteLine("Student not found.");
    }

    static void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            foreach (var s in students.Values)
            {
                sw.WriteLine($"{s.StudentID},{s.Name},{s.Age}");
            }
        }
    }

    static void LoadFromFile()
    {
        if (!File.Exists(filePath))
            return;

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                students[parts[0]] = new Student
                {
                    StudentID = parts[0],
                    Name = parts[1],
                    Age = int.Parse(parts[2])
                };
            }
        }
    }
}
