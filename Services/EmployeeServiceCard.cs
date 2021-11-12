using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using UTS.Models;

namespace UTS.Services
{
    public class EmployeeServiceCard : IEmployeeServiceCard
    {
        private HttpClient _httpClient;
        public EmployeeServiceCard(HttpClient httpClient)
        {
              _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("/api/Employees");
            return results;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>($"/api/Employees/{id}");
            return result;
        }

        public Task<Employee> Add(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Task<Employee> Update(int id, Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}