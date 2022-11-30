using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;
using OpenQA.Selenium.Interactions;
using Keys = OpenQA.Selenium.Keys;

namespace KnyguApp1
{
    public partial class SearchResults : Form
    {
        public SearchResults(string labelText)
        {
            InitializeComponent();
            this.TheFoundBook.Text = labelText;
        }

        private void DeleteFromDbBtn_Click(object sender, EventArgs e)
        {
            var text = TheFoundBook.Text;
            int indexof = text.IndexOf(" by");
            var booktitle = text.Substring(0, indexof);
            
            using (var ctx  = new DataContext())
            {
                var toDelete = ctx.Books.First(x => x.Title == booktitle);

                if(toDelete != null)
                {
                    ctx.Books.Remove(toDelete);
                    MessageBox.Show("Deleted");
                    ctx.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Failed to delete");
                }

            }
            
        }

        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            var text = TheFoundBook.Text;
            int indexof = text.IndexOf(" by");
            var booktitle = text.Substring(0, indexof);

            using (var ctx = new DataContext())
            {
                var book = ctx.Books.First(x => x.Title == booktitle);

                Edit_Books editBook = new Edit_Books(book.Title, book.Author, book.Price, book.Comment, book.Blurb, book.Condition, book.Id);
                editBook.Show();

            }
        }

        private void DeleteFromSenaBtn_Click(object sender, EventArgs e)
        {
            var text = TheFoundBook.Text;
            int indexof = text.IndexOf(" by");
            var booktitle = text.Substring(0, indexof);

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.sena.lt/mano-skelbimai?active=1";
            driver.Manage().Window.Maximize();
            SeleniumMethods.Click(driver, "XPath", "/html/body/div[3]/div[2]/div[1]/div[2]/div[2]/button[1]");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "username", "SandyPandas");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "password", "Pinkstudy36+");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/div/div/div/section[2]/form/div/div[3]/button");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "XPath", "/html/body/main/div/div/div/div[2]/div[1]/main/div[2]/header/div[1]/div/div[2]/div/span/span[1]/span/span/textarea", booktitle);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/div[1]/main/div[2]/header/div[1]/div/div[2]/div/button");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/div[1]/main/div[2]/main/div[1]/div/div/div/div[5]/div/button");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/div[1]/main/div[2]/main/div[1]/div/div/div/div[5]/div/div/button[1]");

        }

        private void DeleteFromVintedBtn_Click(object sender, EventArgs e)
        {
            //var text = TheFoundBook.Text;
            //int indexof = text.IndexOf(" by");
            //var author = text.Substring(indexof + 3);
            //var authorlist = author.Split(" ,?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //string authorLastName = authorlist[authorlist.Length - 1].ToLower();


            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.vinted.lt";
            driver.Manage().Window.Maximize();
            new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.ElementExists(By.Id("onetrust-reject-all-handler")));
            SeleniumMethods.Click(driver, "Id", "onetrust-reject-all-handler");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/div[2]/div[1]/header/div/div/div[3]/div/a[1]/span/span");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/div[8]/div/div/div/div[2]/div/span[2]/span/span");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/div[8]/div/div/div/div[2]/div/span[1]/span/span");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "username", "SandyPanda");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "password", "Pinkstudy36+");
            Thread.Sleep(1000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/div[8]/div/div/div/div[2]/form/div[3]/div/div/button");
            //Thread.Sleep(20000);


            new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.ElementExists(By.Id("user-menu-button")));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "Id", "user-menu-button");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/div[2]/div[1]/header/div/div/div[3]/div[2]/div[1]/div/div[2]/div/div/div/div/ul/li[2]/a");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //bool found = SeleniumMethods.LinkisFound(driver, authorLastName);

            //var lastHeight = js.ExecuteScript("returndocument.body.scrollHeight");
            //while (true)
            //{
            //    js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            //    Thread.Sleep(200);

            //    var newHeight = js.ExecuteScript("return document.body.scrollHeight");
            //    Console.WriteLine(lastHeight + " - " + newHeight);
            //    if (newHeight.Equals(lastHeight))
            //        break;

            //    lastHeight = newHeight;
            //}

            //js.ExecuteScript("window.scrollBy(0,1000)");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //SeleniumMethods.Click(driver, "link", authorLastName);







        }
    }
}
