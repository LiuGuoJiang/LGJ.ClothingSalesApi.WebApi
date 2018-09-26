using System;
using System.Collections.Generic;
using System.Text;

namespace LGJ.ClothingSale.Models.Auth.Dto
{
    public class UserDto
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 用户权限
        /// </summary>
        public List<string> UserAccess { get; set; }
        /// <summary>
        /// 用户token
        /// </summary>
        public string UserToken { get; set; }
        /// <summary>
        /// 用户token
        /// </summary>
        public string UserAvator { get; set; }
    }
}
