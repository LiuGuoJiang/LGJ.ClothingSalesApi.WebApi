using LGJ.ClothingSale.Models.ClothingOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGJ.ClothingSale.Models.ClothingOrder.Responses
{
    public class GetAllClothingOrdersReponse
    {
        public GetAllClothingOrdersReponse()
        {
            ClothingOrderInfo = new List<ClothingOrderDto>();
        }
        public List<ClothingOrderDto> ClothingOrderInfo { get; set; }
    }
}
