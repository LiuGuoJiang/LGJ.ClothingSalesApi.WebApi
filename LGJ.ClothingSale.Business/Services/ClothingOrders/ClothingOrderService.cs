using AutoMapper;
using LGJ.ClothingSale.DataAccess.Repositories.Orders;
using LGJ.ClothingSale.Models.ClothingOrder.Dto;
using LGJ.ClothingSale.Models.ClothingOrder.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LGJ.ClothingSale.DataAccess.Models;

namespace LGJ.ClothingSale.Business.Services.ClothingOrders
{
    public class ClothingOrderService : IClothingOrderService
    {
        #region private
        private readonly IMapper _mapper;
        private readonly ClothingOrderRepository _clothingOrderRepository;
        #endregion

        public ClothingOrderService(IMapper mapper, ClothingOrderRepository clothingOrderRepository)
        {
            _mapper = mapper;
            _clothingOrderRepository = clothingOrderRepository;
        }

        public async Task<GetAllClothingOrdersReponse> GetAllClothingOrdersAsync()
        {
            var response = new GetAllClothingOrdersReponse();
            var result = await _clothingOrderRepository.GetAllClothingOrdersAsync();
            response.ClothingOrderInfo = _mapper.Map<List<ClothingOrderDto>>(result);
            return response;
        }

        public async Task<GetClothingOrderByIdResponse> GetClothingOrderByIdAsync(int id)
        {
            var response = new GetClothingOrderByIdResponse();
            var result = await _clothingOrderRepository.GetClothingOrderByIdAsync(id);
            if (result != null)
            {
                response.OrderInfo = _mapper.Map<ClothingOrderDto>(result);
            }
            return response;
        }

        public async Task<bool> DeleteClothingOrderById(int id)
        {
            return await _clothingOrderRepository.DeleteClothingOrderByIdAsync(id);
        }

        //public async Task<bool> AddClothingOrder(ClothingOrderDto orderInfo)
        //{
        //    var clothingOrder = _mapper.Map<ClothingOrder>(orderInfo);
        //    return await _clothingOrderRepository.AddClothingOrder(orderInfo);
        //}
    }
}
