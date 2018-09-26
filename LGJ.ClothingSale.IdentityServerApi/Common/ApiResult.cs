using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LGJ.ClothingSale.IdentityServerApi.Common
{
    public class ApiResult
    {
        public ResultCode Code { get; set; } = ResultCode.Success;
        public string Message { get; set; }
    }
    public class ApiResult<T> : ApiResult
    {
        public T Data { get; set; }
    }
    public class ApiPagedResult<T> : ApiResult
    {
        public ApiPagedResult()
        {
            Data = new ApiPagedResultData<T>();
        }

        public ApiPagedResultData<T> Data { get; set; }
    }

    public class ApiPagedResultData<T>
    {
        public int TotalItems { get; set; }
        public ICollection<T> Items { get; set; }
    }
    public class Result
    {
        public static ApiResult Success()
        {
            return new ApiResult { Code = ResultCode.Success };
        }
        public static ApiResult<T> Success<T>(T data)
        {
            return new ApiResult<T> { Code = ResultCode.Success, Data = data };
        }
        public static ApiPagedResult<T> Success<T>(ICollection<T> items, int totalItems)
        {
            return new ApiPagedResult<T>()
            {
                Code = ResultCode.Success,
                Data = new ApiPagedResultData<T>()
                {
                    Items = items,
                    TotalItems = totalItems,
                }
            };
        }
        #region 失败
        public static ApiResult Failed()
        {
            return new ApiResult { Code = ResultCode.Failed };
        }
        public static ApiResult Failed(string message)
        {
            return new ApiResult { Code = ResultCode.Failed, Message = message };
        }
        public static ApiResult Failed(ResultCode code)
        {
            return new ApiResult { Code = code };
        }
        public static ApiResult Failed(ResultCode code, string message)
        {
            return new ApiResult { Code = code, Message = message };
        }
        public static ApiResult<T> Failed<T>()
        {
            return new ApiResult<T> { Code = ResultCode.Failed, Data = default(T) };
        }
        public static ApiResult<T> Failed<T>(string message)
        {
            return new ApiResult<T> { Code = ResultCode.Failed, Message = message, Data = default(T) };
        }
        public static ApiResult<T> Failed<T>(ResultCode code)
        {
            return new ApiResult<T> { Code = code, Data = default(T) };
        }
        public static ApiResult<T> Failed<T>(ResultCode code, string message)
        {
            return new ApiResult<T> { Code = code, Message = message, Data = default(T) };
        }
        public static ApiResult<T> Failed<T>(ResultCode code, T data)
        {
            return new ApiResult<T> { Code = code, Data = data };
        }
        public static ApiResult<T> Failed<T>(ResultCode code, string message, T data)
        {
            return new ApiResult<T> { Code = code, Message = message, Data = data };
        }
        public static ApiPagedResult<T> Failed<T>(ResultCode code, string message, ICollection<T> items = null, int totalItems = 0)
        {
            return new ApiPagedResult<T>()
            {
                Code = code,
                Message = message,
                Data = new ApiPagedResultData<T>()
                {
                    Items = items,
                    TotalItems = totalItems,
                }
            };
        }
        #endregion
        #region 异常
        public static ApiResult Exception()
        {
            return new ApiResult { Code = ResultCode.Exception };
        }
        public static ApiResult Exception(string message)
        {
            return new ApiResult { Code = ResultCode.Exception, Message = message };
        }
        public static ApiResult<T> Exception<T>()
        {
            return new ApiResult<T> { Code = ResultCode.Exception, Data = default(T) };
        }
        public static ApiResult<T> Exception<T>(string message)
        {
            return new ApiResult<T> { Code = ResultCode.Exception, Message = message, Data = default(T) };
        }
        public static ApiResult<T> Exception<T>(T data)
        {
            return new ApiResult<T> { Code = ResultCode.Exception, Data = data };
        }
        public static ApiResult<T> Exception<T>(string message, T data)
        {
            return new ApiResult<T> { Code = ResultCode.Exception, Message = message, Data = data };
        }
        public static ApiPagedResult<T> Exception<T>(string message, ICollection<T> items = null, int totalItems = 0)
        {
            return new ApiPagedResult<T>()
            {
                Code = ResultCode.Exception,
                Message = message,
                Data = new ApiPagedResultData<T>()
                {
                    Items = items,
                    TotalItems = totalItems,
                }
            };
        }
        #endregion
    }
}
