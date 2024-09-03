
using MyMvcAuthApp.Models;

namespace MyMvcAuthApp.Repository
{
    
                public interface IProductRepository
                {
                    Task<IEnumerable<Product>> Getir(); //Ürünleri Hepsini
                    Task<Product?> GetById(int? id); //ürünleri int parametresine göre getirir

                    Task Add(Product product);
                    Task Update(Product product);
                    Task Delete(int id);
                }
}