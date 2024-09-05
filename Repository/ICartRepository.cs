using MyMvcAuthApp.Models;

namespace MyMvcAuthApp.Repository;

public interface ICartRepository
{
    Task<Cart> GetCart();
}