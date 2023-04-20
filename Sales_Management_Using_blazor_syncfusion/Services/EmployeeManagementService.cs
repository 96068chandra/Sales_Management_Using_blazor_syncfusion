using Microsoft.EntityFrameworkCore;
using Sales_Management_Using_blazor_syncfusion.Data;
using Sales_Management_Using_blazor_syncfusion.Entities;
using Sales_Management_Using_blazor_syncfusion.Extensions;
using Sales_Management_Using_blazor_syncfusion.Models;
using Sales_Management_Using_blazor_syncfusion.Services.Contracts;

namespace Sales_Management_Using_blazor_syncfusion.Services
{
    public class EmployeeManagementService : IEmployeeManagementService
    {
        private readonly SalesManagementDbContext salesManagementDbContext;

        public EmployeeManagementService(SalesManagementDbContext salesManagementDbContext)
        {
            this.salesManagementDbContext = salesManagementDbContext;
        }
        public async Task<List<EmployeeModel>> GetEmployees()
        {
            try
            {
                return await this.salesManagementDbContext.Employees.Convert();
            }
            catch (Exception)
            {
                throw;

            }
        }

        public async Task<List<EmployeeJobTitle>> GetJobTitles()
        {
            try
            {
                return await this.salesManagementDbContext.EmpJobTitles.ToListAsync();
            }catch (Exception)
            {
                throw;
            }
        }
    }
}
