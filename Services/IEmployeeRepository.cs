using System;
using Dependency_Injection.Entities;

namespace Dependency_Injection.Services
{
	public interface IEmployeeRepository
	{
		List<Employee> GetAllEmployees();
		Employee GetEmployeeByID(int ID);
	}
}

