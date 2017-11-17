using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;

namespace Api.ServiceModel.Request
{
    [Route("/hello/{Name}", Verbs = "Get")]
    public class HelloRequest : IReturn<string>
    {
        /// <summary>
        /// Gets or sets the name of hello
        /// </summary>
        public string Name { get; set; }
    }
}
