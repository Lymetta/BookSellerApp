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
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using SeleniumExtras.WaitHelpers;



namespace KnyguApp1
{
    public partial class AddNewBook : Form
    {
        public AddNewBook()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            this.TopMost = false;
        }

        private void AddBooktoDBBtn_Click(object sender, EventArgs e)
        {
            var title = TitleTxtBx.Text;
            var author = AuthorTxtBx.Text;
            var category = CategoryComboBx.Text;
            var publisher = PublisherTxtBx.Text;
            var publishYear = PublishYearTxtBx.Text;
            var language = LanguageComboBx.Text;
            var isbn = ISBNTxtBox.Text;
            var condition = ConditionComboBx.Text;
            var parcelSize = ParcelComboBx.Text;
            double price = Double.Parse(PriceTxtBx.Text);
            var comment = CommentTxtBx.Text;
            var blurb = BlurbTxtBx.Text;
            var imagePath = AddImagePathBox.Text;
            var image1 = AddImageNameBox1.Text;
            var image2 = AddImageNameBox2.Text;
            

            using (var ctx = new DataContext())
            {
                var book = new Book();
                book.Title = title;
                book.Author = author;
                book.Category = category;
                book.Publisher = publisher;
                book.PublishYear = publishYear;
                book.Language = language;
                book.ISBN = isbn;
                book.Condition = condition;
                book.Comment= comment;
                book.ParcelSize = parcelSize;
                book.Price = price;
                book.Blurb = blurb;
                book.ImagePath = imagePath;
                book.Image1Name = image1;
                book.Image2Name = image2;
                

                ctx.Books.Add(book);
                ctx.SaveChanges();
            }

            MessageBox.Show("Book added to Database");
            AuthorTxtBx.Text = String.Empty;
            CategoryComboBx.Text = String.Empty;
            PublisherTxtBx.Text = String.Empty;
            PublishYearTxtBx.Text = String.Empty;
            LanguageComboBx.Text = String.Empty;
            ISBNTxtBox.Text = String.Empty;
            ConditionComboBx.Text = String.Empty;
            ParcelComboBx.Text = String.Empty;
            PriceTxtBx.Text = String.Empty;
            CommentTxtBx.Text = String.Empty;
            BlurbTxtBx.Text = String.Empty;
            AddImagePathBox.Text = String.Empty;
            AddImageNameBox1.Text = String.Empty;
            AddImageNameBox2.Text = String.Empty;
            


        }

        private void AddtoSenaBtn_Click(object sender, EventArgs e)
        {
            string booktitle = null;
            string bookauthor = null;
            string publishYear = null;
            string blurb = null;
            string comment = null;
            string isbn = null;
            string condition = null;
            string searchBy = TitleTxtBx.Text;
            string image1 = null;
            string image2 = null;
            string price = null;
            string language = null;
            string imagePath = null;
            string category = null;


            using(var ctx = new DataContext())
            {
                var toAdd = ctx.Books.FirstOrDefault(b => b.Title.Contains(searchBy));

                if(toAdd != null)
                {
                    booktitle = toAdd.Title;
                    bookauthor = toAdd.Author;
                    publishYear = toAdd.PublishYear;
                    blurb = toAdd.Blurb;
                    comment= toAdd.Comment;
                    isbn = toAdd.ISBN;
                    condition = toAdd.Condition;
                    imagePath = toAdd.ImagePath;
                    image1 = toAdd.Image1Name;
                    image2 = toAdd.Image2Name;
                    price = toAdd.Price.ToString();
                    category = toAdd.Category;

                    if(toAdd.Language == "Lithuanian")
                    {
                        language = "Lietuvių";
                    } else if (toAdd.Language == "English")
                    {
                        language = "Anglų";
                    }else if (toAdd.Language == "Russian")
                    {
                        language = "Rusų";
                    }

                    if(toAdd.Condition == "New")
                    {
                        condition = "Puiki";
                    }else if (toAdd.Condition == "Excellent" || toAdd.Condition == "Very Good")
                    {
                        condition = "Labai gera";
                    }else if (toAdd.Condition == "Good")
                    {
                        condition = "Gera";
                    }else if (toAdd.Condition == "Satisfactory")
                    {
                        condition = "Patenkinama";
                    }else if (toAdd.Condition == "Poor")
                    {
                        condition = "Prasta";
                    }

                    if (toAdd.Category == "Romance")
                    {
                        category = "Meilės romanai";
                    }
                    else if (toAdd.Category == "Contemporary Fiction")
                    {
                        category = "Grožinė literatūra"; 
                    }
                    else if (toAdd.Category == "Thriller/Detective")
                    {
                        category = "Detektyvai";
                    }
                    else if (toAdd.Category == "Fantasy")
                    {
                        category = "Fantastika";
                    }
                    else if (toAdd.Category == "Health")
                    {
                        category = "Šeima, sveikata, vaikams";
                    }
                    else if (toAdd.Category == "Food&Drink")
                    {
                        category = "Receptai";
                    }
                    else if (toAdd.Category == "Teen")
                    {
                        category = "Jaunimui";
                    }
                    else if (toAdd.Category == "Children")
                    {
                        category = "Vaikams";
                    }
                    else
                    {
                        category = "Kita";
                    }
                }

            }
            
            
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.sena.lt/naujas-skelbimas";
            driver.Manage().Window.Maximize();

            SeleniumMethods.Click(driver, "XPath", "/html/body/div[3]/div[2]/div[1]/div[2]/div[2]/button[1]");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            // username and password have been removed
            SeleniumMethods.EnterText(driver, "Id", "username", "USERNAME");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "password", "PASSWORD");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/div/div/div/section[2]/form/div/div[3]/button");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //enter new book search
            new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.ElementExists(By.XPath("/html/body/main/div/div/div/div[2]/div/div/div[1]/div[1]/form/div/span[1]/span[1]/span/span/textarea")));
            SeleniumMethods.EnterText(driver, "XPath", "/html/body/main/div/div/div/div[2]/div/div/div[1]/div[1]/form/div/span[1]/span[1]/span/span/textarea", booktitle);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "Id", "new-book-btn");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.ElementExists(By.XPath("/html/body/main/div/div/div/div[2]/form/div[1]/div/div[2]/div/div/div[1]/div/input")));
            SeleniumMethods.EnterText(driver, "XPath", "/html/body/main/div/div/div/div[2]/form/div[1]/div/div[2]/div/div/div[1]/div/input", booktitle);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/form/div[1]/div/div[2]/div/div/div[2]/div[1]/span/span[1]/span/span[1]");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "XPath", "/html/body/span/span/span[1]/input", bookauthor);
            Thread.Sleep(2000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/span/span/span[2]/ul/li");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "Id", "book-year");
            SeleniumMethods.ClearField(driver, "Id", "book-year");
            SeleniumMethods.EnterText(driver, "Id", "book-year", publishYear);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "XPath", "/html/body/main/div/div/div/div[2]/form/div[1]/div/div[2]/div/div/div[8]/div/div/input", isbn);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/form/div[1]/div/div[2]/div/div/div[7]/div/span/span[1]/span");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            SeleniumMethods.SelectDropDown(driver, "Id", "languages", language);
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "summary", blurb);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "Id", "price");
            SeleniumMethods.ClearField(driver, "Id", "price");
            SeleniumMethods.EnterText(driver, "Id", "price", price);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.SelectDropDown(driver, "Id", "condition-id", condition);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "comment", comment);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //add category
            SeleniumMethods.SelectDropDown(driver, "XPath", "/html/body/main/div/div/div/div[2]/form/div[1]/div/div[2]/div/div/div[3]/div/select", category);
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                        

            //upload images
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/form/div[1]/div/div[1]/section/div[1]/div[1]/div/button");

            SeleniumMethods.UploadFile(imagePath, image1);

            new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.ElementExists(By.XPath("/html/body/main/div/div/div/div[2]/form/div[1]/div/div[1]/section/div[2]/div[1]/div/button[5]")));

            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/div/div/div[2]/form/div[1]/div/div[1]/section/div[2]/div[1]/div/button[5]");

            SeleniumMethods.UploadFile(imagePath, image2);





        }

        private void AddtoVinted_Click(object sender, EventArgs e)
        {
            string booktitle = null;
            string commentBlurb = null;
            string isbn = null;
            string condition = null;
            string searchBy = TitleTxtBx.Text;
            string image1 = null;
            string image2 = null;
            string price = null;
            string size = null;
            string imagePath = null;
            string category = null;


            using (var ctx = new DataContext())
            {
                var toAdd = ctx.Books.FirstOrDefault(b => b.Title.Contains(searchBy));

                if (toAdd != null)
                {
                    booktitle = toAdd.Author + " \"" + toAdd.Title + "\"";
                    
                    
                    commentBlurb = toAdd.Comment + "\n\n"+ toAdd.Blurb;
                    isbn = toAdd.ISBN;
                    condition = toAdd.Condition;
                    imagePath = toAdd.ImagePath;
                    image1 = toAdd.Image1Name;
                    image2 = toAdd.Image2Name;
                    price = toAdd.Price.ToString();
                    category = toAdd.Category;
                    condition = toAdd.Condition;
                    size = toAdd.ParcelSize;


                    
                }

            }





            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.vinted.lt/items/new";
            driver.Manage().Window.Maximize();
            new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.ElementExists(By.Id("onetrust-reject-all-handler")));
            SeleniumMethods.Click(driver, "Id", "onetrust-reject-all-handler");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div[2]/div/div[2]/div/span[2]/span");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div[2]/div/div[2]/div/span[1]/span");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            
            // username and password have been removed
            SeleniumMethods.EnterText(driver, "Id", "username", "USERNAME");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "password", "PASSWORD");
            Thread.Sleep(1000);
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div[2]/div/div[2]/form/div[3]/div/div/button");
            new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.ElementExists(By.Id("title")));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //SeleniumMethods.Click(driver, "XPath", "/html/body/div[2]/div[1]/header/div/div/div[3]/div[2]/a");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "title", booktitle);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            //add pics 
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[3]/div/div[2]/div/div/div/div[5]/div/button");
            SeleniumMethods.UploadFile(imagePath, image1);
            new WebDriverWait(driver, TimeSpan.FromSeconds(120)).Until(ExpectedConditions.ElementExists(By.XPath("/html/body/main/div/section/div/div[2]/section/div/div/div[3]/div/div[2]/div/div/div/div[2]/div[2]/div/button")));
            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[3]/div/div[2]/div/div/div/div[2]/div[2]/div/button");
            SeleniumMethods.UploadFile(imagePath, image2);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "description", commentBlurb);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "price", price);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "Id", "catalog_id");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "Id", "catalog-2309");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.Click(driver, "Id", "catalog-2312");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            if (category == "Contemporary Fiction" || category == "Romance" || category == "Thriller/Detective" || category == "Fantasy")
            {
                SeleniumMethods.Click(driver, "Id", "catalog-2319");

                switch (category)
                {
                    case "Contemporary Fiction":
                        {
                            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[3]/div/div[2]/label/span[1]");
                            break;
                        }
                    case "Romance":
                        {
                            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[7]/div/div[2]/label/span[1]");
                            break;
                        }
                    case "Thriller/Detective":
                        {
                            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[4]/div/div[2]/label/span[1]");
                            break;
                        }
                    case "Fantasy":
                        {
                            SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[8]/div/div[2]/label/span[1]");
                            break;
                        }
                }


            }else if (category == "Health" || category == "Food&Drink" || category == "Art")
            {
                SeleniumMethods.Click(driver, "Id", "catalog-2320");

                if (category == "Health")
                {
                    SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[6]/div/div[2]/label/span[1]");
                }
                else if (category == "Food&Drink")
                {
                    SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[5]/div/div[2]/label/span[1]");
                }
                else if (category == "Art")
                {
                    SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[1]/div/div[2]/label/span[1]");
                }

            }
            else if (category == "Teen" || category == "Children")
            {
                SeleniumMethods.Click(driver, "Id", "catalog-2318");
                if (category == "Teen")
                {
                    SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[1]/div/div[2]/label/span[1]");
                }
                else if (category == "Children")
                {
                    SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[7]/div[1]/div/div[1]/div/div/div[2]/ul/li[2]/div/div[2]/label/span[1]");
                }

            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            SeleniumMethods.Click(driver, "Id", "status_id");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            switch (condition)
            {
                case "New":
                    {
                        
                        SeleniumMethods.Click(driver, "Id", "status-1");
                        break;
                    }
                case "Excellent":
                    {
                        SeleniumMethods.Click(driver, "Id", "status-2");
                        break;
                    }
                case "Very Good":
                    {
                        SeleniumMethods.Click(driver, "Id", "status-2");
                        break;
                    }
                case "Good":
                    {
                        SeleniumMethods.Click(driver, "Id", "status-3");
                        break;
                    }
                case "Satisfactory":
                    {
                        SeleniumMethods.Click(driver, "Id", "status-4");
                        break;
                    }

            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            SeleniumMethods.EnterText(driver, "Id", "isbn", isbn);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            switch (size)
            {
                case "XS/S":
                    {
                        SeleniumMethods.Click(driver, "XPath", "/html/body/main/div/section/div/div[2]/section/div/div/div[10]/div/div[2]/div/div[2]/label/span[1]");
                        break;
                    }
                case "M":
                    {
                        SeleniumMethods.Click(driver, "Id", "package_type_selector_2");
                        break;
                    }
                case "L":
                    {
                        SeleniumMethods.Click(driver, "Id", "package_type_selector_3");
                        break;
                    }
            }
            
        }
    }
}
