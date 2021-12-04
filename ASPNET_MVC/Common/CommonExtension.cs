using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC.Common
{
    public static class CommonExtension
    {
        public static string NotNull(this string val)
        {
            return CommonMethods.NotNull(val);
        }
    }
}