using Microsoft.EntityFrameworkCore;
using Proniaproject.Models;

namespace Proniaproject.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Person> Persons { get; set; }


    }
}
