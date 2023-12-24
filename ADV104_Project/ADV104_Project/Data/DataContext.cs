using ADV104_Project.Entities;
using Microsoft.EntityFrameworkCore;

namespace ADV104_Project.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options) 
        {
        
        }
        

        public DbSet<Book> Books { get; set; } 
    }
}
