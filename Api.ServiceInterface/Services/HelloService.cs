using System;
using System.Collections.Generic;
using System.Text;
using Api.ServiceModel.Requests;
using ServiceStack;

namespace Api.ServiceInterface.Services
{
    using Api.ServiceModel.DataObject;
    using Api.ServiceModel.Responses;

    /// <summary>
    /// Hello test service
    /// </summary>
    public class HelloService : Service
    {
        /// <summary>
        /// Hello get function
        /// </summary>
        /// <param name="request">
        /// Request prams.
        /// </param>
        /// <returns>
        /// Test result.
        /// </returns>
        public HelloResponse Get(HelloRequest request)
        {
            var result = new HelloResponse
                             {
                                 Result = new HelloResult
                                              {
                                                  Name = request.Name,
                                                  Id = request.Id
                                              }
                             };

            return result;
        }
    }
}
