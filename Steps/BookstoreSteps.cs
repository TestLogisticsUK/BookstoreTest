using BookStoreAutomationTest.Helpers;
using BookStoreAutomationTest.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace BookStoreAutomationTest.Steps
{
    [Binding]
    public class BookstoreSteps
    {
        #region Constructor
        private readonly IWebDriver _driver;

        public BookstoreSteps()
        {
            _driver = LocalHelpers.GetDriverContext;
            _bookstorePageObjects = new BookstorePageObjects(_driver);
        }
        #endregion

        #region Page Objects
        private readonly BookstorePageObjects _bookstorePageObjects;
        #endregion

        #region Given
        [Given(@"I am on the Automation Bookstore website")]
        public void GivenIAmOnTheAutomationBookstoreWebsite()
        {
            Assert.AreEqual("Automation Bookstore", _bookstorePageObjects.PageTitle);
        }
        #endregion

        #region When
        [When(@"I filter books by name")]
        public void WhenIFilterBooksByName()
        {
            _bookstorePageObjects.FilterByName();
        }

        [When(@"I filter books by author")]
        public void WhenIFilterBooksByAuthor()
        {
            _bookstorePageObjects.FilterByAuthor();
        }

        [When(@"I filter books by price")]
        public void WhenIFilterBooksByPrice()
        {
            _bookstorePageObjects.FilterByPrice();
        }
        #endregion

        #region Then
        [Then(@"I should only see the book with the name that I have filtered by")]
        public void ThenIShouldOnlySeeTheBookWithTheNameThatIHaveFilteredBy()
        {
            Assert.IsTrue(_bookstorePageObjects.CheckName());
        }

        [Then(@"I should only see the book with the author that I have filtered by")]
        public void ThenIShouldOnlySeeTheBookWithTheAuthorThatIHaveFilteredBy()
        {
            Assert.IsTrue(_bookstorePageObjects.CheckAuthor());
        }

        [Then(@"I should only see the book with the price that I have filtered by")]
        public void ThenIShouldOnlySeeTheBookWithThePriceThatIHaveFilteredBy()
        {
            Assert.IsTrue(_bookstorePageObjects.CheckPrice());
        }
        #endregion
    }
}
