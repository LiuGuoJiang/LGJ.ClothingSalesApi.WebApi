using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LGJ.ClothingSale.Models.ClothingOrder.Requests
{
    public class DeleteInput
    {
        [Range(1, Int32.MaxValue, ErrorMessage = "删除id不合法")]
        public int Id { get; set; }
    }
}
