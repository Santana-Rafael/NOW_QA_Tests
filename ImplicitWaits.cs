using System;
using OpenQA.Selenium.Chrome;
using org.openqa.selenium.support.ui;



public void waitForElement(WebDriver driver, String query_xpath)
{
    //Set up fluentWait to wait for 35 seconds polling every 1
    Wait<WebDriver> fluentWait = new FluentWait<WebDriver>(driver)
        .withTimeout(35, TimeUnit.SECONDS)
        .pollingEvery(1, TimeUnit.SECONDS)
        .ignoring(NotSupportedException.Equals(NullReferenceException));

 WebElement element;

 //Look for element, if not found start fluentWait
 try
 {
     element = driver.findElement(By.xpath(query_xpath));
 }
 catch (WebDriverException e)
 {
     logger.info("[getElementByXpath] Element not initially found. Starting fluentWait ["+ query_xpath + "]");

     try
     {
            element = fluentWait.until(new Function<WebDriver, WebElement>());
         /*{
             public WebElement apply(WebDriver d)
                {
                    return d.findElement(By.xpath(xpath));
                }
         }*/
     }
     catch (WebDriverException f)
     {
         logger.info("[getElementByXpath] FluentWait findElement threw exception:\n\n" + f +"\n\n");

         throw new WebDriverException("Unable to find element ["+xpath+"]");
     }
 }

 //Once we've found the element wait for element to become visible
 fluentWait.until(ExpectedConditions.visibilityOf(element));
}


/*
public class DriverImplicitWait : IDisposable
{
    private readonly IWebDriver _driver;

    public DriverImplicitWait(IWebDriver driver, int waitMilliseconds)
    {
        _driver = driver;
        //Change the timeout to the value passed in
        _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(waitMilliseconds));
    }

    //When the using statement ends
    public void Dispose()
    {
        //Set the timeout back to the default timeout
        _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(Settings.DefaultTimeout));
    }
}

public class WebDriverExtensions
{
    private readonly IWebDriver _driver;

    public WebDriverExtensions(IWebDriver driver)
    {
        _driver = driver;
    }

    public bool IsElementDisplayed(IWebElement element, int withinMilliseconds)
    {
        //We use the timeout controller class from above or which ever namespace you put it in
        using (new DriverImplicitWait(_driver, withinMilliseconds))
        {
            try
            {
                //Because we are using the PageFactory at the time of using this element WebDriver will attempt to
                //Find the element and check displayed status, if its present and displayed we will get true
                //If its present and hidden we will get false
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                //If the element is present at all we get the NoSuchElementExpcetion and return false;
                return false;
            }
        }
    }
}

public class TestPage
{
    private readonly IWebDriver _driver;

    public TestPage(IWebDriver driver)
    {
        _driver = driver;

        PageFactory.InitElements(driver, this);

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(d => d.FindElement(By.CssSelector("#something")));
    }

    [FindsBy(How = How.Id, Using = "test")]
    private IWebElement LblTest { get; set; }

    public bool IsTestElementDisplayed()
    {
        return new WebDriverExtensions(_driver).IsElementDisplayed(LblTest, 50);
    }
}
*/
