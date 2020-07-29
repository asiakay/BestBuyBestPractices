using System;
using System.Collections.Generic;

namespace BestBuyBestPractices
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
    public void CreateProduct(string name, int price, int categoryID)
    {

    } 
}
