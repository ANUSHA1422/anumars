Feature: ProfileFeature

A short summary of the feature

@tag1
Scenario: Add languages in the portal 
	Given I Signed into the Mars portal successfully
	When I navigate to language field
	And I add a new language in the field
	Then The language should be added successfully

Scenario Outline: Edit language in the portal
	 Given I Signed into the Mars portal successfully
	 When I add a new language in the field
	 And I Update '<Language>'the langugae in the portal
	 Then The language should have updated '<Language>'
Examples:
| Language |
|  english |
|  telugu  |