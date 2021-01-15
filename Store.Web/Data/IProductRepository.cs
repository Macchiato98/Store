namespace Store.Web.Data
{
    using System.Linq;
    using Store.Web.Data.Entidades;
    
    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWidthUsers();
    }
}
