using System;
using System.Collections.Generic;
using System.Text;
using ServiceStack;

namespace Api.ServiceModel.Requests
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Hello request
    /// </summary>
    [Route("/hello/{Name}", Verbs = "Get"), Description("This is the test service")]
    public class HelloRequest
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
