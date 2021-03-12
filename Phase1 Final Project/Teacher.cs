using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Phase1_Final_Project
{
    class Teacher
    {
        public static string dir = Directory.GetCurrentDirectory();
        public static string filename = dir + "\\teacherData.txt";

        public static void WriteTeacherData()
        {
            //this function is creating the file teacherData.txt and adding data into that file
            if (File.Exists(filename))
            {
                Console.WriteLine("File Exist");
            }
            else
            {
                Console.WriteLine("FIle does not exist");
            }
            Console.WriteLine("\nAdding Teacher data in the file...");
            StreamWriter srt = File.CreateText(filename);
            srt.WriteLine("101, Madhu Sharma, CSE-A");
            srt.WriteLine("102, Amit Mishra, CSE-B");
            srt.WriteLine("103, Ajay Kumar, ME-A");
            srt.WriteLine("104, Surbhi Yadav, ME-B");
            srt.WriteLine("105, Rakesh Jha, PE-A");
            srt.Close();
        }

        public static void ReadTecherData()
        {
            //this function is reading the data from the teacherData.txt file
            if (File.Exists(filename))
            {
                Console.WriteLine("File Exist");
                Console.WriteLine("\nReading data from the file\n");
                var teachers = File.ReadAllLines(filename);
                foreach(var teacher in teachers)
                {
                    Console.WriteLine(teacher+"\n");
                }
            }
        }

        public static bool FindAndUpdateTeacher(int id)
        {
            //this function firstly finds the teacher record with id
            //if record is found then it is updating the values after taking input from user.
            if (File.Exists(filename))
            {
                var teachers = File.ReadAllLines(filename);
                for (int i = 0; i < teachers.Length; i++)
                {
                    string[] teacher = teachers[i].Split(", ");
                    if(Convert.ToInt32(teacher[0]) == id)
                    {
                        Console.WriteLine("Enter teacher updated id");
                        teacher[0] = Console.ReadLine();
                        Console.WriteLine("Enter teacher updated name");
                        teacher[1] = Console.ReadLine();
                        Console.WriteLine("Enter teacher updated Class and Section");
                        teacher[2] = Console.ReadLine();

                        string updatedTeacher = teacher[0] + ", " + teacher[1] + ", " + teacher[2];
                        teachers[i] = updatedTeacher;
                        File.WriteAllLines(filename, teachers);
                        return true;
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
            return false;
        }
    }
}
