﻿using Newtonsoft.Json;
namespace Domain.Entity
{
    public class BaseResponse
    {
        public BaseResponse(bool status, string code, string message, string field = "", int count = 0, object response = null)
        {
            Status = status;
            Code = code;
            Message = message;
            Field = field;
            Count = count;
            this.Response = response;
        }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        public int Count { get; set; }
        public object Response { get; set; }
    }
}