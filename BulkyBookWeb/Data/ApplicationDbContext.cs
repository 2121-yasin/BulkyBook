using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
//configuration 
namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        //establish the connection with entity framework
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
