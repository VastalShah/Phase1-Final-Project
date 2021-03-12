using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Phase1_Final_Project
{
    class Teacher
    {
        public static string getPath()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\teacherData.txt";
            return filename;
        }
        
        public static void AddTeacherData(int id, string name, string classAndSection)
        {
            string teacher = id.ToString() + ", " + name + ", " + classAndSection;
            string filename = getPath();
            List<string> t = new List<string>();
            t.Add(teacher);
            if (File.Exists(filename))
            {
                File.AppendAllLines(filename, t);
            }
        }

        public static void ReadTeacherData()
        {
            //this function is reading the data from the teacherData.txt file
            string filename = getPath();
            Console.WriteLine("");
            if (File.Exists(filename))
            {
                Console.WriteLine("File Exist");
                Console.WriteLine("Reading data from the file");
                var teachers = File.ReadAllLines(filename);
                foreach(var teacher in teachers)
                {
                    Console.WriteLine(teacher+"\n");
                }
            }
        }

        public static void FindAndUpdateTeacher(int id)
        {
            //this function firstly finds the teacher record with id
            //if record is found then it is updating the values after taking input from user.
            string filename = getPath();
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
                    }
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public static void WriteTeacherData()
        {
            //this function is creating the file teacherData.txt and adding data into that file
            string filename = getPath();

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
    }
}
