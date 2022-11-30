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
    public partial class Edit_Books : Form
    {
        public Edit_Books(string title, string author, double price, string comment, string blurb, string condition, int Id)
        {
            InitializeComponent();
            this.AuthorTxtBox.Text = author;
            this.TitleTxtBx.Text = title;
            this.PriceTxtBx.Text = price.ToString();
            this.CommentTxtBx.Text = comment;
            this.BlurbTxtBx.Text = blurb;
            this.ConditionComboBox.Text = condition;
            this.bookId.Text = Id.ToString();


        }

        private void Edit_Books_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void UpdateDb_Click(object sender, EventArgs e)
        {
            using (var ctx = new DataContext())
            {
                var searchId = int.Parse(bookId.Text);

                var toEdit = ctx.Books.FirstOrDefault(b => b.Id.Equals(searchId));

                if(toEdit != null)
                {
                    toEdit.Title = TitleTxtBx.Text;
                    toEdit.Author = AuthorTxtBox.Text;
                    toEdit.Price = double.Parse(PriceTxtBx.Text);
                    toEdit.Comment = CommentTxtBx.Text;
                    toEdit.Blurb = BlurbTxtBx.Text;
                    toEdit.Condition = ConditionComboBox.Text;

                    MessageBox.Show("Book updated");
                }

                ctx.SaveChanges();

            }
        }
    }
}
