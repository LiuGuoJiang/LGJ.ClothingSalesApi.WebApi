using System;
using System.Collections.Generic;
using System.Text;
using LGJ.Data.DapperExtensions.Attributes;

namespace LGJ.ClothingSale.DataAccess.Models
{
    [Table("ClothingOrders")]
    public class ClothingOrder
    {
        public ClothingOrder()
        {
            CreationTime = DateTime.Now;
        }
        [Key]
        public int Id{ get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string UserPhone { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public string OrderState { get; set; }
        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { get; set; }
        /// <summary>
        /// 订单渠道
        /// </summary>
        public string OrderChannel { get; set; }
        /// <summary>
        /// 地址ID
        /// </summary>
        public int AddressId { get; set; }
        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime OrderDateTime { get; set; }
        /// <summary>
        /// 预约取货时间
        /// </summary>
        public DateTime BookDateTime { get; set; }
        /// <summary>
        /// 订单总金额
        /// </summary>
        public decimal SumMoney { get; set; }
        /// <summary>
        /// 折扣总金额
        /// </summary>
        public decimal SumDisMoney { get; set; }
        /// <summary>
        /// 物流类型
        /// </summary>
        public string DeliveryType { get; set; }
        /// <summary>
        /// 物流单号
        /// </summary>
        public string DeliveryCode { get; set; }
        /// <summary>
        /// 物流状态
        /// </summary>
        public string DeliveryState { get; set; }
        /// <summary>
        /// 付款状态
        /// </summary>
        public string PayState { get; set; }
        /// <summary>
        /// 付款总金额
        /// </summary>
        public decimal SumPaid { get; set; }
        /// <summary>
        /// 付款方式
        /// </summary>
        public string PayMethod { get; set; }
        /// <summary>
        /// 付款日期
        /// </summary>
        public DateTime? PayDateTime { get; set; }
        /// <summary>
        /// 评论状态
        /// </summary>
        public string CommentState { get; set; }
        /// <summary>
        /// 订单产品关联Id
        /// </summary>
        public int ClothingOrderListId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string CreationBy { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public string UpdateBy { get; set; }
    }
}
