namespace KnyguApp1
{
    partial class FindBook
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
            this.EnterTitle = new System.Windows.Forms.Label();
            this.FindBookTxtBx = new System.Windows.Forms.TextBox();
            this.FindBookBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterTitle
            // 
            this.EnterTitle.AutoSize = true;
            this.EnterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTitle.Location = new System.Drawing.Point(145, 46);
            this.EnterTitle.Name = "EnterTitle";
            this.EnterTitle.Size = new System.Drawing.Size(171, 25);
            this.EnterTitle.TabIndex = 0;
            this.EnterTitle.Text = "Enter Title of Book";
            // 
            // FindBookTxtBx
            // 
            this.FindBookTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBookTxtBx.Location = new System.Drawing.Point(53, 114);
            this.FindBookTxtBx.Name = "FindBookTxtBx";
            this.FindBookTxtBx.Size = new System.Drawing.Size(349, 26);
            this.FindBookTxtBx.TabIndex = 1;
            // 
            // FindBookBtn
            // 
            this.FindBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBookBtn.Location = new System.Drawing.Point(159, 178);
            this.FindBookBtn.Name = "FindBookBtn";
            this.FindBookBtn.Size = new System.Drawing.Size(125, 50);
            this.FindBookBtn.TabIndex = 2;
            this.FindBookBtn.Text = "Find!";
            this.FindBookBtn.UseVisualStyleBackColor = true;
            this.FindBookBtn.Click += new System.EventHandler(this.FindBookBtn_Click);
            // 
            // FindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 287);
            this.Controls.Add(this.FindBookBtn);
            this.Controls.Add(this.FindBookTxtBx);
            this.Controls.Add(this.EnterTitle);
            this.Name = "FindBook";
            this.Text = "Find Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterTitle;
        private System.Windows.Forms.TextBox FindBookTxtBx;
        private System.Windows.Forms.Button FindBookBtn;
    }
}