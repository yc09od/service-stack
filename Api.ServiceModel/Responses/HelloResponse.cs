namespace Api.ServiceModel.Responses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Api.ServiceModel.DataObject;

    /// <summary>
    /// Response of hello
    /// </summary>
    public class HelloResponse
    {
        /// <summary>
        /// Gets or sets the result
        /// </summary>
        public HelloResult Result { get; set; }
    }
}
