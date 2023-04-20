using Sales_Management_Using_blazor_syncfusion.Entities;
using Sales_Management_Using_blazor_syncfusion.Models;

namespace Sales_Management_Using_blazor_syncfusion.Services.Contracts
{
    public interface IEmployeeManagementService
    {
        Task<List<EmployeeModel>> GetEmployees();
        Task<List<EmployeeJobTitle>> GetJobTitles();
    }
}
