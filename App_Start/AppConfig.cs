using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMatrix.WebData;

namespace SmithJessicaHW5.App_Start
{
    public class AppConfig
    {
        public static void WebSecurityDbInit()
        {
            if (!WebSecurity.Initialized)
            {
                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName",
            autoCreateTables: true);
            }
        }
    }
}