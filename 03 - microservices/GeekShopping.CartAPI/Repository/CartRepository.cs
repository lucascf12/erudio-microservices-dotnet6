using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GeekShopping.CartAPI.Model;
using GeekShopping.CartAPI.Model.Context;
using GeekShopping.CartAPI.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CartAPI.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly MySQLContext _context;
        private IMapper _mapper;

        public CartRepository(MySQLContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> ApplyCoupon(string userId, string cuponCode)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> ClearCart(string userId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CartVO> FindCartByUserID(string userId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> RemoveCoupon(string userId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> RemoveFromCart(long cartDId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<CartVO> SaveOrUpdateCart(CartVO vo)
        {
            Cart cart = _mapper.Map<Cart>(vo);

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == vo.CartDetails.FirstOrDefault().ProductId);

            if (product == null)
            {
                _context.Products.Add(cart.CartDetails.FirstOrDefault().Product)
            }
        }
    }
}
