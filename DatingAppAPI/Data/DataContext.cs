using DatingAppAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace DatingAppAPI.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<AppUser> Users { get; set; }
    }
}
