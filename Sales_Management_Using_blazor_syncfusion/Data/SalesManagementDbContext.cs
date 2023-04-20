using Microsoft.EntityFrameworkCore;
using Sales_Management_Using_blazor_syncfusion.Entities;

namespace Sales_Management_Using_blazor_syncfusion.Data
{
    public class SalesManagementDbContext:DbContext
    {
        public SalesManagementDbContext(DbContextOptions<SalesManagementDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData.AddEmployeeData(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeJobTitle> EmpJobTitles { get; set; }

    }
}
