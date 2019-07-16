using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinExtra.Models;

namespace XamarinExtra.Services
{
    class EmployeeService
    {
        static ObservableCollection<Employee> Employees = new ObservableCollection<Employee>();
        static string APIBaseURL = "https://my.api.mockaroo.com/employees.json?key=9a55a0e0";
        public static async Task<ObservableCollection<Employee>> GetEmployees()
        {
            using (var httpClient = new HttpClient())
            {
                var webCallResponse = await httpClient.GetStringAsync(APIBaseURL);
                Employees = JsonConvert.DeserializeObject<ObservableCollection<Employee>>(webCallResponse);
                return Employees;
            }
        }
        public static Employee AddEmployee(Employee employee)
        {
            Employees.Add(employee);
            return employee;
        }
        public static Employee RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
            return employee;
        }
    }
}
