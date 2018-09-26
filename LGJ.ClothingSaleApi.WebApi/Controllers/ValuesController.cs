using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LGJ.ClothingSale.Business.Services.ClothingOrders;
using LGJ.ClothingSale.Models.ClothingOrder.Responses;
using LGJ.ClothingSaleApi.WebApi.Common;
using LGJ.ClothingSaleApi.WebApi.Filters;
using Microsoft.AspNetCore.Mvc;

namespace LGJ.ClothingSaleApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ClothingSaleFilter(nameof(ValuesController))]
    public class ValuesController : ControllerBase
    {
        private readonly IClothingOrderService _clothingOrderService;
        public ValuesController(IClothingOrderService clothingOrderService)
        {
            _clothingOrderService = clothingOrderService;
        }
        // GET api/values
        [HttpGet]
        public async Task<ApiResult<GetAllClothingOrdersReponse>> GetAsync()
        {
            var result=await _clothingOrderService.GetAllClothingOrdersAsync();
            return Result.Success(result);
        }

        // GET api/values/5
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
