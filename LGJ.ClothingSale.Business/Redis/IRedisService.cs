using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LGJ.ClothingSale.Business.Redis
{
    public interface IRedisService
    {
        Task<string> TestRedisForGet(string key);
    }
}
