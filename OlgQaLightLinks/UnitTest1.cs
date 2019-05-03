using System;
using System.Threading;
using NUnit.Framework;
using OldQaLightLinks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace HWOldQaLightLinks
{
    class OldQaLightLinks
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://old.qalight.com.ua/zapisatsya-na-kursy");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Category("FooterLinks")]
        [Test]
        public void TestOldQaLightLinks()
        {
            // Arrange
            int expectedSocailLinksCount = 7;

            // Act
            OldQaLightLinksPage oldQaLightLinksPage = new OldQaLightLinksPage(driver);
            int actualSocialLinksCount = oldQaLightLinksPage.allSocialLinks.Count;

            // Assert
            Assert.AreEqual(expectedSocailLinksCount, actualSocialLinksCount,
                $"An expected count of social linqs is {expectedSocailLinksCount}, but actual is {actualSocialLinksCount}");
        }
    }
}
