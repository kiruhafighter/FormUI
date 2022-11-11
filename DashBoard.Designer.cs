namespace FormUI
{
    partial class DashBoard
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
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailAddressText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 30;
            this.peopleFoundListbox.Location = new System.Drawing.Point(12, 129);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(641, 484);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.lastNameText.Location = new System.Drawing.Point(136, 27);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(169, 35);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.lastNameLbl.Location = new System.Drawing.Point(12, 27);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(118, 35);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Last Name:";
            this.lastNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.searchButton.Location = new System.Drawing.Point(77, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 40);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(692, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNameText
            // 
            this.firstNameText.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.firstNameText.Location = new System.Drawing.Point(827, 129);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(248, 35);
            this.firstNameText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.label2.Location = new System.Drawing.Point(692, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.lastNameTextBox.Location = new System.Drawing.Point(827, 200);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(248, 35);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.label3.Location = new System.Drawing.Point(659, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 35);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Address:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // emailAddressText
            // 
            this.emailAddressText.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.emailAddressText.Location = new System.Drawing.Point(827, 272);
            this.emailAddressText.Name = "emailAddressText";
            this.emailAddressText.Size = new System.Drawing.Size(248, 35);
            this.emailAddressText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.label4.Location = new System.Drawing.Point(731, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.phoneText.Location = new System.Drawing.Point(827, 344);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(248, 35);
            this.phoneText.TabIndex = 10;
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Malgun Gothic", 15.75F);
            this.InsertButton.Location = new System.Drawing.Point(942, 396);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(123, 40);
            this.InsertButton.TabIndex = 12;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 641);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailAddressText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListbox;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailAddressText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Button InsertButton;
    }
}

