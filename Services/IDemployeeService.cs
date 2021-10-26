using System.Collections.Generic;
using System.Threading.Tasks;
using UTS.Models;

namespace UTS.Services
{
    public interface IDemployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
        
    }
}