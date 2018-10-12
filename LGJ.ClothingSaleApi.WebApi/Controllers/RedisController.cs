using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGJ.ClothingSale.Business.Redis;
using LGJ.ClothingSaleApi.WebApi.Common;
using LGJ.ClothingSaleApi.WebApi.Filters;
using Microsoft.AspNetCore.Mvc;

namespace LGJ.ClothingSaleApi.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ClothingSaleFilter(nameof(RedisController))]
    public class RedisController : ControllerBase
    {
        private readonly IRedisService _redisService;

        public RedisController(IRedisService redisService)
        {
            _redisService = redisService;
        }
        public async Task<ApiResult<string>> TestRedisForGet()
        {
            var key = "myfirstkey";
            var result =await _redisService.TestRedisForGet(key);
            return Result.Success(result);
        }
    }
}