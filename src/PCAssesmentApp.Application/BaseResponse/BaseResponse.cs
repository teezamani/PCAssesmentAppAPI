using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCAssesmentApp.BaseResponse
{
    public class BaseResponses
    {
        public BaseResponses(bool status = false, string message = null, object response = null)
        {
            Status = status;
            Message = message;
            Data = response;
        }

        public bool Status { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}
