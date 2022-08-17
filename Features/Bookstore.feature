Feature: Bookstore

  @Bookstore @FilterName
  Scenario: Filter books by name
    Given I am on the Automation Bookstore website
     When I filter books by name
     Then I should only see the book with the name that I have filtered by

  @Bookstore @FilterAuthor
  Scenario: Filter books by author
    Given I am on the Automation Bookstore website
     When I filter books by author
     Then I should only see the book with the author that I have filtered by

  @Bookstore @FilterPrice
  Scenario: Filter books by price
    Given I am on the Automation Bookstore website
     When I filter books by price
     Then I should only see the book with the price that I have filtered by  
