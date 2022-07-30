using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support;
using System.Threading;
using TechTalk.SpecFlow;

using Tide11.POM;


using System.Threading;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TideStepDefinitions
    {
        PageClass1 obj = new PageClass1();

        [Given(@"Load the website tide")]
        public void GivenLoadTheWebsiteTide()
        {
            obj.LoadWebsite();
        }

        [When(@"click on search icon on top right corner")]
        public void WhenClickOnSearchIconOnTopRightCorner()
        {
            obj.Searchbox();
        }

      

        [When(@"Type Clean Breeze Powder in search icon")]
        public void WhenTypeCleanBreezePowderInSearchIcon()
        {
            obj.TypeCleanBreezePowder();

        }



        [When(@"click on the first link")]
        public void WhenClickOnTheFirstLink()
        {
            obj.ClickOnFirstLink();
        }

        [Then(@"verifying the text Battery is displayed")]
        public void ThenVerifyingTheTextBatteryIsDisplayed()
        {
            obj.VerifyTheText();
        }


        [Then(@"verifying the text Clean Breeze Powder is displayed")]
        public void ThenVerifyingTheTextCleanBreezePowderIsDisplayed()
        {
            obj.VerifyTheText();
        }


        [Then(@"take screenshoting")]
        public void ThenTakeScreenshoting()
        {
            obj.ScreenShot();
        }

        //*************************************************************************************************************************************


        PageClass2 liveChat = new PageClass2();


        [Given(@"Load the website tidewebpage")]
        public void GivenLoadTheWebsiteTidewebpage()
        {
            liveChat.LoadWebsite();
        }

        [When(@"click on live Chat on top right corner")]
        public void WhenClickOnLiveChatOnTopRightCorner()
        {
            liveChat.LiveChat();
        }

        [Then(@"verifying the text  closed chat is displayed")]
        public void ThenVerifyingTheTextClosedChatIsDisplayed()
        {
            liveChat.Verifytheclosedchat();
        }

        [Then(@"take screenshotings")]
        public void ThenTakeScreenshotings()
        {
            liveChat.ScreenShot();
        }

        //**********************************************************************
        //***********************************************************************

        PageClass3 contactUs = new PageClass3();

        [Given(@"Load the website tidewebpages")]
        public void GivenLoadTheWebsiteTidewebpages()
        {
            contactUs.LoadWebsite();
        }

        [When(@"click on Contact us on top right corner")]
        public void WhenClickOnContactUsOnTopRightCorner()
        {
            contactUs.ContactUs();
        }

        [When(@"click on email")]
        public void WhenClickOnEmail()
        {
            contactUs.Emailbutton();
        }

        [When(@"click on agree and continue")]
        public void WhenClickOnAgreeAndContinue()
        {
            contactUs.AgreeAndContniue();
        }

        [When(@"Enter the info")]
        public void WhenEnterTheInfo()
        {
            contactUs.infomation();
        }

        [Then(@"click on sumbit")]
        public void ThenClickOnSumbit()
        {
            contactUs.Sumbitbutton();
        }


        [Then(@"take screenshottt")]
        public void ThenTakeScreenshottt()
        {
            contactUs.ScreenShot();
        }


        //**********************************************************************
        //***********************************************************************

        PageClass4 language = new PageClass4();

        [Given(@"Load the website tidewebpagess")]
        public void GivenLoadTheWebsiteTidewebpagess()
        {
            language.LoadWebsite();
        }

        [When(@"click onlanaguage on top right corner")]
        public void WhenClickOnlanaguageOnTopRightCorner()
        {
            language.Lang();
        }

        [When(@"click the language")]
        public void WhenClickTheLanguage()
        {
            language.langclick();
        }

        [Then(@"change the language spanish")]
        public void ThenChangeTheLanguageSpanish()
        {
            language.spanish();
        }

        [Then(@"change back to english")]
        public void ThenChangeBackToEnglish()
        {
            language.english();
        }

        [Then(@"taking  screenshotings")]
        public void ThenTakingScreenshotings()
        {
            language.ScreenShot();
        }


        //**********************************************************************
        //***********************************************************************

       
             PageClass5 login = new PageClass5();


        [Given(@"Load the website tidewebpage login")]
        public void GivenLoadTheWebsiteTidewebpageLogin()
        {
            login.LoadWebsite();
        }

        [When(@"click on register")]
        public void WhenClickOnRegister()
        {
            login.ClickOnRegsiter();
        }

        [When(@"click on sign up now")]
        public void WhenClickOnSignUpNow()
        {
            login.ClickOnSignUpNow();
        }

        [When(@"click on login")]
        public void WhenClickOnLogin()
        {
            login.ClickOnLogin();
        }

        [Then(@"enter the login info")]
        public void ThenEnterTheLoginInfo()
        {
            login.EnterInfo();
        }


        //And verifying the text is displayed

        //[Then(@"verifying the text is displayed")]
        //public void ThenVerifyingTheTextIsDisplayed()
        //{
        //    login.VerifyThelogintext();
        //}

        [Then(@"taking  screenshoting login")]
        public void ThenTakingScreenshotingLogin()
        {
            login.ScreenShot();
        }



        //**********************************************************************
        //***********************************************************************
        //**********************************************************************
        //***********************************************************************

        PageClass6 shopProducts = new PageClass6();



        [Given(@"Load the website tide shop products")]
        public void GivenLoadTheWebsiteTideShopProducts()
        {
            shopProducts.LoadWebsite();
        }

        [When(@"click on navigate tab on shop products")]
        public void WhenClickOnNavigateTabOnShopProducts()
        {
            shopProducts.ClickOnNavigateShopProducts();
        }

        [When(@"click on the fabric care")]
        public void WhenClickOnTheFabricCare()
        {
            shopProducts.ClickOnFabricCare();
        }

        // And   click on the Antibacterial
        //[When(@"click on the Antibacterial")]
        //public void WhenClickOnTheAntibacterial()
        //{
        //    shopProducts.ClickOnAntibacterial();
        //}

        [Then(@"verifying the text Walmart is displayed")]
        public void ThenVerifyingTheTextWalmartIsDisplayed()
        {
            shopProducts.VerifyTheText();
        }

        [Then(@"take screenshoting tide shop products")]
        public void ThenTakeScreenshotingTideShopProducts()
        {
            shopProducts.ScreenShot();
        }



        //**********************************************************************
        //***********************************************************************
        //**********************************************************************
        //***********************************************************************

        PageClass7 ourCommitment = new PageClass7();





        [Given(@"Load the website tide our commitment")]
        public void GivenLoadTheWebsiteTideOurCommitment()
        {
            ourCommitment.LoadWebsite();
        }

        [When(@"click on navigate tab on our commitment")]
        public void WhenClickOnNavigateTabOnOurCommitment()
        {
            ourCommitment.ClickOnNavigateOurCommitment();
        }

        [When(@"click on the Our Ambition")]
        public void WhenClickOnTheOurAmbition()
        {
            ourCommitment.ClickOnOurAmbition();
        }

        [When(@"click close of  the sticker_close")]
        public void WhenClickCloseOfTheSticker_Close()
        {
            ourCommitment.ClickOnStickerClose();
        }

        [Then(@"verifying the text manufacturing is displayed")]
        public void ThenVerifyingTheTextManufacturingIsDisplayed()
        {
            ourCommitment.VerifyTheTextManufacturing();
        }

        [Then(@"take screenshoting tide our commitment")]
        public void ThenTakeScreenshotingTideOurCommitment()
        {
            ourCommitment.ScreenShot();
        }


        //**********************************************************************
        //***********************************************************************
        //**********************************************************************
        //***********************************************************************

        PageClass8 HowToWashClothes = new PageClass8();

        [Given(@"Load the website tide how to wash clothes")]
        public void GivenLoadTheWebsiteTideHowToWashClothes()
        {
            HowToWashClothes.LoadWebsite();
        }

        [When(@"click on navigate tab on how to wash clothes")]
        public void WhenClickOnNavigateTabOnHowToWashClothes()
        {
            HowToWashClothes.ClickOnNavigateHowToWashClothes();
        }

        [When(@"click on the How to Use a Washer: From Common Problems to HE Detergent")]
        public void WhenClickOnTheHowToUseAWasherFromCommonProblemsToHEDetergent()
        {
            HowToWashClothes.ClickOnHowToUseWasher();
        }

        [When(@"click close of  the sticker_closes")]
        public void WhenClickCloseOfTheSticker_Closes()
        {
            HowToWashClothes.ClickOnStickerClose();
        }

        [Then(@"verifying the text How to Use an HE Washer is displayed")]
        public void VerifyTheTextWasher()
        {
            HowToWashClothes.VerifyTheTextWord();
        }


        [Then(@"take screenshoting tide how to wash clothes")]
        public void ThenTakeScreenshotingTideHowToWashClothes()
        {
            HowToWashClothes.ScreenShot();
        }


        //**********************************************************************
        //***********************************************************************
        //**********************************************************************
        //***********************************************************************

        PageClass9 whatsNew = new PageClass9();


        [Given(@"Load the website tide whats new")]
        public void GivenLoadTheWebsiteTideWhatsNew()
        {
            whatsNew.LoadWebsite();
        }

        [When(@"click on navigate tab on whats new")]
        public void WhenClickOnNavigateTabOnWhatsNew()
        {
            whatsNew.ClickOnWhatsNew();
        }

        [When(@"click on the Tide Hygienic Clean Heavy Duty (.*)X Power PODS® Spring Meadow")]
        public void WhenClickOnTheTideHygienicCleanHeavyDutyXPowerPODSSpringMeadow(int p0)
        {
            whatsNew.ClickOnTheTideHygienicClean();
        }

        [When(@"click close of  the stickercloses")]
        public void WhenClickCloseOfTheStickercloses()
        {
            whatsNew.ClickOnStickerClose();
        }

        [Then(@"verifying the text From America's \#(.*) Trusted Detergent Brand\* is displayed")]
        public void ThenVerifyingTheTextFromAmericasTrustedDetergentBrandIsDisplayed(int p0)
        {
            whatsNew.VerifyTheTextFromAmericasTrusted();
        }

        [Then(@"take screenshoting tide whats new")]
        public void ThenTakeScreenshotingTideWhatsNew()
        {
            whatsNew.ScreenShot();
        }


        //**********************************************************************
        //***********************************************************************
        //**********************************************************************
        //***********************************************************************

        PageClass10 couponsRewards = new PageClass10();



        [Given(@"Load the website tide Coupons and Rewards")]
        public void GivenLoadTheWebsiteTideCouponsAndRewards()
        {
            couponsRewards.LoadWebsite();
        }

        [When(@"click on navigate tab on Coupons and Rewards")]
        public void WhenClickOnNavigateTabOnCouponsAndRewards()
        {
            couponsRewards.ClickOnCouponsAndRewards();
        }

        [When(@"click close of  the stickersclose")]
        public void WhenClickCloseOfTheStickersclose()
        {
            couponsRewards.ClickOnStickerClose();
        }

        [Then(@"click on the Save now")]
        public void ThenClickOnTheSaveNow()
        {
            couponsRewards.ClickOnTheSaveNow();
        }


        [Then(@"take screenshoting tide Coupons and Rewards")]
        public void ThenTakeScreenshotingTideCouponsAndRewards()
        {
            couponsRewards.ScreenShot();
        }

        //**********************************************************************
        //***********************************************************************
        //**********************************************************************
        //***********************************************************************

        PageClass11 pandG = new PageClass11();






        [Given(@"Load the website tide P&G")]
        public void GivenLoadTheWebsiteTidePG()
        {
            pandG.LoadWebsite();
        }

        [When(@"click on header tab P&G")]
        public void WhenClickOnHeaderTabPG()
        {
            pandG.ClickOnPandG();
        }

        [When(@"click on serachbox")]
        public void WhenClickOnSerachbox()
        {
            pandG.SearchboxMiddle();
        }

        [Then(@"enter new")]
        public void ThenEnterNew()
        {
            pandG.ThenEnterNew();
        }

        [Then(@"verifying the text Press Kits Procter & Gamble News")]
        public void ThenVerifyingTheTextPressKitsProcterGambleNews()
        {
            pandG.VerifyTheTextPressKitsProcterGambleNews();
        }

        [Then(@"take screenshoting tide")]
        public void ThenTakeScreenshotingTide()
        {
            pandG.ScreenShot();
        }





    }
}
