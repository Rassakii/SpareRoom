Feature: MessageProperty

A short summary of the feature

@tag1
Scenario: User can Message Propert Agent
	Given SpareRoom is loaded Succesfully
	When user  Fills in "Bolton" in the search box
	And user clicks on search button
	And the user "10"  miles radius in the dropdown
	And user inserts "400" in the minimum rent
	And user inserts "700" in the maXimum rent
	And user clicks on apply filter
	And user clicks on House in bury ads
	And user clicks on message
	And User inserts "Hi is the house available in the message box"
	And user inserts "raskeemono75@gmail.com" in the login email box
	And User inserts "Rasakii75*" as password
	And user clicks on Login and send button
	Then User is logged in and message sent succesfully
	


