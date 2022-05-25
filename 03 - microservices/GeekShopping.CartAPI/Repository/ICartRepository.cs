using System.Threading.Tasks;
using GeekShopping.CartAPI.ValueObjects;

namespace GeekShopping.CartAPI.Repository
{
    public interface ICartRepository
    {
        Task<CartVO> FindCartByUserId (string userId);
        Task<CartVO> SaveOrUpdateCart (CartVO cart);
        Task<bool> RemoveFromCart (long  cartDId);
        Task<bool> ApplyCoupon (string userId, string cuponCode);
        Task<bool> RemoveCoupon(string userId);
        Task<bool> ClearCart(string userId);
    }
}
