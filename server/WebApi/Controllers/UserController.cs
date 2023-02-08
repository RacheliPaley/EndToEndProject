using Common.DTO_s;
using Microsoft.AspNetCore.Mvc;
using Services;
using WebApi.models;

namespace WebApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IService<UserDTO> _user;

        public UserController(IService<UserDTO> user)
        {
            _user = user;
        }



        // GET: api/<ActionController>
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _user.GetAll();
        }

        // GET api/<ActionController>/5
        [HttpGet("{id}")]
        public async Task<UserDTO> GetUsers(int id)
        {
            return await _user.GetById(id);
        }

        // POST api/<ActionController>
        [HttpPost]
        public async Task<UserDTO> AddUser([FromBody] UserModel postModel)
        {
            UserDTO newOne = new UserDTO();

            newOne.Tz = postModel.Tz;
            newOne.DateOfBirdth = postModel.DateOfBirdth;
            newOne.Fname = postModel.Fname;
            newOne.Lname = postModel.Lname;
            //newOne.Id = postModel.Id;
            newOne.Min = postModel.Min;
            newOne.Hmo = postModel.Hmo;
            return await _user.Add(newOne);
        }
    }

}
