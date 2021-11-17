using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NatusVinceno_websitebanhang_lhu18ct112.Areas.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSession session)
        {
            HttpContext.Current.Session["loginsession"] = session;
        }

        public static UserSession GetSession()
        {
            var session = HttpContext.Current.Session["loginsession"];
            if (session == null)
                return null;
            else
            {
                return session as UserSession;
            }
        }
    }
}