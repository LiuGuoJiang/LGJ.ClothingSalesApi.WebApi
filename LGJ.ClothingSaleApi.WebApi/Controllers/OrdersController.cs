using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using LGJ.ClothingSale.Business.Services.ClothingOrders;
using LGJ.ClothingSale.Models.ClothingOrder.Dto;
using LGJ.ClothingSale.Models.ClothingOrder.Requests;
using LGJ.ClothingSale.Models.ClothingOrder.Responses;
using LGJ.ClothingSaleApi.WebApi.Common;
using LGJ.ClothingSaleApi.WebApi.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LGJ.ClothingSaleApi.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [Authorize]
    [ApiController]
    [ClothingSaleFilter(nameof(OrdersController))]
    public class OrdersController : ControllerBase
    {
        private readonly IClothingOrderService _clothingOrderService;
        public OrdersController(IClothingOrderService clothingOrderService)
        {
            _clothingOrderService = clothingOrderService;
        }
        // GET api/orders
        [HttpGet]
        public async Task<ApiResult<GetAllClothingOrdersReponse>> GetAllClothingOrders()
        {
            var result=await _clothingOrderService.GetAllClothingOrdersAsync();
            return Result.Success(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ApiResult<GetClothingOrderByIdResponse>> GetClothingOrderById(int id)
        {
            var result = await _clothingOrderService.GetClothingOrderByIdAsync(id);
            return Result.Success(result);
        }

        // POST api/values
        //[HttpPost]
        //public async Task<ApiResult<bool>> AddClothingOrder([FromBody] ApiRequest<ClothingOrderDto> data)
        //{
            
        //}

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpPost]
        public async Task<ApiResult<bool>> Delete([FromForm] ApiRequest<int> data)
        {
            var result =await _clothingOrderService.DeleteClothingOrderById(data.Data);
            return Result.Success(result);
        }
    }
}
