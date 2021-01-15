namespace Store.Web.Data
{
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Store.Web.Data.Entidades;
 
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        public IQueryable GetAllWidthUsers()
        {
            return this.context.Products.Include(p => p.User);
        }
    }
}
