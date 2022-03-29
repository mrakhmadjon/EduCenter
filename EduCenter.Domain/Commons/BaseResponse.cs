using Newtonsoft.Json;

namespace EduCenter.Domain.Commons
{
    public class BaseResponse<T>
    {
        [JsonIgnore]
        public int? Code { get; set; }

        public T Data { get; set; }

        public ErrorResponse Error { get; set; }
    }
}
