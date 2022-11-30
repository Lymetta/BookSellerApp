using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnyguApp1
{
    public partial class FindBook : Form
    {
        public FindBook()
        {
            InitializeComponent();
        }

        private void FindBookBtn_Click(object sender, EventArgs e)
        {
            var search = FindBookTxtBx.Text;

            using (var ctx = new DataContext())
            {

                
                
                var foundBook = ctx.Books.FirstOrDefault(b => b.Title.Contains(search));

                if(foundBook != null)
                {
                    SearchResults result = new SearchResults($"{foundBook.Title} by {foundBook.Author}");
                    result.Show();
                    this.Close();
                    
                }else
                {
                    MessageBox.Show("No books found!");
                }
            }
        }
    }
}
