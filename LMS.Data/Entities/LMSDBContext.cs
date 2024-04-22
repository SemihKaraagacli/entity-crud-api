using Microsoft.EntityFrameworkCore;
namespace LMS.Data.Entities
{
    public class LMSDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyLMsDatabase");
        }
    }
}
