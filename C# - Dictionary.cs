using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee()
            {
                ID = 1,
                Name = "Sachin",
                Salary = 10000,
            };

            Employee emp2 = new Employee()
            {
                ID = 2,
                Name = "Saurabh",
                Salary = 15000,
            };

            Employee emp3 = new Employee()
            {
                ID = 3,
                Name = "Rohit",
                Salary = 25000,
            };

            // create a Dictionary
            Dictionary<int, Employee> dict = new Dictionary<int, Employee>();

            // add data to dictionary
            dict.Add(emp1.ID, emp1);
            dict.Add(emp2.ID, emp2);
            dict.Add(emp3.ID, emp3);

            // access data from Dictionary
            Employee emp0 = dict[3];

            //print dictionary data
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", emp0.ID, emp0.Name, emp0.Salary);
            Console.WriteLine("------------------------------------------------------------------");

            //in case of multiple records we use foreach using keyValue Pair
            foreach (KeyValuePair<int, Employee> emp in dict)
            {
                Console.WriteLine("ID = {0}", emp.Key);
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", emp.Value.ID, emp.Value.Name, emp.Value.Salary);
            }

            Console.WriteLine("--------------------------Print Key Value both With Key Value Pair-----------------------------------------");

            foreach (KeyValuePair<int, Employee> empp in dict)
            {
                int ee = empp.Key;
                Employee e = empp.Value;
                Console.WriteLine("ID = {0}", ee);
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", e.ID, e.Name, e.Salary);
            }

            Console.WriteLine("--------------------------Print Value Without Key Value Pair-----------------------------------------");

            foreach (var emp in dict.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", emp.ID, emp.Name, emp.Salary);
            }

            Console.WriteLine("---------------------Print Key Without Key Value Pair---------------------------------------------");

            foreach (int emp in dict.Keys)
            {
                Console.WriteLine("ID = {0}", emp);
            }

            //TryGetValue
            Console.WriteLine("---------------------TryGetValue---------------------------------------------");

            Employee employee;
            if (dict.TryGetValue(1, out employee))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", employee.ID, employee.Name, employee.Salary);
            }
            else
            {
                Console.WriteLine("Key not found");
            }

            //count
            Console.WriteLine("---------------------count---------------------------------------------");

            Console.WriteLine(" total count is : {0} ", dict.Count(kvp => kvp.Value.Salary > 10000));

            //remove
            Console.WriteLine("---------------------remove---------------------------------------------");

            dict.Remove(3);

            foreach (KeyValuePair<int, Employee> emp in dict)
            {
                Console.WriteLine("ID = {0}", emp.Key);
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", emp.Value.ID, emp.Value.Name, emp.Value.Salary);
            }

            //clear
            Console.WriteLine("---------------------clear---------------------------------------------");
            dict.Clear();

            Console.WriteLine("---------------------Array To Dictionary---------------------------------------------");

            Employee[] employeeArray = new Employee[3];
            employeeArray[0] = emp1;
            employeeArray[1] = emp2;
            employeeArray[2] = emp3;

            Dictionary<int, Employee> dictArray = employeeArray.ToDictionary(obj => obj.ID, obj => obj);

            foreach (KeyValuePair<int, Employee> array in dictArray)
            {
                Console.WriteLine("ID = {0}", array.Key);
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", array.Value.ID, array.Value.Name, array.Value.Salary);
            }

            Console.WriteLine("---------------------List To Dictionary---------------------------------------------");

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            Dictionary<int, Employee> dictList = employeeList.ToDictionary(obj => obj.ID, obj => obj);

            foreach (KeyValuePair<int, Employee> list in dictArray)
            {
                Console.WriteLine("ID = {0}", list.Key);
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", list.Value.ID, list.Value.Name, list.Value.Salary);
            }
        }

    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
