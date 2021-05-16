using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDonateKart.Models;
using TestDonateKart.Utils;

namespace TestDonateKart.Business
{
    public class CampaingnsBs
    {
        
        public List<CampaignListResult> GetAllCampaigns()
        {
            var CampainList = new CallExternalAPI().CallGETApi<IEnumerable<Campaigns>>(CampainEndPoints.testCampaingn);
            var result = CampainList.OrderByDescending(x => x.totalAmount).Select(x => new CampaignListResult
            {
                TotalAmount = x.totalAmount,
                BackersCount = x.backersCount,
                Title = x.title,
                EndDate = x.endDate
            }).ToList();

            return result;
        }

        public List<Campaigns> GetAllActiveCampaign(int date = 30)
        {
            DateTime beforeDate = DateTime.Now.AddDays(-(date));
            var CampaingnList = new CallExternalAPI().CallGETApi<IEnumerable<Campaigns>>(CampainEndPoints.testCampaingn);
            var result = CampaingnList.Where(x =>Convert.ToDateTime(x.endDate)>=DateTime.Now && Convert.ToDateTime(x.created) >= beforeDate).ToList();
            return result;
        }

        public List<Campaigns> GetAllCloseCampaingn()
        {
            DateTime today = DateTime.Now;
            var CampaingnList = new CallExternalAPI().CallGETApi<IEnumerable<Campaigns>>(CampainEndPoints.testCampaingn);
            var result = CampaingnList.Where(x => Convert.ToDateTime(x.endDate) <= today || x.procuredAmount >= x.totalAmount)
            .ToList();
            return result;
        }


    }
}