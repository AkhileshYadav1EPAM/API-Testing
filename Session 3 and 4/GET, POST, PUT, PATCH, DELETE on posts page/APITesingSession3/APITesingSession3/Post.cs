using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace APITestingSession3
{
    public class Post
    {
        public string localHostURL = "http://localhost:3000/";

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void RetrievingTheResourcesInPosts()
        {
            RestClient restClient = new RestClient(localHostURL);

            RestRequest restRequest = new RestRequest("posts", Method.Get);
            //restRequest.AddQueryParameter("id", "1");
            restRequest.AddHeader("Accept", "*/*");

            RestResponse response = restClient.Execute(restRequest);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            string responseContent = response.Content;

            var responseInDeSerialForm = JsonConvert
                                         .DeserializeObject<ValidationOfRetrievePostResponse[]>
                                         (responseContent);

            Assert.AreEqual(1, responseInDeSerialForm[0].id);
            Assert.AreEqual("json-server", responseInDeSerialForm[0].title);
            Assert.AreEqual("typicode", responseInDeSerialForm[0].author);

            Assert.AreEqual(2, responseInDeSerialForm[1].id);
            Assert.AreEqual("json-server", responseInDeSerialForm[1].title);
            Assert.AreEqual("typicode", responseInDeSerialForm[1].author);
        }

        [Test]
        public void CreatingTheResourcesInPosts()
        {
            RestClient restClient = new RestClient(localHostURL);

            RestRequest restRequest = new RestRequest("posts", Method.Post);
            //restRequest.AddQueryParameter("id", "3");
            restRequest.AddHeader("Accept", "*/*");

            string requestBody = CreatePostRequestBody(4, "Harry", "J K");
            restRequest.AddBody(requestBody);

            RestResponse response = restClient.Execute(restRequest);

            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);
            string responseContent = response.Content;

            var responseInDeSerialForm = JsonConvert
                                         .DeserializeObject<CreatePostValidResponse>
                                         (responseContent);

            Assert.AreEqual(4, responseInDeSerialForm.id);
            Assert.AreEqual("Harry", responseInDeSerialForm.title);
            Assert.AreEqual("J K", responseInDeSerialForm.author);
        }

        private string CreatePostRequestBody(int id, string title, string author)
        {
            CreatePostValidRequest createPostValidRequest = new CreatePostValidRequest();
            createPostValidRequest.id = id;
            createPostValidRequest.title = title;
            createPostValidRequest.author = author;

            return JsonConvert.SerializeObject(createPostValidRequest);
        }

        [Test]
        public void ModifyPost()
        {
            RestClient restClient = new RestClient(localHostURL);

            RestRequest restRequest = new RestRequest("posts/3", Method.Put);
            //restRequest.AddQueryParameter("id", "3");
            restRequest.AddHeader("Accept", "*/*");

            string requestBody = CreatePostRequestBody(3, "Harry Potter and Goblet", "J K Rollin");
            restRequest.AddBody(requestBody);

            RestResponse response = restClient.Execute(restRequest);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            string responseContent = response.Content;

            var responseInDeSerialForm = JsonConvert
                                         .DeserializeObject<UpdatePostValidResponse>
                                         (responseContent);

            Assert.AreEqual(3, responseInDeSerialForm.id);
            Assert.AreEqual("Harry Potter and Goblet", responseInDeSerialForm.title);
            Assert.AreEqual("J K Rollin", responseInDeSerialForm.author);
        }

        [Test]
        public void DeletePost()
        {
            RestClient restClient = new RestClient(localHostURL);

            RestRequest restRequest = new RestRequest("posts/3", Method.Delete);
            //restRequest.AddQueryParameter("id", "3");
            restRequest.AddHeader("Accept", "*/*");

            RestResponse response = restClient.Execute(restRequest);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            string responseContent = response.Content;
        }
    }
}