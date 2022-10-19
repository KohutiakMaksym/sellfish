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
    public class CartController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;
        private readonly ICartRepository _repository;
        private readonly sellfish_dbContext _context;

        public CartController(ICartRepository repostiry,
                              IWebHostEnvironment environment,
                              IMapper mapper,
                              sellfish_dbContext context)
        {
            _repository = repostiry;
            _environment = environment;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Carts = _repository.GetCarts();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(Carts);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var Cart = _mapper.Map<CartDTO>(_repository.GetCart(Id));

            if (Cart == null)
            {
                return NotFound();
            }

            return Ok(Cart);
        }

        [HttpPost]
        public IActionResult Post(CartDTO CartToCreate)
        {
            if (CartToCreate == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoryMap = _mapper.Map<Cart>(CartToCreate);

            if (!_repository.AddCart(categoryMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving entity");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully created");
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var cart = _context.Carts.FirstOrDefault(c => c.Id == Id);

            if (cart == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_repository.DeleteCart(cart))
            {

            }

            return Ok("Succesfully Deleted");
        }

        [HttpPut]
        public IActionResult Put( int Id, Cart cart)
        {
            if (cart == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!_repository.UpdateCart(cart))
            {
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully updated");
        }
    }
}
