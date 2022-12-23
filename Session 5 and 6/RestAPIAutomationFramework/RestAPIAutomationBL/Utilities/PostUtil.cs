using Newtonsoft.Json;
using RestAPIAutomationBL.Models.Requests;
using RestAPIAutomationBL.Models.Responses;
using RestAPIAutomationBL.Utilities.CommonMethod;
using RestAPIAutomationFramework.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIAutomationBL.Utilities
{
    public class PostUtil
    {
        public static Response CreatePost(int id, string title, string author)
        {
            return RestClientUtilities.Post<Response>
                ("posts", CreateRequestBody.CreatePostRequestBody(id, title, author));
        }
    }
}
