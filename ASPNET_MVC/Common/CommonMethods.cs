using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_MVC.Common
{
    public static class CommonMethods
    {

        public static bool IsEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string NotNull(string str)
        {
            return String.IsNullOrEmpty(str) ? String.Empty : str;
        }
    }
}