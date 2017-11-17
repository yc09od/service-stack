using System;
using System.Collections.Generic;
using System.Text;

namespace Api.ServiceModel.Setting
{
    public class AppSettings
    {
        /// <summary>
        /// Gets or sets the connection strings for the orchestrator.
        /// </summary>
        public ConnectionStringsConfig ConnectionStrings { get; set; }

        /// <summary>
        /// Gets or sets the API specific settings.
        /// </summary>
        public ApiSettingsConfig ApiSettings { get; set; }
    }

    public class ConnectionStringsConfig
    {
        public string DefaultConnection { get; set; }
    }

    public class ApiSettingsConfig
    {
        public string MailHost { get; set; }
    }
}
