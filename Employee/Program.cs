using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Id");
            string a = Console.ReadLine();

            Console.WriteLine("Enter your name");
            string n = Console.ReadLine();

            Console.WriteLine("Enter you Department Name");
            string d = Console.ReadLine();

            Employee emp = new Employee(a, n, d);
            emp.MessageFired += new Employee.EmpMessageFired(OnMessageFired);
            emp.MessageFired2 += new Employee.EmpMessageFired(OnMessageFired2);
            emp.MessageFired3 += new Employee.EmpMessageFired(OnMessageFired3);

            Console.WriteLine(emp.GetId());
            Console.WriteLine(emp.GetName());
            Console.WriteLine(emp.GetDepartmentName());

            static void OnMessageFired(string message)
            {
                Console.WriteLine("GetId() method called");
            }
            static void OnMessageFired2(string message)
            {
                Console.WriteLine("GetName() method called");
            }
            static void OnMessageFired3(string message)
            {
                Console.WriteLine("GetDepartmentName() method called");
            }
        }
    }
}
