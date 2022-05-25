using GeekShopping.CartAPI.Repository;
using GeekShopping.CartAPI.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.CartAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _repository;

        public CartController(ICartRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        [HttpGet("find-cart/{id}")]
        public async Task<ActionResult<ProductVO>> FindById(string userID)
        {
            var cart = await _repository.FindCartByUserId(userID);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpPost("add-cart/{id}")]
        public async Task<ActionResult<ProductVO>> AddCart(CartVO vo)
        {
            var cart = await _repository.SaveOrUpdateCart(vo);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpPut("update-cart/{id}")]
        public async Task<ActionResult<ProductVO>> UpdateCart(CartVO vo)
        {
            var cart = await _repository.SaveOrUpdateCart(vo);
            if (cart == null) return NotFound();
            return Ok(cart);
        }

        [HttpDelete("remove-cart/{id}")]
        public async Task<ActionResult<ProductVO>> RemoveCart(int id)
        {
            var status = await _repository.RemoveFromCart(id);
            if (!status) return NotFound();
            return Ok(status);
        }


    }
}
