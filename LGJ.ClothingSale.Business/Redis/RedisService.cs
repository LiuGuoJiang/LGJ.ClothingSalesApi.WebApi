using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeihanLi.Redis;

namespace LGJ.ClothingSale.Business.Redis
{
    public class RedisService:IRedisService
    {
        public async Task<string> TestRedisForGet(string key)
        {
            string value = string.Empty;
            var isExists = RedisManager.CacheClient.Exists(key);
            if (isExists)
            {
                var result = await RedisManager.CacheClient.GetAsync(key);
                value=result;
            }
            else
            {
                var result = await RedisManager.CacheClient.SetAsync(key, "This is a test demo");
                if (result)
                {
                    value = await RedisManager.CacheClient.GetAsync(key);
                }
            }
            return value;
        }
    }
}
