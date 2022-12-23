using RestAPIAutomationBL.Models.Responses;
using RestAPIAutomationBL.Utilities.CommonMethod;
using RestAPIAutomationFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIAutomationBL.Utilities
{
    public class PatchUtil
    {
        public static Response MakePatchRequest(string author)
        {
            return RestClientUtilities.Put<Response>
                ("posts/11", CreateRequestBody.CreatePostRequestBody(id, title, author));
        }
    }
}
