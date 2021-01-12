using Microsoft.EntityFrameworkCore;
using Store.Web.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Web.Data
{
    public class DataContext : DbContext
    {

        public DbSet<Products> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }
    }
}
