using System;
using System.Threading;



namespace SADProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            TeacherFile teacher = new TeacherFile();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t-----Welcome in the Rainbow School System-----");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The following fields will ​be stored for a teacher:");
            bool position = true;
            while (position)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" 1-Add New Data in System \n 2-Search in The System \n 3-Update Data \n 4-Exit");
                Console.ForegroundColor = ConsoleColor.Cyan;
                int? select = null;
                try
                {
                    int sel = int.Parse(Console.ReadLine());
                    select = sel ;
                }
                catch(Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please Enter The Number for Select");
                    Console.ForegroundColor = ConsoleColor.White;
                   
                }
                switch (select)
                {
                    case 1:
                      
                        try
                        {
                            Console.WriteLine("Please Enter ID");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enter Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Please Class Name");
                            string _class = Console.ReadLine();
                            Console.WriteLine("Please Enter Section Name");
                            string section = Console.ReadLine();
                            teacher.AddItem(id, name, _class, section);

                        }
                        catch (Exception )
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please Enter The Number for ID ");
                            Console.ForegroundColor = ConsoleColor.White;
                           
                        }
                        




                        break;

                    case 2:
                        Console.WriteLine("Please Enter the ID How wint to search");
                        int search_id = int.Parse(Console.ReadLine());
                        Teacher t1 = teacher.GetTeacher(search_id);
                        if (t1 != null)
                        {
                            Console.WriteLine($"The ID: {t1.ID}\nThe Name: {t1.Name}\nThe Class: {t1._class}\nThe Section: {t1.section}");
                        }
                        else
                        {
                            Console.WriteLine("Nothig ID in the file");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please Enter the ID How wint to search");
                        int id_search = int.Parse(Console.ReadLine());
                        Teacher t2 = teacher.GetTeacher(id_search);
                        if (t2 != null)
                        {
                            Console.WriteLine($"The ID: {t2.ID}\nTheName: {t2.Name}\nThe Class: {t2._class}\nThe Section: {t2.section}");
                            int old_id = t2.ID;
                            Console.WriteLine("Please Enter new ID");
                            int new_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enter new Name ");
                            string new_name = Console.ReadLine();
                            Console.WriteLine("Please Enter new Class");
                            string new_class = Console.ReadLine();
                            Console.WriteLine("Please Enter new Section");
                            string new_section = Console.ReadLine();
                            teacher.update(old_id, new_id, new_name, new_class, new_section);
                        }
                        else
                        {
                            Console.WriteLine("Can not foun any data in this id " + id_search);
                        }
                        break;
                    case 4:
                        position = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Plase chose 1 to 4 ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;

                }
            }
        }
    }
}