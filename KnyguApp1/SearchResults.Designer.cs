namespace KnyguApp1
{
    partial class SearchResults
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
            this.BookFound = new System.Windows.Forms.Label();
            this.TheFoundBook = new System.Windows.Forms.Label();
            this.EditBookBtn = new System.Windows.Forms.Button();
            this.DeleteFromVintedBtn = new System.Windows.Forms.Button();
            this.DeleteFromDbBtn = new System.Windows.Forms.Button();
            this.DeleteFromSenaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookFound
            // 
            this.BookFound.AutoSize = true;
            this.BookFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookFound.Location = new System.Drawing.Point(127, 53);
            this.BookFound.Name = "BookFound";
            this.BookFound.Size = new System.Drawing.Size(189, 25);
            this.BookFound.TabIndex = 0;
            this.BookFound.Text = "A Book Was Found!";
            // 
            // TheFoundBook
            // 
            this.TheFoundBook.AutoSize = true;
            this.TheFoundBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheFoundBook.Location = new System.Drawing.Point(99, 128);
            this.TheFoundBook.MaximumSize = new System.Drawing.Size(250, 100);
            this.TheFoundBook.Name = "TheFoundBook";
            this.TheFoundBook.Size = new System.Drawing.Size(51, 20);
            this.TheFoundBook.TabIndex = 1;
            this.TheFoundBook.Text = "label1";
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.Location = new System.Drawing.Point(30, 203);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(156, 43);
            this.EditBookBtn.TabIndex = 2;
            this.EditBookBtn.Text = "Edit Book Info";
            this.EditBookBtn.UseVisualStyleBackColor = true;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // DeleteFromVintedBtn
            // 
            this.DeleteFromVintedBtn.Location = new System.Drawing.Point(30, 269);
            this.DeleteFromVintedBtn.Name = "DeleteFromVintedBtn";
            this.DeleteFromVintedBtn.Size = new System.Drawing.Size(156, 43);
            this.DeleteFromVintedBtn.TabIndex = 3;
            this.DeleteFromVintedBtn.Text = "Delete from Vinted";
            this.DeleteFromVintedBtn.UseVisualStyleBackColor = true;
            this.DeleteFromVintedBtn.Click += new System.EventHandler(this.DeleteFromVintedBtn_Click);
            // 
            // DeleteFromDbBtn
            // 
            this.DeleteFromDbBtn.Location = new System.Drawing.Point(240, 203);
            this.DeleteFromDbBtn.Name = "DeleteFromDbBtn";
            this.DeleteFromDbBtn.Size = new System.Drawing.Size(156, 43);
            this.DeleteFromDbBtn.TabIndex = 4;
            this.DeleteFromDbBtn.Text = "Delete From Database";
            this.DeleteFromDbBtn.UseVisualStyleBackColor = true;
            this.DeleteFromDbBtn.Click += new System.EventHandler(this.DeleteFromDbBtn_Click);
            // 
            // DeleteFromSenaBtn
            // 
            this.DeleteFromSenaBtn.Location = new System.Drawing.Point(240, 269);
            this.DeleteFromSenaBtn.Name = "DeleteFromSenaBtn";
            this.DeleteFromSenaBtn.Size = new System.Drawing.Size(156, 43);
            this.DeleteFromSenaBtn.TabIndex = 5;
            this.DeleteFromSenaBtn.Text = "Delete from Sena";
            this.DeleteFromSenaBtn.UseVisualStyleBackColor = true;
            this.DeleteFromSenaBtn.Click += new System.EventHandler(this.DeleteFromSenaBtn_Click);
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 338);
            this.Controls.Add(this.DeleteFromSenaBtn);
            this.Controls.Add(this.DeleteFromDbBtn);
            this.Controls.Add(this.DeleteFromVintedBtn);
            this.Controls.Add(this.EditBookBtn);
            this.Controls.Add(this.TheFoundBook);
            this.Controls.Add(this.BookFound);
            this.Name = "SearchResults";
            this.Text = "SearchResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BookFound;
        private System.Windows.Forms.Label TheFoundBook;
        private System.Windows.Forms.Button EditBookBtn;
        private System.Windows.Forms.Button DeleteFromVintedBtn;
        private System.Windows.Forms.Button DeleteFromDbBtn;
        private System.Windows.Forms.Button DeleteFromSenaBtn;
    }
}