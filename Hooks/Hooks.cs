using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BookStoreAutomationTest.Hooks
{
    [Binding]
    public class Hooks : SetUp
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverSetUp();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TearDown();
        }
    }
}
