﻿using AutoFramework.Config;
using AutoFramework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFramework.Base
{
    public class TestInitializeHook : BaseStep
    {
        //public readonly BrowserType Browser;

        //public TestInitializeHook(BrowserType browser)
        //{
        //    Browser = browser;
        //}

        //public readonly ParallelConfig _parallelConfig;

        //public TestInitializeHook(ParallelConfig parallelConfig) : base(parallelConfig)
        //{
        //    _parallelConfig = parallelConfig;
        //}


        public void InitializeSettings()
        {
            //Set all the settings for the framework
            ConfigReader.SetFrameworkSettings();

            //Set Log Helper
           //LogHelpers.CreateLogFile();

            //Open the browser
            OpenBrowser(Settings.BrowserType);

        }

        private void OpenBrowser(BrowserType browserType )
        {
            //DesiredCapabilities cap = new DesiredCapabilities();

            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    //DriverContext.Browser = new Browser(_parallelConfig.Driver);
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    DriverContext.Driver = new FirefoxDriver();
                    //DriverContext.Browser = new Browser(_parallelConfig.Driver);
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    ////DesiredCapabilities cap = new DesiredCapabilities();
                    //cap.SetCapability(CapabilityType.BrowserName, "Chrome");
                    //cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                    //var binary = new ChromeDriver(@"C:\Users\VISHNU\Downloads\chromedriver_win32 (1)\chromedriver.exe");
                    ////var profile = new ChromeProfile();                         

                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                default:
                    DriverContext.Driver = new ChromeDriver();
                    //DriverContext.Browser = new Browser(_parallelConfig.Driver);
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }

            //_parallelConfig.Driver = new RemoteWebDriver(new Uri("https://localhost::4444/wd/hub"), cap);
        }

      



    }
}
