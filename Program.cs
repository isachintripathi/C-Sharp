using System;
using System.Collections.Generic;

namespace List
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
			
			Console.WriteLine("---------------------List Declaration and Intialization--------------------------------");
			List<Employee> emp = new List<Employee>(2);
				emp.Add(emp1);
				emp.Add(emp2);
				emp.Add(emp3);
				
			foreach (var i in emp)
			{
				Console.WriteLine("ID = {0}, Name = {1}, Salaray = {2}", i.ID, i.Name, i.Salary);
			}
			
			Console.WriteLine("---------------------Insert data in List--------------------------------");
			
			emp.Insert(0,emp3);
			
			foreach (var i in emp)
			{
				Console.WriteLine("ID = {0}", i.ID);
			}
			
			Console.WriteLine("---------------------Find Index of List Data-----------------------------");
			
			Console.WriteLine(emp.IndexOf(emp3, 1, 2));
			
			Console.WriteLine("---------------------COntains-----------------------------");
			
			if(emp.Contains(emp3))
			{
				Console.WriteLine("Employee {0} is present", emp3.Name);
			}
			else
			{
				Console.WriteLine("Employee is Absent");
			}
			
			Console.WriteLine("---------------------Exists-----------------------------");
			
			if(emp.Exists(emp => emp.Salary > 10000))
			{
				foreach(var i in emp)
				{
					Console.WriteLine("Employee {0} has high salary", i.Name);
				}
			}
			else
			{
				Console.WriteLine("Employee has no salary");
			}
			
			Console.WriteLine("---------------------Find : First-----------------------------");
			
			Employee epl = emp.Find(emp => emp.Salary < 25000);
			Console.WriteLine("Employee {0} has less salary", epl.Name);
		
			Console.WriteLine("---------------------Find Last-----------------------------");
			
			Employee epll = emp.FindLast(emp => emp.Salary < 25000);
			Console.WriteLine("Employee {0} has less salary", epll.Name);
		
			Console.WriteLine("---------------------Find All-----------------------------");
			
			List<Employee> epl2 = emp.FindAll(emp => emp.Salary < 35000);
			foreach(var i in epl2)
				Console.WriteLine("Employee {0} has less salary", i.Name);
				
        }
		
		public class Employee
		{
			public int ID { get; set; }
			public string Name { get; set; }
			public int Salary { get; set; }
		}
    }
}
/*
1. List are used to create collection of any type. 
2. List can expand in memory size based on the ask. 
3. List can have records of any dataTypes.
4. List objects are accessed by Index.
5. List classes has ability to search, shorting and manipulate data.
6. Contains(without condidtion) & Exists (can have conditions)
7. Find (First), FindLast, FindAll
8. We can check first/last index of List.Enumerator
9. We can create an Array from a List.
*/ 