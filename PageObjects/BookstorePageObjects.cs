using BookStoreAutomationTest.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreAutomationTest.PageObjects
{
    public class BookstorePageObjects
    {
        #region Constructor
        private readonly IWebDriver _driver;

        public BookstorePageObjects(IWebDriver driver)
        {
            _driver = driver;
        }
        #endregion

        #region Page Objects
        private readonly By _title = By.Id("page-title");
        #endregion

        #region Gets
        public string PageTitle
        {
            get
            {
                _driver.WaitUntilElementVisible(_title);
                return _driver.FindElement(_title).Text;
            }
        }
        #endregion

        #region Methods
        public void FilterByName()
        {
            // Code here
        }

        public void FilterByAuthor()
        {
            // Code here
        }

        public void FilterByPrice()
        {
            // Code here
        }

        public bool CheckName()
        {
            // Code here
            return true;
        }

        public bool CheckAuthor()
        {
            // Code here
            return true;
        }

        public bool CheckPrice()
        {
            // Code here
            return true;
        }
        #endregion
    }
}
