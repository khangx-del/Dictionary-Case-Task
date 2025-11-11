using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Case_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>
            {
                {12345, "Khang"},
                {13443, "Phan"}
            };
            Console.WriteLine("===== Student Management Menu =====");

            while (true)
            {
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. Display all students");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option (1-4): ");
                int choice = int .Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter student ID of the new student: ");
                        int ID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter student's name for that ID :");
                        string name = Console.ReadLine();
                        students.Add(ID, name);
                        Console.WriteLine("Done!");
                        break;

                    case 2:
                        Console.WriteLine("Enter the student ID of the student to be removed: ");
                        int IDRemove = int.Parse(Console.ReadLine());
                        if (students.ContainsKey(IDRemove))
                        {
                            students.Remove(IDRemove);
                            Console.WriteLine($"{IDRemove} ID has been remove");
                        }
                        else
                        {
                            Console.WriteLine("ID not found:");
                        }
                        break;

                    case 3:
                        Console.WriteLine("--- List Of Students ---");
                        foreach (var student in students)
                        {
                            Console.WriteLine(student); 
                        }
                        break;
                    case 4:
                        return;
                }             
            }        
        }
    }
}
