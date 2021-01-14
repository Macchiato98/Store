using Microsoft.EntityFrameworkCore;
using Store.Web.Data.Entidades;

namespace Store.Web.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
    }
}
