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
            
            if (File.Exists(filename))
            {
                Console.WriteLine("File Exixts");
            }
            else
            {
                Console.WriteLine("FIle does not exist");
            }
            Console.WriteLine("Adding Teacher data in the file");
            StreamWriter srt = File.CreateText(filename);
            srt.WriteLine("101, Madhu Sharma, CSE-A");
            srt.WriteLine("102, Amit Mishra, CSE-B");
            srt.WriteLine("103, Ajay Kumar, ME-A");
            srt.WriteLine("104, Surbhi Yadav, ME-B");
            srt.WriteLine("105, Rakesh Jha, PE-A");
        }

        public static void ReadTecherData()
        {
            if (File.Exists(filename))
            {
                Console.WriteLine("File Exixts");
                var teachers = File.ReadAllLines(filename);
                foreach(var teacher in teachers)
                {
                    Console.WriteLine(teacher+"\n");
                }
            }
        }
    }
}
