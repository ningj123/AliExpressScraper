﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliScraperConsole
{
    public static class AppSettings
    {
        public static string AliExpressProductDetailUrl
        {
            get
            {
                return ConfigurationManager.AppSettings["AliExpress:ProductDetail:Url"];
            }
        }
    }
}
