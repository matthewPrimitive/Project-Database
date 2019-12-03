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
            this.showtimeDropbox = new System.Windows.Forms.ComboBox();
            this.showtimeSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highestRatedActorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestReviewedMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highestRatedMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginButton = new System.Windows.Forms.Button();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.showtimeListBox = new System.Windows.Forms.ListBox();
            this.movieListbox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showtimeDropbox
            // 
            this.showtimeDropbox.FormattingEnabled = true;
            this.showtimeDropbox.Location = new System.Drawing.Point(511, 121);
            this.showtimeDropbox.Name = "showtimeDropbox";
            this.showtimeDropbox.Size = new System.Drawing.Size(191, 21);
            this.showtimeDropbox.TabIndex = 3;
            // 
            // showtimeSearch
            // 
            this.showtimeSearch.Location = new System.Drawing.Point(573, 148);
            this.showtimeSearch.Name = "showtimeSearch";
            this.showtimeSearch.Size = new System.Drawing.Size(129, 23);
            this.showtimeSearch.TabIndex = 4;
            this.showtimeSearch.Text = "Search";
            this.showtimeSearch.UseVisualStyleBackColor = true;
            this.showtimeSearch.Click += new System.EventHandler(this.showtimeSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieDatabaseToolStripMenuItem,
            this.bestTimesToolStripMenuItem,
            this.highestRatedActorsToolStripMenuItem,
            this.bestReviewedMoviesToolStripMenuItem,
            this.highestRatedMoviesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // movieDatabaseToolStripMenuItem
            // 
            this.movieDatabaseToolStripMenuItem.Name = "movieDatabaseToolStripMenuItem";
            this.movieDatabaseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.movieDatabaseToolStripMenuItem.Text = "Movie Database";
            this.movieDatabaseToolStripMenuItem.Click += new System.EventHandler(this.movieDatabaseToolStripMenuItem_Click);
            // 
            // bestTimesToolStripMenuItem
            // 
            this.bestTimesToolStripMenuItem.Name = "bestTimesToolStripMenuItem";
            this.bestTimesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.bestTimesToolStripMenuItem.Text = "Best Times";
            this.bestTimesToolStripMenuItem.Click += new System.EventHandler(this.bestTimesToolStripMenuItem_Click);
            // 
            // highestRatedActorsToolStripMenuItem
            // 
            this.highestRatedActorsToolStripMenuItem.Name = "highestRatedActorsToolStripMenuItem";
            this.highestRatedActorsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.highestRatedActorsToolStripMenuItem.Text = "Highest Rated Actors";
            this.highestRatedActorsToolStripMenuItem.Click += new System.EventHandler(this.highestRatedActorsToolStripMenuItem_Click);
            // 
            // bestReviewedMoviesToolStripMenuItem
            // 
            this.bestReviewedMoviesToolStripMenuItem.Name = "bestReviewedMoviesToolStripMenuItem";
            this.bestReviewedMoviesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.bestReviewedMoviesToolStripMenuItem.Text = "Most Viewed Movies";
            this.bestReviewedMoviesToolStripMenuItem.Click += new System.EventHandler(this.bestReviewedMoviesToolStripMenuItem_Click);
            // 
            // highestRatedMoviesToolStripMenuItem
            // 
            this.highestRatedMoviesToolStripMenuItem.Name = "highestRatedMoviesToolStripMenuItem";
            this.highestRatedMoviesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.highestRatedMoviesToolStripMenuItem.Text = "Highest Rated Movies";
            this.highestRatedMoviesToolStripMenuItem.Click += new System.EventHandler(this.highestRatedMoviesToolStripMenuItem_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(598, 16);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(104, 38);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = " login/create account";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentUserLabel.Location = new System.Drawing.Point(486, 24);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(106, 20);
            this.currentUserLabel.TabIndex = 7;
            this.currentUserLabel.Text = "Not Signed In";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Showings";
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(312, 361);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(193, 48);
            this.buyButton.TabIndex = 9;
            this.buyButton.Text = "Buy Ticket";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // showtimeListBox
            // 
            this.showtimeListBox.FormattingEnabled = true;
            this.showtimeListBox.Location = new System.Drawing.Point(464, 195);
            this.showtimeListBox.Name = "showtimeListBox";
            this.showtimeListBox.Size = new System.Drawing.Size(290, 160);
            this.showtimeListBox.TabIndex = 11;
            // 
            // movieListbox
            // 
            this.movieListbox.FormattingEnabled = true;
            this.movieListbox.Location = new System.Drawing.Point(35, 195);
            this.movieListbox.Name = "movieListbox";
            this.movieListbox.Size = new System.Drawing.Size(414, 160);
            this.movieListbox.TabIndex = 12;
            this.movieListbox.SelectedIndexChanged += new System.EventHandler(this.movieListbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movieListbox);
            this.Controls.Add(this.showtimeListBox);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.showtimeSearch);
            this.Controls.Add(this.showtimeDropbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox showtimeDropbox;
        private System.Windows.Forms.Button showtimeSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.ListBox showtimeListBox;
        private System.Windows.Forms.ListBox movieListbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ToolStripMenuItem bestTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highestRatedActorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestReviewedMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highestRatedMoviesToolStripMenuItem;
    }
}

