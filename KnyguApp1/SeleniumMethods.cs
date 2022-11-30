using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenDialogWindowHandler;
using System.Xml.Linq;


namespace KnyguApp1
{
    internal class SeleniumMethods
    {


        public static void Click(IWebDriver driver, string elementType,  string element)
        {
            if (elementType == "Class")
            {
                driver.FindElement(By.ClassName(element)).Click();
            }
            else if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            else if (elementType == "XPath")
            {
                IWebElement click = driver.FindElement(By.XPath(element));
                click.Click();
            }
            else if( elementType == "Css")
            {
                IWebElement click = driver.FindElement(By.CssSelector(element));
                click.Click();
            }
            

        }

        public static void EnterText (IWebDriver driver, string elementType, string element, string value)
        {
            if(elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            else if(elementType == "XPath")
            {
                driver.FindElement(By.XPath(element)).SendKeys(value);
            }
            else if(elementType == "Class")
            {
                driver.FindElement(By.ClassName(element)).SendKeys(value);
            }
        }

        public static void ClearField (IWebDriver driver, string elementType, string element)
        {
            if (elementType == "Class")
            {
                driver.FindElement(By.ClassName(element)).Clear();
            }
            else if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Clear();
            }
            else if (elementType == "XPath")
            {
                IWebElement click = driver.FindElement(By.XPath(element));
                click.Clear();
            }
            else if (elementType == "link")
            {
                IWebElement click = driver.FindElement(By.PartialLinkText("-" + element + "-"));
                click.Clear();
            }
        }

        public static void SelectDropDown(IWebDriver driver, string elementType, string element, string value)
        {
            if (elementType == "Class")
            {
                new SelectElement (driver.FindElement(By.ClassName(element))).SelectByText(value);
            }
            else if (elementType == "Id")
            {
                new SelectElement (driver.FindElement(By.Id(element))).SelectByText(value);
            }
            else if (elementType == "XPath")
            {
                new SelectElement (driver.FindElement(By.XPath(element))).SelectByText(value);

            }
            else if (elementType == "Css")
            {
                new SelectElement (driver.FindElement(By.CssSelector(element))).SelectByText(value);

            }

            var index = driver.PageSource.IndexOf("mercedes-lackey");
            var begin = 0;
            var newIndex = 0;
            do
            {
                begin = newIndex;
                newIndex = driver.PageSource.IndexOf("href=", begin + 1);
            } while (newIndex < index);
            var indexOfEnd = driver.PageSource.IndexOf(" class", begin);
            var hyperLink = driver.PageSource.Substring(begin, indexOfEnd - begin);
            }

        public static void UploadFile( string path, string name)
        {
            HandleOpenDialog hndOpen = new HandleOpenDialog();
            hndOpen.fileOpenDialog(path, name);
        }


        public static IWebElement FindPartialLink(IWebDriver driver,  string value)
        {
            IWebElement element = driver.FindElement(By.PartialLinkText(value));

            return element;
        }

        public static bool LinkisFound (IWebDriver driver, string value)
        {
            var foundelement  = driver.FindElement(By.PartialLinkText("-"+value+"-"));
            if (foundelement != null)
            {
                return true;
            }else
            {
                return false;
            }

            
        }
    }
}
