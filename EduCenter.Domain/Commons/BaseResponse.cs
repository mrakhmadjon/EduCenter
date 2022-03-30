﻿using Newtonsoft.Json;

namespace EduCenter.Domain.Commons
{
    public class BaseResponse<T>
    {
        [JsonIgnore]
        public int? Code { get; set; } = 200;

        public T Data { get; set; }

        public ErrorResponse Error { get; set; }
    }
}
