using System;
using System.Collections.Generic;
using System.Text;
using Api.ServiceModel.Request;
using ServiceStack;

namespace Api.ServiceInterface.Services
{
    public class HelloService : Service
    {
        public string Get(HelloRequest request)
        {
            return $"Hello {request.Name}";
        }
    }
}
