﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Api.ServiceInterface.Services
{
    using Api.ServiceModel.Requests;
    using Api.ServiceModel.Responses;
    using Api.ServiceModel.Setting;

    using ServiceStack;
    using ServiceStack.Templates;

    public class TestService : Service
    {
        public AppSettings settings { get; set; }

        public object Get(TestGetRequest request)
        {
            var baseUrl = "http://localhost:54355";

            var client = new JsonServiceClient(baseUrl);

            var setting = this.settings;

            var result = client.Get(new HelloRequest { Name = "test" });

            return result;
        }
    }
}
