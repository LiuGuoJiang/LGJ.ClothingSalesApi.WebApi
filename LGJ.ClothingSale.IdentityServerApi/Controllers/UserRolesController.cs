using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGJ.ClothingSale.IdentityServerApi.Common;
using LGJ.ClothingSale.IdentityServerApi.Filters;
using LGJ.ClothingSale.Models.Auth.Dto;
using LGJ.ClothingSale.Models.Auth.Response;
using Microsoft.AspNetCore.Mvc;

namespace LGJ.ClothingSale.IdentityServerApi.Controllers
{
    [Route("identity/[controller]/[action]")]
    [ApiController]
    [IdentityServerFilter(nameof(UserRolesController))]
    public class UserRolesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ApiResult<GetUserInfoResponse> GetUserInfo(string userName, string password)
        {
            var user = new UserDto()
            {
                UserName = "super_admin",
                UserId = "1",
                UserAccess = new List<string>()
                {
                    "admin",
                    "super_admin"
                },
                UserToken = "super_admin",
                UserAvator = "https://file.iviewui.com/dist/a0e88e83800f138b94d2414621bd9704.png"
            };
            var response = new GetUserInfoResponse();
            response.UserInfo = user;
            return Result.Success(response);
        }
        [HttpGet]
        public ApiResult<GetUserInfoResponse> Login(string userName, string password)
        {
            var user = new UserDto()
            {
                UserName = "super_admin",
                UserId = "1",
                UserAccess = new List<string>()
                {
                    "admin",
                    "super_admin"
                },
                UserToken = "super_admin",
                UserAvator = "https://file.iviewui.com/dist/a0e88e83800f138b94d2414621bd9704.png"
            };
            var response = new GetUserInfoResponse();
            response.UserInfo = user;
            return Result.Success(response);
        }

        //GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
