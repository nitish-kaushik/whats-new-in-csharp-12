using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public IList<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>()
            {
                new() {FirstName = "Rose", LastName="Bell", Email="r.bell@dummy.com", Salary = 89},
                new() {FirstName = "Molly", LastName="Brown", Email="m.brown@dummy.com", Salary = 99},
                new() {FirstName = "Sally", LastName="Butler", Email="s.butler@dummy.com", Salary = 80},
                new() {FirstName = "Wanda", LastName="Clark", Email="w.clark@dummy.com", Salary = 78},
                new() {FirstName = "Victoria", LastName="Hunter", Email="v.hunter@dummy.com", Salary = 38}
            };
        }
    }
}
