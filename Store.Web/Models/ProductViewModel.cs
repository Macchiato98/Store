namespace Store.Web.Models
{
    using Microsoft.AspNetCore.Http;
    using Store.Web.Data.Entidades;
    using System.ComponentModel.DataAnnotations;

    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
