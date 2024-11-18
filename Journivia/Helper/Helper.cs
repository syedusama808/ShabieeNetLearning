using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Journivia.Helper
{
    public class Helper
    {
        public string GetConnectionPath()
        {
            return System.Configuration.ConfigurationManager.AppSettings["DBConnection"];
        }
    }
}