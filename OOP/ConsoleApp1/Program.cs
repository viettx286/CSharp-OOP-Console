using System;
using System.IO;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            People[] employees = new People[6];
            employees[0] = new Staffs();
            employees[1] = new Staffs();
            employees[2] = new Managers();
            employees[3] = new Managers();
            employees[4] = new Director();
            employees[5] = new Director();


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"{i + 1}. Enter info {employees[i].Role} {i+1}:");
                while (true)
                {
                    Console.WriteLine($"FirstName: ");
                    string firstName = Console.ReadLine();
                    if (CheckFirstName(firstName))
                    {
                        ProgramExit();
                    }

                    if (!String.IsNullOrEmpty(firstName))
                    {
                        employees[i].FirstName = firstName;
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine($"LastName: ");
                    string lastName = Console.ReadLine();
                    if (!String.IsNullOrEmpty(lastName))
                    {
                        employees[i].LastName = lastName;
                        break;
                    }
                }

                Console.WriteLine($"WordDays: ");
                string workOfDay = Console.ReadLine();
                int days;
//                while (int.TryParse(workOfDay, out days))
//                {
//                    try
//                    {
//                        if (!CheckWorkDay(employees[i].WorkDay))
//                        {
//                            employees[i].WorkDay = days;
//                        }
//                    }
//                    catch (Exception e)
//                    {
//                        employees[i].WorkDay = 0;
//                    }
//                }
                do
                {
                    try
                    {
                        employees[i].WorkDay = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        employees[i].WorkDay = 0;
                    }
                } while (!CheckWorkDay(employees[i].WorkDay));

                var t = new Thread(new ThreadStart(() => { Write(employees); }));
                t.Start();
            }
        }

        public static void ProgramExit()
        {
            Console.WriteLine("Exist...");
            Environment.Exit(0);
        }

        public static bool CheckWorkDay(int workDay)
        {
            if (workDay < 0 || workDay > 31)
                return false;
            return true;
        }

        public static bool CheckFirstName(string name)
        {
            if (name.Equals("Anh")) return true;
            return false;
        }

        public static void Write<People>(People[] employees)
        {
            StreamWriter sw = new StreamWriter(string.Format("WriteText.txt"));
            for (int i = 0; i < employees.Length; i++)
            {
                sw.WriteLine(employees[i].ToString());
            }

            sw.Dispose();
            sw.Close();
        }
    }
}