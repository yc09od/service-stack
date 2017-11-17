using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.ServiceInterface.Services;
using Funq;
using ServiceStack;

namespace Api
{
    using ServiceStack.Configuration;

    using AppSettings = Api.ServiceModel.Setting.AppSettings;

    public class AppHost : AppHostBase
    {
        private readonly AppSettings settings;

        public AppHost(AppSettings settings) : base("Api", typeof(HelloService).GetAssembly())
        {
            this.settings = settings;
        }

        public override void Configure(Container container)
        {
            container.Register(this.settings);

            this.Plugins.Add(new CorsFeature());
        }
    }
}
