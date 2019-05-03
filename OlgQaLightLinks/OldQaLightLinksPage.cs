using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OldQaLightLinks
{
    public class OldQaLightLinksPage
    {
        public IWebDriver driver;
        public OldQaLightLinksPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='footer_social']//li[1]")]
        public IWebElement faceboolLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer_social']//li[2]")]
        public IWebElement twitterLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer_social']//li[3]")]
        public IWebElement youtubeLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer_social']//li[4]")]
        public IWebElement googleLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer_social']//li[5]")]
        public IWebElement linkedinLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer_social']//li[6]")]
        public IWebElement vkLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer_social']//li[7]")]
        public IWebElement instagramLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer_social']//li")]
        public IList<IWebElement> allSocialLinks;
    }
}
