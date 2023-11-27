using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public interface IEmployeeRepository
    {
        IList<EmployeeModel> GetEmployees();
    }
}