using AutoMapper;
using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using AzureContext;
using DataAccess.Interfaces;
using DataAccess.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SelfishBackendMySql.DTO;
using System;                                                                                     
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SelfishBackend.Controllers
{


    [ApiController]
    [Route("[controller]")]
    public class FishController : ControllerBase
    {

        public readonly IMapper _mapper;
        public readonly IWebHostEnvironment _environment;
        public readonly IFishRepository _repository;
        public readonly sellfish_dbContext _context;
        public readonly string _azureBlobConnectionString;
        public readonly string _azureBlobContainer;
        public readonly string _azureBlobSite;


        public FishController(IFishRepository repostiry,
                              IWebHostEnvironment environment,
                              IMapper mapper,
                              sellfish_dbContext context,
                               IConfiguration configuration )
        {
            _repository = repostiry;
            _environment = environment;
            _mapper = mapper;
            _context = context;
            _azureBlobConnectionString = configuration.GetConnectionString("AzureBlobConnectionString");
            _azureBlobContainer = configuration.GetValue<string>("ImageContainer");
            _azureBlobSite = configuration.GetValue<string>("ImageBlobSite");
        }

        [HttpGet]
        public IActionResult Get()
        {
            var fishs = _mapper.Map<List<FishDTO>>(_repository.GetManyFish());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(fishs);
        }

        [HttpGet("{Id}")]
        public IActionResult Get(int Id)
        {
            var fish = _mapper.Map<FishDTO>(_repository.GetSingleFish(Id));

            if (fish == null)
            {
                return NotFound();
            }

            return Ok(fish);
        }

        [HttpPost]
        public IActionResult Post([FromForm] FileUplaod fileupload)
        {
            var fishToCreate = fileupload.fishDTO;

            if (fishToCreate == null)
                return BadRequest(ModelState);

            Fish fish = _repository.GetManyFish().
                        Where(c => c.FishName.Trim().ToUpper() == fishToCreate.FishName.Trim().ToUpper()).FirstOrDefault();
           
            if (fish != null)
            {
                ModelState.AddModelError("", "Fish already exist in Db");
                return StatusCode(422, ModelState);
            }
            var fishMap = _mapper.Map<Fish>(fishToCreate);

            var file = fileupload.files;

            UploadBlob(file);

            fishMap.ImageUrl = _azureBlobSite + file.FileName;

            if (!_repository.AddFish(fishMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving entity");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully created");
        }

        //[HttpDelete("{Id}")]
        //public IActionResult Delete(int Id)
        //{

        //    var fishToDelete = _context.Fish.FirstOrDefault(o => o.Id == Id);
        //    if (fishToDelete == null)
        //    {
        //        return NotFound("Object to delete is not in DB");
        //    }

        //    _context.Fish.Remove(fishToDelete);
        //    _context.SaveChanges();

        //    return StatusCode(200);
        //}

        //[HttpPut]
        //public IActionResult Put(int Id, Fish fish)
        //{
        //    var fishToChange = _context.Fish.FirstOrDefault(o => o.Id == Id);

        //    if (fishToChange == null)
        //    {
        //        return NotFound("object to update is not in DB");
        //    }
        //    _context.SaveChanges();

        //    return StatusCode(200);
        //}
        [NonAction]
        public bool UploadBlob(IFormFile blob)
        {
            BlobContainerClient container = new BlobContainerClient(_azureBlobConnectionString, _azureBlobContainer);
            try
            {
                BlobClient client = container.GetBlobClient(blob.FileName);

                var blobHttpHeader = new BlobHttpHeaders { ContentType = "image/jpg" };

                using (Stream? data = blob.OpenReadStream())
                {

                    client.Upload(data, new BlobUploadOptions { HttpHeaders = blobHttpHeader });
                }

            }
            //catch (RequestFailedException ex)
            //   when (ex.ErrorCode == BlobErrorCode.BlobAlreadyExists)
            //{
            //    return false;
            //}
            catch (RequestFailedException)
            {
                return false;
            }
            return true;
        }
    }

    public class FileUplaod
    {
        public int id { get; set; }
        public IFormFile files { get; set; }
        public FishDTO fishDTO { get; set; }
    }
}
