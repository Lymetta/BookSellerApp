namespace KnyguApp1
{
    partial class AddNewBook
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AddBooktoDBBtn = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Label();
            this.BookTitle = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.Label();
            this.PublishYear = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.Label();
            this.ISBNNum = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Condition = new System.Windows.Forms.Label();
            this.Blurb = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.Label();
            this.ParcelSize = new System.Windows.Forms.Label();
            this.AuthorTxtBx = new System.Windows.Forms.TextBox();
            this.TitleTxtBx = new System.Windows.Forms.TextBox();
            this.PriceTxtBx = new System.Windows.Forms.TextBox();
            this.CommentTxtBx = new System.Windows.Forms.TextBox();
            this.BlurbTxtBx = new System.Windows.Forms.TextBox();
            this.PublisherTxtBx = new System.Windows.Forms.TextBox();
            this.PublishYearTxtBx = new System.Windows.Forms.TextBox();
            this.ISBNTxtBox = new System.Windows.Forms.TextBox();
            this.ConditionComboBx = new System.Windows.Forms.ComboBox();
            this.ParcelComboBx = new System.Windows.Forms.ComboBox();
            this.LanguageComboBx = new System.Windows.Forms.ComboBox();
            this.CategoryComboBx = new System.Windows.Forms.ComboBox();
            this.AddtoVinted = new System.Windows.Forms.Button();
            this.AddtoSenaBtn = new System.Windows.Forms.Button();
            this.AddImages = new System.Windows.Forms.Label();
            this.AddImagePathBox = new System.Windows.Forms.TextBox();
            this.AddImageNameBox1 = new System.Windows.Forms.TextBox();
            this.AddImageNameBox2 = new System.Windows.Forms.TextBox();
            this.AddImageNames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(752, 642);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(127, 34);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddBooktoDBBtn
            // 
            this.AddBooktoDBBtn.Location = new System.Drawing.Point(57, 642);
            this.AddBooktoDBBtn.Name = "AddBooktoDBBtn";
            this.AddBooktoDBBtn.Size = new System.Drawing.Size(127, 34);
            this.AddBooktoDBBtn.TabIndex = 1;
            this.AddBooktoDBBtn.Text = "Add Book to Database";
            this.AddBooktoDBBtn.UseVisualStyleBackColor = true;
            this.AddBooktoDBBtn.Click += new System.EventHandler(this.AddBooktoDBBtn_Click);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(30, 29);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(38, 13);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author";
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSize = true;
            this.BookTitle.Location = new System.Drawing.Point(339, 29);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(27, 13);
            this.BookTitle.TabIndex = 3;
            this.BookTitle.Text = "Title";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(30, 98);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(49, 13);
            this.Category.TabIndex = 4;
            this.Category.Text = "Category";
            // 
            // Publisher
            // 
            this.Publisher.AutoSize = true;
            this.Publisher.Location = new System.Drawing.Point(275, 98);
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(50, 13);
            this.Publisher.TabIndex = 5;
            this.Publisher.Text = "Publisher";
            // 
            // PublishYear
            // 
            this.PublishYear.AutoSize = true;
            this.PublishYear.Location = new System.Drawing.Point(584, 98);
            this.PublishYear.Name = "PublishYear";
            this.PublishYear.Size = new System.Drawing.Size(92, 13);
            this.PublishYear.TabIndex = 6;
            this.PublishYear.Text = "Year of Publishing";
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(35, 176);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(55, 13);
            this.Language.TabIndex = 7;
            this.Language.Text = "Language";
            // 
            // ISBNNum
            // 
            this.ISBNNum.AutoSize = true;
            this.ISBNNum.Location = new System.Drawing.Point(277, 176);
            this.ISBNNum.Name = "ISBNNum";
            this.ISBNNum.Size = new System.Drawing.Size(32, 13);
            this.ISBNNum.TabIndex = 8;
            this.ISBNNum.Text = "ISBN";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(278, 258);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 9;
            this.Price.Text = "Price";
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.Location = new System.Drawing.Point(584, 176);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(51, 13);
            this.Condition.TabIndex = 10;
            this.Condition.Text = "Condition";
            // 
            // Blurb
            // 
            this.Blurb.AutoSize = true;
            this.Blurb.Location = new System.Drawing.Point(30, 360);
            this.Blurb.Name = "Blurb";
            this.Blurb.Size = new System.Drawing.Size(31, 13);
            this.Blurb.TabIndex = 11;
            this.Blurb.Text = "Blurb";
            // 
            // Comment
            // 
            this.Comment.AutoSize = true;
            this.Comment.Location = new System.Drawing.Point(584, 258);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(51, 13);
            this.Comment.TabIndex = 12;
            this.Comment.Text = "Comment";
            // 
            // ParcelSize
            // 
            this.ParcelSize.AutoSize = true;
            this.ParcelSize.Location = new System.Drawing.Point(30, 258);
            this.ParcelSize.Name = "ParcelSize";
            this.ParcelSize.Size = new System.Drawing.Size(60, 13);
            this.ParcelSize.TabIndex = 13;
            this.ParcelSize.Text = "Parcel Size";
            // 
            // AuthorTxtBx
            // 
            this.AuthorTxtBx.Location = new System.Drawing.Point(33, 57);
            this.AuthorTxtBx.Name = "AuthorTxtBx";
            this.AuthorTxtBx.Size = new System.Drawing.Size(292, 20);
            this.AuthorTxtBx.TabIndex = 14;
            // 
            // TitleTxtBx
            // 
            this.TitleTxtBx.Location = new System.Drawing.Point(342, 57);
            this.TitleTxtBx.Name = "TitleTxtBx";
            this.TitleTxtBx.Size = new System.Drawing.Size(509, 20);
            this.TitleTxtBx.TabIndex = 15;
            // 
            // PriceTxtBx
            // 
            this.PriceTxtBx.Location = new System.Drawing.Point(278, 293);
            this.PriceTxtBx.Name = "PriceTxtBx";
            this.PriceTxtBx.Size = new System.Drawing.Size(251, 20);
            this.PriceTxtBx.TabIndex = 16;
            // 
            // CommentTxtBx
            // 
            this.CommentTxtBx.Location = new System.Drawing.Point(587, 293);
            this.CommentTxtBx.Multiline = true;
            this.CommentTxtBx.Name = "CommentTxtBx";
            this.CommentTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CommentTxtBx.Size = new System.Drawing.Size(264, 55);
            this.CommentTxtBx.TabIndex = 17;
            // 
            // BlurbTxtBx
            // 
            this.BlurbTxtBx.Location = new System.Drawing.Point(33, 376);
            this.BlurbTxtBx.Multiline = true;
            this.BlurbTxtBx.Name = "BlurbTxtBx";
            this.BlurbTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BlurbTxtBx.Size = new System.Drawing.Size(498, 200);
            this.BlurbTxtBx.TabIndex = 18;
            // 
            // PublisherTxtBx
            // 
            this.PublisherTxtBx.Location = new System.Drawing.Point(280, 124);
            this.PublisherTxtBx.Name = "PublisherTxtBx";
            this.PublisherTxtBx.Size = new System.Drawing.Size(251, 20);
            this.PublisherTxtBx.TabIndex = 19;
            // 
            // PublishYearTxtBx
            // 
            this.PublishYearTxtBx.Location = new System.Drawing.Point(587, 124);
            this.PublishYearTxtBx.Name = "PublishYearTxtBx";
            this.PublishYearTxtBx.Size = new System.Drawing.Size(213, 20);
            this.PublishYearTxtBx.TabIndex = 20;
            // 
            // ISBNTxtBox
            // 
            this.ISBNTxtBox.Location = new System.Drawing.Point(278, 199);
            this.ISBNTxtBox.Name = "ISBNTxtBox";
            this.ISBNTxtBox.Size = new System.Drawing.Size(251, 20);
            this.ISBNTxtBox.TabIndex = 21;
            // 
            // ConditionComboBx
            // 
            this.ConditionComboBx.FormattingEnabled = true;
            this.ConditionComboBx.Items.AddRange(new object[] {
            "New",
            "Excellent",
            "Very Good",
            "Good",
            "Satisfactory",
            "Poor"});
            this.ConditionComboBx.Location = new System.Drawing.Point(587, 198);
            this.ConditionComboBx.Name = "ConditionComboBx";
            this.ConditionComboBx.Size = new System.Drawing.Size(212, 21);
            this.ConditionComboBx.TabIndex = 22;
            // 
            // ParcelComboBx
            // 
            this.ParcelComboBx.FormattingEnabled = true;
            this.ParcelComboBx.Items.AddRange(new object[] {
            "XS/S",
            "M",
            "L"});
            this.ParcelComboBx.Location = new System.Drawing.Point(33, 293);
            this.ParcelComboBx.Name = "ParcelComboBx";
            this.ParcelComboBx.Size = new System.Drawing.Size(198, 21);
            this.ParcelComboBx.TabIndex = 23;
            // 
            // LanguageComboBx
            // 
            this.LanguageComboBx.FormattingEnabled = true;
            this.LanguageComboBx.Items.AddRange(new object[] {
            "Lithuanian",
            "English",
            "Russian"});
            this.LanguageComboBx.Location = new System.Drawing.Point(33, 198);
            this.LanguageComboBx.Name = "LanguageComboBx";
            this.LanguageComboBx.Size = new System.Drawing.Size(198, 21);
            this.LanguageComboBx.TabIndex = 24;
            // 
            // CategoryComboBx
            // 
            this.CategoryComboBx.FormattingEnabled = true;
            this.CategoryComboBx.Items.AddRange(new object[] {
            "Romance",
            "Contemporary Fiction",
            "Thriller/Detective",
            "Fantasy",
            "Health",
            "Food&Drink",
            "Teen",
            "Children",
            "Art",
            "Other"});
            this.CategoryComboBx.Location = new System.Drawing.Point(35, 125);
            this.CategoryComboBx.Name = "CategoryComboBx";
            this.CategoryComboBx.Size = new System.Drawing.Size(196, 21);
            this.CategoryComboBx.TabIndex = 25;
            // 
            // AddtoVinted
            // 
            this.AddtoVinted.Location = new System.Drawing.Point(213, 642);
            this.AddtoVinted.Name = "AddtoVinted";
            this.AddtoVinted.Size = new System.Drawing.Size(127, 34);
            this.AddtoVinted.TabIndex = 26;
            this.AddtoVinted.Text = "Add Book to Vinted";
            this.AddtoVinted.UseVisualStyleBackColor = true;
            this.AddtoVinted.Click += new System.EventHandler(this.AddtoVinted_Click);
            // 
            // AddtoSenaBtn
            // 
            this.AddtoSenaBtn.Location = new System.Drawing.Point(370, 642);
            this.AddtoSenaBtn.Name = "AddtoSenaBtn";
            this.AddtoSenaBtn.Size = new System.Drawing.Size(127, 34);
            this.AddtoSenaBtn.TabIndex = 27;
            this.AddtoSenaBtn.Text = "Add Book to Sena";
            this.AddtoSenaBtn.UseVisualStyleBackColor = true;
            this.AddtoSenaBtn.Click += new System.EventHandler(this.AddtoSenaBtn_Click);
            // 
            // AddImages
            // 
            this.AddImages.AutoSize = true;
            this.AddImages.Location = new System.Drawing.Point(584, 360);
            this.AddImages.Name = "AddImages";
            this.AddImages.Size = new System.Drawing.Size(83, 13);
            this.AddImages.TabIndex = 28;
            this.AddImages.Text = "Add Image Path";
            // 
            // AddImagePathBox
            // 
            this.AddImagePathBox.Location = new System.Drawing.Point(587, 376);
            this.AddImagePathBox.Multiline = true;
            this.AddImagePathBox.Name = "AddImagePathBox";
            this.AddImagePathBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AddImagePathBox.Size = new System.Drawing.Size(253, 40);
            this.AddImagePathBox.TabIndex = 29;
            // 
            // AddImageNameBox1
            // 
            this.AddImageNameBox1.Location = new System.Drawing.Point(587, 477);
            this.AddImageNameBox1.Multiline = true;
            this.AddImageNameBox1.Name = "AddImageNameBox1";
            this.AddImageNameBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AddImageNameBox1.Size = new System.Drawing.Size(253, 35);
            this.AddImageNameBox1.TabIndex = 30;
            // 
            // AddImageNameBox2
            // 
            this.AddImageNameBox2.Location = new System.Drawing.Point(587, 529);
            this.AddImageNameBox2.Multiline = true;
            this.AddImageNameBox2.Name = "AddImageNameBox2";
            this.AddImageNameBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AddImageNameBox2.Size = new System.Drawing.Size(253, 36);
            this.AddImageNameBox2.TabIndex = 31;
            // 
            // AddImageNames
            // 
            this.AddImageNames.AutoSize = true;
            this.AddImageNames.Location = new System.Drawing.Point(584, 452);
            this.AddImageNames.Name = "AddImageNames";
            this.AddImageNames.Size = new System.Drawing.Size(94, 13);
            this.AddImageNames.TabIndex = 32;
            this.AddImageNames.Text = "Add Image Names";
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 688);
            this.Controls.Add(this.AddImageNames);
            this.Controls.Add(this.AddImageNameBox2);
            this.Controls.Add(this.AddImageNameBox1);
            this.Controls.Add(this.AddImagePathBox);
            this.Controls.Add(this.AddImages);
            this.Controls.Add(this.AddtoSenaBtn);
            this.Controls.Add(this.AddtoVinted);
            this.Controls.Add(this.CategoryComboBx);
            this.Controls.Add(this.LanguageComboBx);
            this.Controls.Add(this.ParcelComboBx);
            this.Controls.Add(this.ConditionComboBx);
            this.Controls.Add(this.ISBNTxtBox);
            this.Controls.Add(this.PublishYearTxtBx);
            this.Controls.Add(this.PublisherTxtBx);
            this.Controls.Add(this.BlurbTxtBx);
            this.Controls.Add(this.CommentTxtBx);
            this.Controls.Add(this.PriceTxtBx);
            this.Controls.Add(this.TitleTxtBx);
            this.Controls.Add(this.AuthorTxtBx);
            this.Controls.Add(this.ParcelSize);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Blurb);
            this.Controls.Add(this.Condition);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ISBNNum);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.PublishYear);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.BookTitle);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.AddBooktoDBBtn);
            this.Controls.Add(this.CancelBtn);
            this.Name = "AddNewBook";
            this.Text = "Add a New Book";
            this.Load += new System.EventHandler(this.AddNewBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AddBooktoDBBtn;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label BookTitle;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Publisher;
        private System.Windows.Forms.Label PublishYear;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label ISBNNum;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label Blurb;
        private System.Windows.Forms.Label Comment;
        private System.Windows.Forms.Label ParcelSize;
        private System.Windows.Forms.TextBox AuthorTxtBx;
        private System.Windows.Forms.TextBox TitleTxtBx;
        private System.Windows.Forms.TextBox PriceTxtBx;
        private System.Windows.Forms.TextBox CommentTxtBx;
        private System.Windows.Forms.TextBox BlurbTxtBx;
        private System.Windows.Forms.TextBox PublisherTxtBx;
        private System.Windows.Forms.TextBox PublishYearTxtBx;
        private System.Windows.Forms.TextBox ISBNTxtBox;
        private System.Windows.Forms.ComboBox ConditionComboBx;
        private System.Windows.Forms.ComboBox ParcelComboBx;
        private System.Windows.Forms.ComboBox LanguageComboBx;
        private System.Windows.Forms.ComboBox CategoryComboBx;
        private System.Windows.Forms.Button AddtoVinted;
        private System.Windows.Forms.Button AddtoSenaBtn;
        private System.Windows.Forms.Label AddImages;
        private System.Windows.Forms.TextBox AddImagePathBox;
        private System.Windows.Forms.TextBox AddImageNameBox1;
        private System.Windows.Forms.TextBox AddImageNameBox2;
        private System.Windows.Forms.Label AddImageNames;
    }
}