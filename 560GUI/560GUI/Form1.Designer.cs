namespace _560GUI
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dropList = new System.Windows.Forms.ComboBox();
            this.showtimeDropbox = new System.Windows.Forms.ComboBox();
            this.showtimeSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(36, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(735, 212);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(36, 348);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(117, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dropList
            // 
            this.dropList.FormattingEnabled = true;
            this.dropList.Location = new System.Drawing.Point(36, 321);
            this.dropList.Name = "dropList";
            this.dropList.Size = new System.Drawing.Size(208, 21);
            this.dropList.TabIndex = 2;
            this.dropList.SelectedIndexChanged += new System.EventHandler(this.dropList_SelectedIndexChanged);
            // 
            // showtimeDropbox
            // 
            this.showtimeDropbox.FormattingEnabled = true;
            this.showtimeDropbox.Location = new System.Drawing.Point(580, 321);
            this.showtimeDropbox.Name = "showtimeDropbox";
            this.showtimeDropbox.Size = new System.Drawing.Size(191, 21);
            this.showtimeDropbox.TabIndex = 3;
            // 
            // showtimeSearch
            // 
            this.showtimeSearch.Location = new System.Drawing.Point(641, 349);
            this.showtimeSearch.Name = "showtimeSearch";
            this.showtimeSearch.Size = new System.Drawing.Size(129, 23);
            this.showtimeSearch.TabIndex = 4;
            this.showtimeSearch.Text = "Search";
            this.showtimeSearch.UseVisualStyleBackColor = true;
            this.showtimeSearch.Click += new System.EventHandler(this.showtimeSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showtimeSearch);
            this.Controls.Add(this.showtimeDropbox);
            this.Controls.Add(this.dropList);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox dropList;
        private System.Windows.Forms.ComboBox showtimeDropbox;
        private System.Windows.Forms.Button showtimeSearch;
    }
}

