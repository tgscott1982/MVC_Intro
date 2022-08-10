using MVC_Intro.Models;

namespace MVC_Intro;
public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}