﻿using AutoFramework.Base;
using AutoFramework.Helpers;
using NUnit.Framework;
using TechTalk.SpecFlow;
using AutomationTest.Pages;

namespace AutomationTest.Scenarios.Home.StepDefinition
{
    [Binding]
    public sealed class HomeSteps : BaseStep
    {
        //private readonly ParallelConfig _parallelConfig;
        //public HomeSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        //{
        //    _parallelConfig = parallelConfig;
        //}

        [When(@"the user clicks best seller tab")]
        public void WhenTheUserClicksBestSellerTab()
        {
            CurrentPage = CurrentPage.As<HomePage>().ClickBestSellerEle();
        }

        [Then(@"the ""(.*)"" title displays in best seller tab")]
        public void ThenTheTitleDisplaysInBestSellerTab(string title)
        {
            Assert.IsTrue((CurrentPage.As<BestSellerPage>().IsBestSellerEleTitleDisplayed()).Equals(title));
        }

        [When(@"the user performs search")]
        public void WhenTheUserPerformsSearch()
        {
            string fileName = "C:\\dev\\ProjectFramework\\AutomationTest\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);
            CurrentPage.As<HomePage>().Search(ExcelHelpers.ReadData(1, "UserName"));
        }

        [Then(@"the results page displayed")]
        public void ThenTheResultsPageDisplayed()
        {
            CurrentPage.As<HomePage>().NoResultEleDisplayed().Equals(true);
        }

    }
}
