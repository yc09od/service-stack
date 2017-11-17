using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.ServiceInterface.Services;
using Funq;
using ServiceStack;
using ServiceStack.Configuration;

namespace Api
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base("Api", typeof(HelloService).GetAssembly())
        {
            AppSettings = new MultiAppSettings(new EnvironmentVariableSettings(), new AppSettings());
        }

        public override void Configure(Container container)
        {
            
        }
    }
}
