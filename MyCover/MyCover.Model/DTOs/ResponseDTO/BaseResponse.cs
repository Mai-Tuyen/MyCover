using System;
using System.Collections.Generic;
using System.Text;

namespace MyCover.Model.DTOs
{
    public class BaseResponse
    {
        public int StatusCode { get; set; } = 200;
        public List<OutputDetail> ValidationErrors { get; set; }
        public bool IsError { get; set; } = false;
        public string Message { get; set; }
    }
}
