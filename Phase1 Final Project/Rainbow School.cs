using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1_Final_Project
{
    class Rainbow_School
    {
        public static void Do()
        {
            Teacher.WriteTeacherData();
            Teacher.ReadTecherData();
            Console.WriteLine("Do you want to update teacher data? (yes/no)");
            string ans = Console.ReadLine();
            if (ans == "yes")
            {
                Console.WriteLine("Enter id of teacher to be updated");
                int id = Convert.ToInt32(Console.ReadLine());
                var flag = Teacher.FindAndUpdateTeacher(id);
                if (flag)
                {
                    Teacher.ReadTecherData();
                }
                else
                {
                    Console.WriteLine("No such teacher record found");
                }
            }
        }
    }
}
