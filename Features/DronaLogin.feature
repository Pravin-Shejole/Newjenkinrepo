Feature: Check_drona_academy_Login
	Check the Login drona academy

@mytag
Scenario: Successfully login With a valid credentials
	Given Navigate to the login Page
	And and Enter valid username 'amruta.yadav@nxglabs.in' and Password '111111111111111'
	
	When When click login Button
	Then User should be login and redirected to the Dashboard