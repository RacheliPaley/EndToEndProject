using Common.DTO_s;
using Microsoft.AspNetCore.Mvc;
using Services;
using WebApi.models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController
    {

        private readonly IService<ChildDTO> _child;

        public ChildController(IService<ChildDTO> child)
        {
            _child = child;
        }



        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<ChildDTO>> GetAllChildren()
        {
            return await _child.GetAll();
        }

        // GET api/<ActionController>/5
        //[HttpGet("{id}")]
        //public async Task<ChildDTO> GetAllChildren(int id)
        //{
        //    return await _child.GetById(id);
        //}

        // POST api/<ActionController>
        [HttpPost]
        public async Task<ChildDTO> AddChild([FromBody] ChildModel postModel)
        {
            ChildDTO newOne = new ChildDTO();

            newOne.Date = postModel.Date;
            newOne.Name = postModel.Name;
            newOne.Id=postModel.PareentId;
            newOne.ChildTz = postModel.ChildTz;
            //newOne.parent = postModel.Parent;
            // newOne.parent = postModel.ParentId;
            return await _child.Add(newOne);
        }
    }
    }

