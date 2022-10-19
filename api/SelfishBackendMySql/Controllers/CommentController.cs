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

namespace SelCommentBackend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;
        private readonly ICommentRepository _repository;
        private readonly sellfish_dbContext _context;

        public CommentController(ICommentRepository repostiry,
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
            var Comments = _mapper.Map<List<CommentDTO>>(_repository.GetComments());
         
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(Comments);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var Comment = _mapper.Map<CommentDTO>(_repository.GetComment(Id));

            if (Comment == null)
            {
                return NotFound();
            }
            
            return Ok(Comment);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CommentDTO CommentToCreate)
        { 
            if (CommentToCreate == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commentMap = _mapper.Map<Comment>(CommentToCreate);

            commentMap.User = _context.Users.FirstOrDefault(o=>o.Id == commentMap.UserId);

            if (!_repository.AddComment(commentMap))
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
