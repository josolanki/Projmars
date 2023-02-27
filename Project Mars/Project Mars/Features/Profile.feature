Feature: Profile Page features

Seller is able to add Language,Skill and Certifiaction in profile page.

Scenario: I login into Mars portal page.
Given I login with valid email and password.
When I navigated language Tab
And I added new  '<Langugage>' and '<level>' 
Then '<Langugage>' and '<level>' should be added successfully.

#	Scenario: User Login into Mars Portal.
#	Given  I login with valid email and password
#	When Add new '<Langugage>' and '<level>' 
#	Then The '<Langugage>' and '<level>' should be added successfully.
#	Examples: 
#	| Language     | level |
#	| English      | Fluent|
#
#	Scenario: Edit existing language
#	Given I login with valid email and password
#	When  I edit existing '<Langugage>' recors. 
#	Then I successfully edited '<Langugage>' record.
#	Examples: 
#	| Languages | level |
#	| Hindi    | Fluent |
#
#	Scenario: Delete existing language
#	Given I login with valid email and password
#	When I am able to delete existing language
#	Then i have successfully deleted language

#	Scenario Outline: : Add new skill
#	Given I login with valid email and password
#	Then I have successfully added a new <Skill>', '<level>'.
#    Examples:   
#	| Skills      |  Level |
#	| Programming  | Beginner     |
#
#	Scenario Outline: Add new Certificate
#	Given I login with valid email and password
#	When I am able to add a new certificate '<certificate>' ,'<Year>' ,'<level>'
#	Then  I successfully added a new '<certificate>' ,'<from>', '<year>'
#    Examples:  
#	|Certifiaction | From  | Year  |
#	| B.A           | Adobe |  2003 |
#
#	
#	Scenario: Add a new Description.
#	Given I login with valid emial and password
#	When I navigate to profile page.
#	And I enter detail in Description box
#	Then I added Description successfully
#
#	Scenario: Add new Education details
#	Given I login with valid email and password
#	When I navigate to profile page.
#	And I added '<country>' ,'< University>' ,'<Title>','<Degree>' ,'<Year>' from dropdown 
#	Then i successfully created Education record
#
#	Scenario: Select Availability
#	Given I login with valid email and password
#	When I selected Availability type from dropdown
#	Then I successfully entered Availability
#
#	Scenario: Select Hours
#	Given I login with valid email and password
#	When I selected Hours from dropdown
#	Then I successfully entered Hours
#
#	Scenario: Select Earn Target
#	Given I login with valid email and password
#	When I selected Earn Target from dropdown
#	Then I successfully entered Earn Target
#
