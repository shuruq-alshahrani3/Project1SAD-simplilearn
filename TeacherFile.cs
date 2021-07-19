using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SADProject1
{
    partial class TeacherFile
    {
        private readonly string path;
        StreamWriter writer;
        public TeacherFile()
        {
            path = @"C:\Users\hp\Desktop\SAD_Solution2\SADProject1\TeacherFile.txt";

        }

        public void AddItem(int id, string name, string _class, string section)
        {
            writer = File.AppendText(path);

            string value = id + "/" + name + "/" + _class + "/" + section + "\n";
            writer.Write(value);

            Console.WriteLine(" * Added Done *");
            writer.Close();
        }


        public Teacher GetTeacher(int id)
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string s in lines)
            {
                string[] line = s.Split("/");
                if (int.Parse(line[0]) == id)
                {
                    Teacher teacher = new Teacher(int.Parse(line[0]), line[1], line[2], line[3]);
                    return teacher;
                }
                
                

            }

            return null;
        }

        public void update(int oldID, int id, string name, string _class, string section)
        {
            string[] lines = File.ReadAllLines(path);
            bool position = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split("/");
                if (int.Parse(line[0]) == oldID)
                {
                    lines[i] = id + " / " + name + " / " + _class + " / " + section;
                    position = true;
                }
            }
            if (position)
            {
                File.WriteAllLines(path, lines);
                Console.WriteLine("* Update is Doen *");
            }


        }


    }
}