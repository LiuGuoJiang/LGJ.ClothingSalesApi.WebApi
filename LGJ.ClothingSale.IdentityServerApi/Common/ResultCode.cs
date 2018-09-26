using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LGJ.ClothingSale.IdentityServerApi.Common
{
    public enum ResultCode
    {
        Success = 10000,
        ArgumentError = 10001,
        Failed = 10002,
        Exception = 10003,
        //
        // 摘要:
        //     用户服务无权限
        PERMISSION_DENY = 10004,
        //
        // 摘要:
        //     身份认证过期
        AUTHENTICATION_EXPIRED = 10005,
        //
        // 摘要:
        //     记录已存在
        SUCCESS_EXIST = 10006,
        //
        // 摘要:
        //     账号不存在
        SUCCESS_ACOUNT_NOT_EXIST = 10007,
        //
        // 摘要:
        //     IP限制
        IP_LIMIT = 10008,
        //
        // 摘要:
        //     参数错误
        PARAM_ERROR = 10009,
        //
        // 摘要:
        //     参数为空
        PARAM_IS_NULL = 10010,
        //
        // 摘要:
        //     用户权限不足
        INSUFFICIENT_USER_PERMISSIONS = 10011,
        //
        // 摘要:
        //     方法名不存在
        INVALID_METHOD = 10012,
        //
        // 摘要:
        //     请求的方法名不存在
        REQUEST_API_NOT_FOUND = 10013,
        //
        // 摘要:
        //     无效的数据格式
        INVALID_FORMAT = 10014,
        //
        // 摘要:
        //     缺少AppKey参数
        MISSING_APP_KEY = 10015,
        //
        // 摘要:
        //     非法的APP Key
        INVALID_APP_KEY = 10016,
        //
        // 摘要:
        //     无效的access token
        INVALID_ACCESS_TOKEN = 10017,
        //
        // 摘要:
        //     用户不存在
        USER_DOES_NOT_EXISTS = 10018,
        //
        // 摘要:
        //     内容为空
        CONTENT_IS_NULL = 10019,
        //
        // 摘要:
        //     包含非法内容
        CONTENT_IS_ILLEGAL = 10020,
        //
        // 摘要:
        //     验证失败
        AUTH_FAILD = 10021,
        //
        // 摘要:
        //     非法操作
        ILLEGAL_OPERATION = 10022,
        //
        // 摘要:
        //     用户名或者密码错误
        USERNAME_OR_PASSWORD_ERROR = 10023,
        //
        // 摘要:
        //     操作失败
        OPERATION_FAILED = 10024,
        //
        // 摘要:
        //     系统异常
        SYSTEM_ERROR = 10025,
        //
        // 摘要:
        //     调用服务异常
        CALLSERVICCE_ERROR = 10026,
        //
        // 摘要:
        //     版本号错误
        VERSION_ERROR = 10027,
        //
        // 摘要:
        //     记录不存在
        SUCCESS_NOT_EXIST = 10031,
        //
        // 摘要:
        //     该手机号已经被使用
        PHONE_NUMBER_HAS_BEEN_USED = 10032,
        //
        // 摘要:
        //     不需要执行
        NO_NEED_EXECUTE = 11000
    }
}
