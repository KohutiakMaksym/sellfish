using AutoMapper;
using AzureContext;
using DataAccess.Interfaces;
using DataAccess.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SelfishBackendMySql.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SelCartBackend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CartToFishController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;
        private readonly ICartRepository _cartRepostiry;
        private readonly ICartToFishRepository _cartToFishRepository;
        private readonly IFishRepository _fishRepository;
        private readonly sellfish_dbContext _context;

        public CartToFishController(ICartRepository cartRepostiry,
                              ICartToFishRepository cartToFishRepository,
                              IFishRepository fishRepository,
                              IWebHostEnvironment environment,
                              IMapper mapper,
                              sellfish_dbContext context)
        {
            _cartRepostiry = cartRepostiry;
            _cartToFishRepository = cartToFishRepository;
            _fishRepository = fishRepository;
            _cartRepostiry = cartRepostiry;
            _cartRepostiry = cartRepostiry;

            _environment = environment;
            _mapper = mapper;
            _context = context;
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var Carts = _mapper.Map<List<CartDTO>>(_repository.GetCarts());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    return Ok(Carts);
        //}

        //[HttpGet("{Id}")]
        //public IActionResult Get(int Id)
        //{
        //    var Cart = _mapper.Map<CartDTO>(_repository.GetCart(Id));

        //    if (Cart == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(Cart);
        //}

        [HttpPost]
        public IActionResult Post(CartToFishDTO CartToFishCreate)
        {
            if (CartToFishCreate == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cartToFishMap = _mapper.Map<CartToFish>(CartToFishCreate);

            cartToFishMap.Item = _context.Fish.FirstOrDefault(o => o.Id == cartToFishMap.ItemId);
            cartToFishMap.Cart= _context.Carts.FirstOrDefault(o => o.Id == cartToFishMap.CartId);

            if (!_cartToFishRepository.AddCartToFish(cartToFishMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving entity");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully created");
        }

        //[HttpDelete("{Id}")]
        //public IActionResult Delete(int Id)
        //{

        //    var CartToDelete = _context.Carts.FirstOrDefault(o => o.Id == Id);
        //    if (CartToDelete == null)
        //    {
        //        return NotFound("Object to delete is not in DB");
        //    }

        //    _context.Carts.Remove(CartToDelete);
        //    _context.SaveChanges();

        //    return StatusCode(200);
        //}

        //[HttpPut]
        //public IActionResult Put(int Id, Cart Cart)
        //{
        //    var CartToChange = _context.Carts.FirstOrDefault(o => o.Id == Id);

        //    if (CartToChange == null)
        //    {
        //        return NotFound("object to update is not in DB");
        //    }
        //    _context.SaveChanges();

        //    return StatusCode(200);
        //}
    }
}
