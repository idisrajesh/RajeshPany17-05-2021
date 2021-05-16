using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDonateKart.Models
{
    public class Campaigns
    {
        public string code { get; set; }
        public string title { get; set; }
        public string shortDesc { get; set; }
        public string imageSrc { get; set; }
        public string created { get; set; }
        public string endDate { get; set; }
        public double totalAmount { get; set; }
        public double procuredAmount { get; set; }
        public double totalProcured { get; set; }
        public double backersCount { get; set; }
        public string ngoCode { get; set; }
        public long categoryId { get; set; }
        public long daysLeft { get; set; }
        public float percentage { get; set; }
        public string ngoName { get; set; }
    }

    public class CampaignListResult
    {
        public String Title
        {
            get; set;
        }

        public double TotalAmount { get; set; }
        public double BackersCount { get; set; }
        public String EndDate { get; set; }
    }

}