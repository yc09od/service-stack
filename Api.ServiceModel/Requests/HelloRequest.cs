using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;

namespace Api.ServiceModel.Requests
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    using Api.ServiceModel.Responses;

    /// <summary>
    /// Hello request
    /// </summary>
    [Route("/hello/{Name}", Verbs = "GET"), Description("This is the test service")]
    public class HelloRequest : IReturn<HelloResponse>
    {
        /// <summary>
        /// Gets or sets the name of hello
        /// </summary>
        [ApiMember(Description = "Name to hello", DataType = "string", IsRequired = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Id of hello
        /// </summary>
        [ApiMember(Description = "Id to hello", DataType = "int")]
        public int Id { get; set; }
    }
}
