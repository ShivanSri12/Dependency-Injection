using System;
using Dependency_Injection.Entities;

namespace Dependency_Injection.Services
{
	public class EmployeeRepository : IEmployeeRepository
	{
			public List<Employee> DataSource()
			{
				return new List<Employee>()
				{
					new Employee() { EmployeeID = 1, EmployeeName = "Ravi", Designation = "Fresher", EmployeeType = "Full-Time", Address = "Bangalore" },
					new Employee() { EmployeeID = 2, EmployeeName = "Santhosh", Designation = "Junior Software Developer", EmployeeType = "Full-Time", Address = "Chennai" },
					new Employee() { EmployeeID = 3, EmployeeName = "Anish", Designation = "Software Developer", EmployeeType = "Full-Time", Address = "Bangalore" },
					new Employee() { EmployeeID = 4, EmployeeName = "Priya", Designation = "Dotnet Developer", EmployeeType = "Full-Time", Address = "Chennai" },
					new Employee() { EmployeeID = 5, EmployeeName = "Arun", Designation = "Senior Software Engineer", EmployeeType = "Full-Time", Address = "Chennai" },
					new Employee() { EmployeeID = 6, EmployeeName = "Mekala", Designation = "Android Developer", EmployeeType = "Full-Time", Address = "Chennai" },
					new Employee() { EmployeeID = 7, EmployeeName = "Mohammed", Designation = "Dotnet Developer", EmployeeType = "Full-Time", Address = "Hyderabad" }
				};
			}

			public Employee GetEmployeeByID(int id)
			{
				return DataSource().FirstOrDefault(e => e.EmployeeID == id);
			}

			public List<Employee> GetAllEmployees()
			{
				return DataSource();
			}

		}
	}
