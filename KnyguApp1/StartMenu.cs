using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace KnyguApp1
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewBook addNewBook = new AddNewBook();
            addNewBook.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindBook findBook = new FindBook();
            findBook.Show();
        }

        private void DailyOtterBtn_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://dailyotter.org/";
        }
    }
}
