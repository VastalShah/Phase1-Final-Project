using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1_Final_Project
{
    class Rainbow_School
    {
        public static void Do()
        {
            string answer;
            Console.WriteLine(" == Rainbow School Program == ");
            do
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1.Add Teacher\n2.Print Teacher Data\n3.Update Teacher Data\n4.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter teacher id:");
                        int idtoAdd = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter teacher name:");
                        string nametoAdd = Console.ReadLine(); 
                        Console.WriteLine("Enter teacher Class and Section:");
                        string classAndSectiontoAdd = Console.ReadLine();
                        Teacher.AddTeacherData(idtoAdd, nametoAdd, classAndSectiontoAdd);
                        break;
                    case 2:
                        Teacher.ReadTeacherData();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter id of teacher to be updated");
                        int idtoUpdate = Convert.ToInt32(Console.ReadLine());
                        Teacher.FindAndUpdateTeacher(idtoUpdate);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Do you want to continue? (yes/no)");
                answer = Console.ReadLine();
            } while (answer == "yes");
        }
    }
}
