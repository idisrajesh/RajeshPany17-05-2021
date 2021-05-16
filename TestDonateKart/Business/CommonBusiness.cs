using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TestDonateKart.Models;

namespace TestDonateKart.Business
{
    public class CommonBusiness
    {

        public static JsonResult GetErrorResponse(string errorMessage = "There is some error in server side")
        {
            return new JsonResult
            {
                Data = new ErrorRespnoseWrapper
                {
                    Status =(int) HttpStatusCode.OK,
                    ErrorMessage = errorMessage
                }
            };
        }
    }
}