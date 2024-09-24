Feature: Login

A short summary of the feature

@tag1
Scenario: User can Login
	Given Spareroom has loaded successfully
	When When user click on login button
	And user inserts Email as "raskeemono75@gmail.com"
	And user inserts password as "Rasakii75*"
	And user clicks Remember me Checkbox
	And user clicks on Login
	Then User is logged in succesfully
