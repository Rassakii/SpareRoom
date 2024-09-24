Feature: Signup

A short summary of the feature

@tag1
Scenario: A User can SignUP
	Given Spareroom has been Loaded Sucessfully
	When User Clicks on Register
	And user fill the following information
	| Firstname | Lastname | Email | Password                          | Confirm_Password      | Where_Did_You_Hear_About_Us      |
	| Tomilayo  | Yussuph  | Raspevemcono7e844w47@gmail.com | Rasakii75* | Rasakii75* | Newspaper | 
	And User fIlls the date of Birth with the following
	| Day | Month | Year |
	| 13  | 04    | 1995 |
	And the user clicks Im looking for House share checkbox
	And the user inserts "Newspaper" as  Where_Did_You_Hear_About_Us
	And User Clicks  on Register now
	When user clicks on skip
	Then the user is Signed up successfully
