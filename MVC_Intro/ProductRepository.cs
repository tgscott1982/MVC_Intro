using Dapper;
using MVC_Intro.Models;
using System.Data;

namespace MVC_Intro;

public class ProductRepository : IProductRepository
{
    private readonly IDbConnection _conn;

    public ProductRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
    }
}
