using AutoMapper;
using LGJ.ClothingSale.DataAccess.Models;
using LGJ.ClothingSale.Models.ClothingOrder.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace LGJ.ClothingSale.Business.Mappers
{
    public class OrderProfile:Profile
    {
        public OrderProfile()
        {
            CreateMap<ClothingOrder, ClothingOrderDto>();
            CreateMap<ClothingOrderDto, ClothingOrder>();
        }
    }
}
