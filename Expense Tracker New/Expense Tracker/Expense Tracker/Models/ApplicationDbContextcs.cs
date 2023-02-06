
// this is where we connect to SQL database, this is where we use the connection string

// need this to access models
using Expense_Tracker.Models;

// we need Entity Framework Core for this, download the NuGet Package
using Microsoft.EntityFrameworkCore;
namespace Expense_Tracker.Models
{

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Category> Categories { get; set; }

    }

}
