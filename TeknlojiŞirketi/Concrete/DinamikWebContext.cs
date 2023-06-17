using Microsoft.EntityFrameworkCore;

using TeknlojiŞirketi.Models;

namespace TeknlojiŞirketi.Concrete
{
    public class DinamikWebContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=(localdb)\\MSSQLLocalDB;database=SarsiciDb;Integrated security=true;");
        }
        public DbSet<CurrentOpening> CurrentOpenings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
