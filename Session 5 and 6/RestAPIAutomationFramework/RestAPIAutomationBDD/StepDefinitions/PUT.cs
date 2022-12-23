using NUnit.Framework;
using RestAPIAutomationBL.Models.Responses;
using RestAPIAutomationBL.Utilities;

namespace RestAPIAutomationBDD.StepDefinitions
{
    [Binding]
    public sealed class PUT
    {
        private Response response;

        [Given(@"I updated a new post using id '([^']*)', title '([^']*)' and author '([^']*)'")]
        public void GivenIUpdatedANewPostUsingIdTitleAndAuthor(int id, string title, string author)
        {
            response = PutUtil.MakePutRequest(id, title, author);
        }

        [Then(@"I should be able to update the post with id '([^']*)', title '([^']*)' and author '([^']*)'")]
        public void ThenIShouldBeAbleToUpdateThePostWithIdTitleAndAuthor(int id, string title, string author)
        {
            Assert.AreEqual(id, response.id);
            Assert.AreEqual(title, response.title);
            Assert.AreEqual(author, response.author);
        }
    }
}