namespace Api.ServiceModel.Requests
{
    using System.ComponentModel;

    using ServiceStack;

    /// <summary>
    /// Test service
    /// </summary>
    [Route("/test", Verbs = "GET"), Description("this is a test")]
    public class TestGetRequest
    {
    }
}
