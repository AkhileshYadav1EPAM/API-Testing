using NUnit.Framework;
using RestAPIAutomationBL.Models.Responses;
using RestAPIAutomationBL.Utilities;

namespace RestAPIAutomationBDD.StepDefinitions
{
    [Binding]
    public sealed class GET
    {
        Response[] responseInJsonForm;

        [Given(@"I requested a get all posts request")]
        public void GivenIRequestedAGetAllPostsRequest()
        {
            responseInJsonForm = GetUtil.GetPosts<Response>();
        }

        [Then(@"I should be able to get the all posts")]
        public void ThenIShouldBeAbleToGetTheAllPosts(Table table)
        {
            for(var i = 0; i < responseInJsonForm.Length; i++)
            {
                Assert.AreEqual(table.Rows[i][0], responseInJsonForm[i].id.ToString());
                Assert.AreEqual(table.Rows[i][1], responseInJsonForm[i].title);
                Assert.AreEqual(table.Rows[i][2], responseInJsonForm[i].author);
            }
        }
    }
}