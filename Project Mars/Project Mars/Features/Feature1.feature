Feature: Project Mars

Add features in Profile page

@tag1
Scenario: Login with Valid Credentials
	Given I navigate to mars portal page
	When   I login in Mars portal using valid email and password
	Then  I logged in successfully

	Scenarios: Add Description
	Given I logged in mars portal
	When I enter detail in Description box
	Then I added Description successfully

	Scenarios: Add new language
	Given I logged in mars portal page
	When I navigate to lanuage page
	And I enter language
	And i enter language level from dropdown
	Then I created language record successfully

	Scenarios: Add Skills
	Given I logged in Mars portal
	When I enter new skills
	Then I successfully entered new skills

	Scenarios: Add new Education details
	Given I logged in Mars portal page
	When I Navigate to Eduaction page
	and I added country/University/Title/egree/Year from dropdown 
	Then i successfully created Education record

	Scenarios: Add Certifications
	Given  I logged in Mars portal page
	When I Navigated to Certification page
	And I add certificate/from/year from dropdown
	Then I successfully created certifications record

	Scenarios: Select Availability
	Given I logged in Mars portal page
	When I selected Availability type from dropdown
	Then I successfully entered Availability

	Scenarios: Select Hours
	Given I logged in Mars portal page
	When I selected Hours from dropdown
	Then I successfully entered Hours

	Scenarios: Select Earn Target
	Given I logged in Mars portal page
	When I selected Earn Target from dropdown
	Then I successfully entered Earn Target

