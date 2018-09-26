using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace LGJ.ClothingSaleApi.WebApi.Common
{
    public class ApiRequest<T> : ApiRequest
    {
        [Description("请求的具体参数")]
        public T Data { get; set; }
    }
    public class ApiRequest
    {
        [Description("请求渠道，安卓:a-xxx,IOS:ios-xxx,PC:pc")]
        public string Channel { get; set; }

        [Description("版本号，例如：1.0")]
        public string ApiVersion { get; set; }

        [Description("设备号")]
        public string DeviceId { get; set; }
    }
}
