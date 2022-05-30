using Microsoft.AspNetCore.Mvc;
using PCAssesmentApp.BaseResponse;
using PCAssesmentApp.Dto;
using PCAssesmentApp.Repository;
using System;
using System.Threading.Tasks;

namespace PCAssessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserService IUserService { get; }

        public UserController(IUserService userService )
        {
            IUserService = userService;
        }

        // GET: api/<UserController>
        /*     [Route("GetAllUsers")]*/
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var status = await IUserService.GetAllUser();
                return Ok(status);
            }
            catch (Exception)
            {
                return StatusCode(500, new BaseResponses(false, Responses.ServerError));
            }
        }

        // GET api/<UserController>/5
        /*  [Route("GetSingleUser")]*/
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleUser(int id)
        {
            try
            {
                var status = await IUserService.GetSingleUser(id);
                return Ok(status);
            }
            catch (Exception)
            {
                return StatusCode(500, new BaseResponses(false, Responses.ServerError));
            }
        }

        // POST api/<UserController>
        /*     [Route("CreateUser")]*/
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDto model)
        {
            try
            {
                var status = await IUserService.CreateUser(model);
                return Ok(status);
            }
            catch (Exception)
            {
                return StatusCode(500, new BaseResponses(false, Responses.ServerError));
            }
        }


    }
}
