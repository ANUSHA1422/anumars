Feature: ProfileFeature

A short summary of the feature

@tag1
Scenario: Add languages in the portal 
	Given I Signed into the Mars portal successfully
	When I navigate to language field
	And I add a new language in the field
	Then The language should be added successfully

Scenario: Add skill in the portal
 Given  I Signed into the Mars portal successfully
 When I navigate to skill field
 And I add a new skill in the field
 Then The skill should be added successfully

 Scenario: Add decsription in the portal
 Given I Signed into the Mars portal successfully
 When I navigate to description field
 And I add a new description in the field
 Then The description should be added successfully