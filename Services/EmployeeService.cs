using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using UTS.Models;

namespace UTS.Services
{
    public class EmployeeService : IDemployeeService
    {
        private HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
              _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var results = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("/api/Employees");
            return results;
        }

        public async Task<Employee> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Employee>($"/api/Employees/{id}");
            return result;
        }
    }
}