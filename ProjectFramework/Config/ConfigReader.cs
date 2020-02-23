﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Xml.XPath;
using System.IO;
using AutoFramework.ConfigElement;
using AutoFramework.Base;

namespace AutoFramework.Config
{
    public class ConfigReader
    {

        public static void SetFrameworkSettings()
        {







            Settings.AUT = TestConfiguration.ASettings.TestSettings["test"].AUT;

            Settings.TestType = TestConfiguration.ASettings.TestSettings["test"].Testtype;

            Settings.BrowserType = (BrowserType)Enum.Parse(typeof(BrowserType), TestConfiguration.ASettings.TestSettings["test"].Browser);

            //XPathItem aut;
            //XPathItem testType;

            //    //Fetches data from GlobalConfig xml file for framework  configuration

            //    string strFileName = Environment.CurrentDirectory.ToString() + "\\Config\\GlobalConfig.xml";
            //    FileStream stream = new FileStream(strFileName, FileMode.Open);

            //    XPathDocument document = new XPathDocument(stream);
            //    XPathNavigator navigator = document.CreateNavigator();

            //    aut = navigator.SelectSingleNode("AutoFramework/RunSettings/AUT");
            //    testType = navigator.SelectSingleNode("AutoFramework/RunSettings/TestType");

            //Settings.AUT = aut.Value.ToString();
            //Settings.TestType = testType.Value.ToString();


        }

















        //App.config code for configuration
        //<?xml version = "1.0" encoding="utf-8" ?>
        //<configuration>
        //  <appSettings>
        //    <add key = "AUT" value="https://www.amazon.in/" />
        //  </appSettings>
        //</configuration>

        //public static string InitializeTest()
        //{
        //    return ConfigurationManager.AppSettings["AUT"].ToString();
        //}
    }
}
