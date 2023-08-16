using Microsoft.EntityFrameworkCore;
using SpecialDP.Models;

namespace SpecialDP.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
    }
}
