using System;
using System.Collections.Generic;
using System.Text;

namespace Api.ServiceInterface.Services
{
    using Api.ServiceModel.Requests;
    using Api.ServiceModel.Responses;

    using ServiceStack;
    using ServiceStack.Templates;

    public class TestService : Service
    {
        public object Get(TestGetRequest request)
        {
            var baseUrl = "http://localhost:54355";

            var client = new JsonServiceClient(baseUrl);

            var r = new HelloRequest { Name = "test" };

            var result = client.Get(r);

            return result;
        }
    }
}
