﻿using System.Web;
using System.Web.Mvc;

namespace cotizaciones_nexsys
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
