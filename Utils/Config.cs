using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magayaTests.Utils
{
    static class Config
    {
        public static string GetPassword() {
            var AppSettingsSection = ConfigurationManager.GetSection("secureAppSettings") as NameValueCollection;
            return AppSettingsSection["password"];
        }
    }
}
