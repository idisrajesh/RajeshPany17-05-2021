using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDonateKart.Models
{
    public class ApiResponseWrapper
    {

        public int Status { get; set; }
        public int Data { get; set; }
        public int TotalCount { get; set; }
    }

    public class ErrorRespnoseWrapper
    {
        public int Status { get; set; }
        public string ErrorMessage { get; set; }

    }
}