using LGJ.ClothingSale.Models.ClothingOrder.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LGJ.ClothingSale.Business.Services.ClothingOrders
{
    public interface IClothingOrderService
    {
        Task<GetAllClothingOrdersReponse> GetAllClothingOrdersAsync();
        Task<GetClothingOrderByIdResponse> GetClothingOrderByIdAsync(int id);
        Task<bool> DeleteClothingOrderById(int id);
    }
}
