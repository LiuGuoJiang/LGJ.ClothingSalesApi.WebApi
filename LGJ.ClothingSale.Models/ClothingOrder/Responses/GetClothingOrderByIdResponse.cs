using LGJ.ClothingSale.Models.ClothingOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGJ.ClothingSale.Models.ClothingOrder.Responses
{
    public class GetClothingOrderByIdResponse
    {
        public ClothingOrderDto OrderInfo { get; set; }
    }
}
