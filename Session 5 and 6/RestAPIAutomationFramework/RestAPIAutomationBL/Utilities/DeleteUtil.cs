using RestAPIAutomationFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIAutomationBL.Utilities
{
    public class DeleteUtil
    {
        public static bool DeletePost(int id)
        {
            return RestClientUtilities.Delete("posts/" + id.ToString(), HttpStatusCode.OK);
        }
    }
}
