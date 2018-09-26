using LGJ.ClothingSale.IdentityServerApi.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LGJ.ClothingSale.IdentityServerApi.Filters
{
    /// <summary>
    /// 服装批发接口过滤器
    /// </summary>
    public class IdentityServerFilterAttribute : TypeFilterAttribute
    {
        public IdentityServerFilterAttribute(string categoryName) : base(typeof(IdentityServerBusiness))
        {
            Arguments = new object[] { categoryName };
        }
        private class IdentityServerBusiness : IAsyncActionFilter, IAsyncExceptionFilter
        {
            private IDictionary<string, object> _actionArguments;

            private readonly ILogger _logger;
            public IdentityServerBusiness(ILoggerFactory loggerFactory, string categoryName)
            {
                _logger = loggerFactory.CreateLogger(categoryName);
            }

            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
            {
                //参数验证不通过，返回参数错误信息
                if (!context.ModelState.IsValid)
                {
                    var errorMessage = new List<string>();
                    foreach (var key in context.ModelState.Keys)
                    {
                        var state = context.ModelState[key];
                        var errorModel = state?.Errors?.First();
                        if (errorModel != null)
                        {
                            errorMessage.Add($"{key}:{errorModel.ErrorMessage}");
                        }
                    }

                    var val = new ApiResult()
                    {
                        Code = ResultCode.ArgumentError,
                        Message = string.Join(',', errorMessage)
                    };
                    context.Result = new ObjectResult(val);
                    return;
                }
                // 临时保存一下，为了如果异常的时候可以使用
                _actionArguments = context.ActionArguments;

                await next();
            }
            public async Task OnExceptionAsync(ExceptionContext context)
            {
                var type = context.Exception.GetType();

                //ExceptionMonitor.AddWebException(_logger, context.HttpContext.Request, _actionArguments,
                        //ShopModule.ShopStock, context.Exception, context.ActionDescriptor.DisplayName);
                context.Result =
                    new ObjectResult(
                        Result.Exception($"{context.ActionDescriptor.RouteValues["action"]} Exception"));

                await Task.CompletedTask;
            }
        }
    }
}
