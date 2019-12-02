namespace _560GUI
{
    partial class HighestRatedMovieForm
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
            this.uxHighestRatedMovie = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxStartLabel = new System.Windows.Forms.Label();
            this.uxEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxEndLabel = new System.Windows.Forms.Label();
            this.uxSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxHighestRatedMovie
            // 
            this.uxHighestRatedMovie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Rating});
            this.uxHighestRatedMovie.GridLines = true;
            this.uxHighestRatedMovie.Location = new System.Drawing.Point(12, 127);
            this.uxHighestRatedMovie.Name = "uxHighestRatedMovie";
            this.uxHighestRatedMovie.Size = new System.Drawing.Size(300, 238);
            this.uxHighestRatedMovie.TabIndex = 0;
            this.uxHighestRatedMovie.UseCompatibleStateImageBehavior = false;
            this.uxHighestRatedMovie.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 150;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            this.Rating.Width = 150;
            // 
            // uxStartDatePicker
            // 
            this.uxStartDatePicker.Location = new System.Drawing.Point(112, 12);
            this.uxStartDatePicker.Name = "uxStartDatePicker";
            this.uxStartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.uxStartDatePicker.TabIndex = 1;
            // 
            // uxStartLabel
            // 
            this.uxStartLabel.AutoSize = true;
            this.uxStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartLabel.Location = new System.Drawing.Point(12, 16);
            this.uxStartLabel.Name = "uxStartLabel";
            this.uxStartLabel.Size = new System.Drawing.Size(70, 16);
            this.uxStartLabel.TabIndex = 2;
            this.uxStartLabel.Text = "Start Date:";
            // 
            // uxEndDatePicker
            // 
            this.uxEndDatePicker.Location = new System.Drawing.Point(112, 49);
            this.uxEndDatePicker.Name = "uxEndDatePicker";
            this.uxEndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.uxEndDatePicker.TabIndex = 3;
            // 
            // uxEndLabel
            // 
            this.uxEndLabel.AutoSize = true;
            this.uxEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndLabel.Location = new System.Drawing.Point(12, 53);
            this.uxEndLabel.Name = "uxEndLabel";
            this.uxEndLabel.Size = new System.Drawing.Size(67, 16);
            this.uxEndLabel.TabIndex = 4;
            this.uxEndLabel.Text = "End Date:";
            // 
            // uxSearch
            // 
            this.uxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearch.Location = new System.Drawing.Point(112, 84);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(88, 23);
            this.uxSearch.TabIndex = 5;
            this.uxSearch.Text = "Get Movies";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // HighestRatedMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 380);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.uxEndLabel);
            this.Controls.Add(this.uxEndDatePicker);
            this.Controls.Add(this.uxStartLabel);
            this.Controls.Add(this.uxStartDatePicker);
            this.Controls.Add(this.uxHighestRatedMovie);
            this.Name = "HighestRatedMovieForm";
            this.Text = "Highest Rated Movies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView uxHighestRatedMovie;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.DateTimePicker uxStartDatePicker;
        private System.Windows.Forms.Label uxStartLabel;
        private System.Windows.Forms.DateTimePicker uxEndDatePicker;
        private System.Windows.Forms.Label uxEndLabel;
        private System.Windows.Forms.Button uxSearch;
    }
}