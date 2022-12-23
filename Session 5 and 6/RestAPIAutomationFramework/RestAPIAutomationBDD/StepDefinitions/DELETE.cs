using NUnit.Framework;
using RestAPIAutomationBL.Utilities;

namespace RestAPIAutomationBDD.StepDefinitions
{
    [Binding]
    public sealed class DELETE
    {
        private bool isDeleted;

        [When(@"I delete the post with id '([^']*)', title '([^']*)' and author '([^']*)'")]
        public void WhenIDeleteThePostWithIdTitleAndAuthor(int id, string title, string author)
        {
            isDeleted = DeleteUtil.DeletePost(id);
        }

        [Then(@"I should be able to delete the post with '([^']*)', title '([^']*)' and author '([^']*)'")]
        public void ThenIShouldBeAbleToDeleteThePostWithTitleAndAuthor(int id, string title, string author)
        {
            Assert.IsTrue(isDeleted);
        }
    }
}