﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.DriverManager
{
    class DriverManager
    {
        public DriverManager()
        {

        }
        private static IWebDriver driver;
        public static IWebDriver Current
        {
            get
            {
                if (driver == null)
                {
                    driver = new ChromeDriver();
                }
                return driver;
            }
        }
    }
}
