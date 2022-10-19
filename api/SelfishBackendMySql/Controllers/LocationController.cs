using AutoMapper;
using AzureContext;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SelfishBackendMySql.DTO;
using System.Collections.Generic;
using System.Linq;

namespace SelfishBackendMySql.Controllers
{
[ApiController]
[Route("[controller]")]
    public class LocationController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;
        private readonly ILocationRepository _repository;
        private readonly sellfish_dbContext _context;

        public LocationController(ILocationRepository repostiry,
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
            var Comments = _mapper.Map<List<LocationDTO>>(_repository.GetManyLocation());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(Comments);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var location = _mapper.Map<CommentDTO>(_repository.GetSingleLocation(Id));

            if (location == null)
            {
                return NotFound();
            }

            return Ok(location);
        }

        [HttpPost]
        public IActionResult Post([FromBody] LocationDTO locationToCreate)
        {
            if (locationToCreate == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var locationMap = _mapper.Map<Location>(locationToCreate);

            locationMap.User = _context.Users.FirstOrDefault(o => o.Id == locationMap.UserId);

            if (!_repository.AddLocation(locationMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving entity");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully created");
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {

            var CommentToDelete = _context.Comments.FirstOrDefault(o => o.Id == Id);
            if (CommentToDelete == null)
            {
                return NotFound("Object to delete is not in DB");
            }

            _context.Comments.Remove(CommentToDelete);
            _context.SaveChanges();

            return StatusCode(200);
        }

        [HttpPut]
        public IActionResult Put(int Id, Comment Comment)
        {
            var CommentToChange = _context.Comments.FirstOrDefault(o => o.Id == Id);

            if (CommentToChange == null)
            {
                return NotFound("object to update is not in DB");
            }
            _context.SaveChanges();

            return StatusCode(200);
        }
    }
}
