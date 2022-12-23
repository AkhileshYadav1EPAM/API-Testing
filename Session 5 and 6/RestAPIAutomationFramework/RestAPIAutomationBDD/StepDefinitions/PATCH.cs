using NUnit.Framework;
using RestAPIAutomationBL.Models.Responses;
using RestAPIAutomationBL.Utilities;

namespace RestAPIAutomationBDD.StepDefinitions
{
    [Binding]
    public sealed class PATCH
    {
        private Response response;

        [Given(@"I updated a new post using id author '([^']*)'")]
        public void GivenIUpdatedANewPostUsingIdAuthor(string author
        {
            response = PatchUtil.MakePatchRequest(author);
        }

        [Then(@"I should be able to update the post with author '([^']*)'")]
        public void ThenIShouldBeAbleToUpdateThePostWithAuthor(string author)
        {
           
        }
    }
}