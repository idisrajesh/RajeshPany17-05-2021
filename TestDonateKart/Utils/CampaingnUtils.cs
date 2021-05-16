using System;
using System.Configuration;

namespace TestDonateKart.Utils
{
    public class CampaingnUtils
    {
        public  static string TestCampaingnAPI {
            get
            {
                return ConfigurationManager.AppSettings[CampaingnConfigKey.TestCampaingnAPI].Trim();
            }
        }

    }

    public enum CampainEndPoints
    {
        testCampaingn = 0
    }

    public struct CampaingnConfigKey
    {
        public const string TestCampaingnAPI = "TestCampaingnAPIEndPoint";
    }
}