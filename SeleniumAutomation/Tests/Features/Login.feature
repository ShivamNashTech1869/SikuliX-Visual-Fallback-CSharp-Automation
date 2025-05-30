      Feature: Login Functionality

      @Login
        Scenario: User logs in with valid credentials
          Given I open the login page
          When I enter valid username and password
          And I click on the login button
          Then I should be logged in successfully

