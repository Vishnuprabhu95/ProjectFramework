//using System;
//using AutoFramework.Base;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IE;
//using AutomationTest.Pages;
//using AutoFramework.Helpers;
//using AutoFramework.Config;

//namespace AutomationTest
//{
//    [TestClass]
//    public class UnitTest1 : HookInitialize
//    {

       

        
//        //[TestMethod]
//        public void TestMethod1()
//        {

//            //ConfigReader.SetFrameworkSettings();
//            //LogHelpers.CreateLogFile();
//            //OpenBrowser(BrowserType.Chrome);
//            //LogHelpers.Write("open the browser");
//            //DriverContext.Browser.GoToUrl(Settings.AUT);

//            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
//            ExcelHelpers.PopulateInCollection(fileName);

//            CurrentPage = GetInstance<LoginPage>();
//            //CurrentPage.As<LoginPage>().userName(ExcelHelpers.ReadData(1,"UserName"));
//            CurrentPage.As<LoginPage>().continueClick();
//            CurrentPage.As<LoginPage>().password();
//            CurrentPage = CurrentPage.As<LoginPage>().signIn();
//            CurrentPage.As<AuthorizationPage>().ServiceEleClick().Equals(true);


//            //DriverContext.Driver = new ChromeDriver();
//            //DriverContext.Driver.Navigate().GoToUrl(URL);

//            //LoginPage loginPage = new LoginPage();
//            //loginPage.userName();
//            //loginPage.continueClick();
//            //loginPage.password();
//            ////AuthorizationPage authPage = loginPage.signIn();

//            //CurrentPage = loginPage.signIn();
//            //((AuthorizationPage)CurrentPage).ServiceEleClick();



//        }

//        public void Login()
//        {
//            //_driver.FindElement(By.Id("ap_email")).SendKeys("vishnu.261995@gmail.com");
//            //_driver.FindElement(By.Id("continue")).Click();
//            //_driver.FindElement(By.Id("ap_password")).SendKeys("hatelife");
//            //_driver.FindElement(By.Id("signInSubmit")).Click();           

//        }
//    }
//}
