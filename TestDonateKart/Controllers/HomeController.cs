using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Net;
using TestDonateKart.Business;
using System.Web.Mvc;

namespace TestDonateKart.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult GetAllCampaigns()
        {
            try
            {
                var result = new CampaingnsBs().GetAllCampaigns();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return CommonBusiness.GetErrorResponse();
            }
        }

        public JsonResult GetAllActiveCampaign(int id=30)
        {
            try
            {
                var result = new CampaingnsBs().GetAllActiveCampaign(id);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return CommonBusiness.GetErrorResponse();
            }
        }

        public JsonResult GetAllCloseCampaingn()
        {
            try
            {
                var result = new CampaingnsBs().GetAllCloseCampaingn();
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return CommonBusiness.GetErrorResponse();
            }
        }
    }
}
