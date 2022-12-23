using RestAPIAutomationFramework.Utilities;
using RestAPIAutomationBL.Models.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIAutomationBL.Utilities
{
    public class GetUtil
    {
        public static T[] GetPosts<T>()
        {
            return RestClientUtilities.Get<T>("posts");
        }
    }
}