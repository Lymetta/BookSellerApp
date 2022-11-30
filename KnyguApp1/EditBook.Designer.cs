namespace KnyguApp1
{
    partial class Edit_Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Author = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.Blurb = new System.Windows.Forms.Label();
            this.AuthorTxtBox = new System.Windows.Forms.TextBox();
            this.TitleTxtBx = new System.Windows.Forms.TextBox();
            this.PriceTxtBx = new System.Windows.Forms.TextBox();
            this.CommentTxtBx = new System.Windows.Forms.TextBox();
            this.BlurbTxtBx = new System.Windows.Forms.TextBox();
            this.UpdateDb = new System.Windows.Forms.Button();
            this.ConditionComboBox = new System.Windows.Forms.ComboBox();
            this.Condition = new System.Windows.Forms.Label();
            this.bookId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Author.Location = new System.Drawing.Point(310, 38);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(57, 20);
            this.Author.TabIndex = 0;
            this.Author.Text = "Author";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(23, 89);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(38, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(310, 111);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 2;
            this.Price.Text = "Price";
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment.Location = new System.Drawing.Point(310, 183);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(78, 20);
            this.Comment.TabIndex = 3;
            this.Comment.Text = "Comment";
            // 
            // Blurb
            // 
            this.Blurb.AutoSize = true;
            this.Blurb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blurb.Location = new System.Drawing.Point(23, 257);
            this.Blurb.Name = "Blurb";
            this.Blurb.Size = new System.Drawing.Size(46, 20);
            this.Blurb.TabIndex = 4;
            this.Blurb.Text = "Blurb";
            // 
            // AuthorTxtBox
            // 
            this.AuthorTxtBox.Location = new System.Drawing.Point(314, 74);
            this.AuthorTxtBox.Name = "AuthorTxtBox";
            this.AuthorTxtBox.Size = new System.Drawing.Size(246, 20);
            this.AuthorTxtBox.TabIndex = 5;
            // 
            // TitleTxtBx
            // 
            this.TitleTxtBx.Location = new System.Drawing.Point(27, 124);
            this.TitleTxtBx.Multiline = true;
            this.TitleTxtBx.Name = "TitleTxtBx";
            this.TitleTxtBx.Size = new System.Drawing.Size(243, 42);
            this.TitleTxtBx.TabIndex = 6;
            // 
            // PriceTxtBx
            // 
            this.PriceTxtBx.Location = new System.Drawing.Point(314, 146);
            this.PriceTxtBx.Name = "PriceTxtBx";
            this.PriceTxtBx.Size = new System.Drawing.Size(243, 20);
            this.PriceTxtBx.TabIndex = 7;
            // 
            // CommentTxtBx
            // 
            this.CommentTxtBx.Location = new System.Drawing.Point(314, 206);
            this.CommentTxtBx.Multiline = true;
            this.CommentTxtBx.Name = "CommentTxtBx";
            this.CommentTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommentTxtBx.Size = new System.Drawing.Size(290, 71);
            this.CommentTxtBx.TabIndex = 8;
            // 
            // BlurbTxtBx
            // 
            this.BlurbTxtBx.Location = new System.Drawing.Point(27, 295);
            this.BlurbTxtBx.Multiline = true;
            this.BlurbTxtBx.Name = "BlurbTxtBx";
            this.BlurbTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BlurbTxtBx.Size = new System.Drawing.Size(577, 100);
            this.BlurbTxtBx.TabIndex = 9;
            // 
            // UpdateDb
            // 
            this.UpdateDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDb.Location = new System.Drawing.Point(223, 411);
            this.UpdateDb.Name = "UpdateDb";
            this.UpdateDb.Size = new System.Drawing.Size(181, 40);
            this.UpdateDb.TabIndex = 10;
            this.UpdateDb.Text = "Update in Database";
            this.UpdateDb.UseVisualStyleBackColor = true;
            this.UpdateDb.Click += new System.EventHandler(this.UpdateDb_Click);
            // 
            // ConditionComboBox
            // 
            this.ConditionComboBox.FormattingEnabled = true;
            this.ConditionComboBox.Items.AddRange(new object[] {
            "New",
            "Excellent",
            "Very Good",
            "Good",
            "Satisfactory",
            "Poor"});
            this.ConditionComboBox.Location = new System.Drawing.Point(27, 206);
            this.ConditionComboBox.Name = "ConditionComboBox";
            this.ConditionComboBox.Size = new System.Drawing.Size(243, 21);
            this.ConditionComboBox.TabIndex = 11;
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition.Location = new System.Drawing.Point(23, 183);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(76, 20);
            this.Condition.TabIndex = 12;
            this.Condition.Text = "Condition";
            // 
            // bookId
            // 
            this.bookId.AutoSize = true;
            this.bookId.Location = new System.Drawing.Point(37, 35);
            this.bookId.Name = "bookId";
            this.bookId.Size = new System.Drawing.Size(35, 13);
            this.bookId.TabIndex = 13;
            this.bookId.Text = "label1";
            // 
            // Edit_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 519);
            this.Controls.Add(this.bookId);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.ConditionComboBox);
            this.Controls.Add(this.UpdateDb);
            this.Controls.Add(this.BlurbTxtBx);
            this.Controls.Add(this.CommentTxtBx);
            this.Controls.Add(this.PriceTxtBx);
            this.Controls.Add(this.TitleTxtBx);
            this.Controls.Add(this.AuthorTxtBox);
            this.Controls.Add(this.Blurb);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Author);
            this.Name = "Edit_Books";
            this.Text = "Edit_Books";
            this.Load += new System.EventHandler(this.Edit_Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.Label Blurb;
        private System.Windows.Forms.TextBox AuthorTxtBox;
        private System.Windows.Forms.TextBox TitleTxtBx;
        private System.Windows.Forms.TextBox PriceTxtBx;
        private System.Windows.Forms.TextBox CommentTxtBx;
        private System.Windows.Forms.TextBox BlurbTxtBx;
        private System.Windows.Forms.Button UpdateDb;
        private System.Windows.Forms.ComboBox ConditionComboBox;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label bookId;
    }
}