using Microsoft.EntityFrameworkCore;
using Sales_Management_Using_blazor_syncfusion.Entities;
using Sales_Management_Using_blazor_syncfusion.Models;
using Syncfusion.Blazor.DropDowns;

namespace Sales_Management_Using_blazor_syncfusion.Extensions
{
    public static class Conversions
    {
        public static async Task<List<EmployeeModel>> Convert(this IQueryable<Employee> employees)
        {
            return await (from e in employees
                          select new EmployeeModel
                          {
                              id=e.id,
                              FirstName=e.FirstName,
                              LastName=e.LastName,
                              Email=e.Email,
                              DateOfBirth=e.DateOfBirth,
                              ReportToEmpId=e.ReportToEmpId,
                              Gender=e.Gender,
                              ImagePath=e.ImagePath,
                          }).ToListAsync();
            
        }
     }

}
