Feature: Tide

A short summary of the feature

@tag1
Scenario: Tide-1 Searchbox
	Given Load the website tide
	When  click on search icon on top right corner
	And   Type Clean Breeze Powder in search icon 
    And   click on the first link
	Then   verifying the text Clean Breeze Powder is displayed
    And  take screenshoting

Scenario: Tide-2 live Chat
   Given Load the website tidewebpage
   When  click on live Chat on top right corner
   Then   verifying the text  closed chat is displayed
   And  take screenshotings
 

# Scenario: Tide-3 Contact us 
#    Given Load the website tidewebpages
#    When  click on Contact us on top right corner
#	And   click on email 
#	And   click on agree and continue
#	And    Enter the info
#	Then  click on sumbit
#	  And  take screenshottt
#


Scenario: Tide-4 language
   Given Load the website tidewebpagess
   When  click onlanaguage on top right corner
   And  click the language 
   Then change the language spanish
   And  change back to english
   And  taking  screenshotings

Scenario: Tide-5  login account
   Given Load the website tidewebpage login
   When  click on register
   And  click on sign up now
   And   click on login
   Then  enter the login info
   And  taking  screenshoting login

   Scenario: Tide-6 To verify Shop Products
	Given Load the website tide shop products
	When  click on navigate tab on shop products 
	And   click on the fabric care 
   
	Then   verifying the text Walmart is displayed
    And  take screenshoting tide shop products

	Scenario: Tide-7 To verify our commitment
	Given Load the website tide our commitment
	When  click on navigate tab on our commitment
	And   click on the Our Ambition
    And   click close of  the sticker_close
	Then   verifying the text manufacturing is displayed
    And  take screenshoting tide our commitment


	Scenario: Tide-8 To verify how to wash clothes
	Given Load the website tide how to wash clothes
	When  click on navigate tab on how to wash clothes
	And   click on the How to Use a Washer: From Common Problems to HE Detergent
    And   click close of  the sticker_closes
	Then   verifying the text How to Use an HE Washer is displayed
    And  take screenshoting tide how to wash clothes

    Scenario: Tide-9 To verify whats new
	Given Load the website tide whats new
	When  click on navigate tab on whats new
	And   click on the Tide Hygienic Clean Heavy Duty 10X Power PODS® Spring Meadow
    And   click close of  the stickercloses
	Then   verifying the text From America's #1 Trusted Detergent Brand* is displayed
    And  take screenshoting tide whats new

	Scenario: Tide-10 To verify Coupons and Rewards
	Given Load the website tide Coupons and Rewards
	When  click on navigate tab on Coupons and Rewards
	 And   click close of  the stickersclose
	Then   click on the Save now	 
    And  take screenshoting tide Coupons and Rewards

    Scenario:   Tide-11 To verify To verify P&G
	Given Load the website tide P&G
	When  click on header tab P&G
	 And click on serachbox
	Then enter new  
	And verifying the text Press Kits Procter & Gamble News
    And  take screenshoting tide 