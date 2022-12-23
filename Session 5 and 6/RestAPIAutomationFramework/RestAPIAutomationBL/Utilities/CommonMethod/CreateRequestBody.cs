using Newtonsoft.Json;
using RestAPIAutomationBL.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIAutomationBL.Utilities.CommonMethod
{
    public class CreateRequestBody
    {
        public static string CreatePostRequestBody(int id, string title, string author)
        {
            Request request = new Request();
            request.id = id;
            request.title = title;
            request.author = author;

            return JsonConvert.SerializeObject(request);
        }
    }
}
