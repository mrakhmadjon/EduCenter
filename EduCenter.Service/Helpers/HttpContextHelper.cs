using Microsoft.AspNetCore.Http;

namespace EduCenter.Service.Helpers
{
    public class HttpContextHelper
    {

        public static IHttpContextAccessor Accessor;
        public static HttpContext Context => Accessor?.HttpContext;
        public static IHeaderDictionary ResponseHeaders => Context?.Response?.Headers;
    }
}
