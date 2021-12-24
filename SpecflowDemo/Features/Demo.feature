Feature: Login
   Login to demo EA Application
@Smoke
Scenario: Perform login for EA Application Site
	Given I Launch the application
	And I click login link
	And Enter the Following details
	    | Username | Password |
	    | admin    | password |
	And Click login Button
	Then I Should see Employee details link





 