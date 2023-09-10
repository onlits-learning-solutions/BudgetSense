using Microsoft.EntityFrameworkCore;

namespace BudgetSense.Models;

public class BudgetSenseContext : DbContext
{
    public BudgetSenseContext(DbContextOptions<BudgetSenseContext> options)
     : base(options)
    {
    }

    public DbSet<Department>? MyProperty { get; set; }
}