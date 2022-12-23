using NUnit.Framework;
using RestAPIAutomationBL.Models.Responses;
using RestAPIAutomationBL.Utilities;

namespace RestAPIAutomationBDD.StepDefinitions
{
    [Binding]
    public sealed class POST
    {
        private Response response;

        [Given(@"I create a new post using id '([^']*)', title '([^']*)' and author '([^']*)'")]
        public void GivenICreateANewPostUsingIdTitleAndAuthor(int id, string title, string author)
        {
            response = PostUtil.CreatePost(id, title, author);
        }

        [Then(@"I should be able to post the post with id '([^']*)', title '([^']*)' and author '([^']*)'")]
        public void ThenIShouldBeAbleToPostThePostWithIdTitleAndAuthor(int id, string title, string author)
        {
            Assert.AreEqual(id, response.id);
            Assert.AreEqual(title, response.title);
            Assert.AreEqual(author, response.author);
        }
    }
}