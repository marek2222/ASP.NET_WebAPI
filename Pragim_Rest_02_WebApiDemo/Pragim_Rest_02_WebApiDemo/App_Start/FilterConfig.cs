﻿using System.Web;
using System.Web.Mvc;

namespace Pragim_Rest_02_WebApiDemo
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
