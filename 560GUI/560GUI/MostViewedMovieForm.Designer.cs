namespace _560GUI
{
    partial class MostViewedMovieForm
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
            this.uxSearch = new System.Windows.Forms.Button();
            this.uxEndLabel = new System.Windows.Forms.Label();
            this.uxEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxStartLabel = new System.Windows.Forms.Label();
            this.uxStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uxMostViewed = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfViewers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uxSearch
            // 
            this.uxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSearch.Location = new System.Drawing.Point(120, 82);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(88, 23);
            this.uxSearch.TabIndex = 10;
            this.uxSearch.Text = "Get Movies";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // uxEndLabel
            // 
            this.uxEndLabel.AutoSize = true;
            this.uxEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEndLabel.Location = new System.Drawing.Point(20, 51);
            this.uxEndLabel.Name = "uxEndLabel";
            this.uxEndLabel.Size = new System.Drawing.Size(67, 16);
            this.uxEndLabel.TabIndex = 9;
            this.uxEndLabel.Text = "End Date:";
            // 
            // uxEndDatePicker
            // 
            this.uxEndDatePicker.Location = new System.Drawing.Point(120, 47);
            this.uxEndDatePicker.Name = "uxEndDatePicker";
            this.uxEndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.uxEndDatePicker.TabIndex = 8;
            // 
            // uxStartLabel
            // 
            this.uxStartLabel.AutoSize = true;
            this.uxStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStartLabel.Location = new System.Drawing.Point(20, 14);
            this.uxStartLabel.Name = "uxStartLabel";
            this.uxStartLabel.Size = new System.Drawing.Size(70, 16);
            this.uxStartLabel.TabIndex = 7;
            this.uxStartLabel.Text = "Start Date:";
            // 
            // uxStartDatePicker
            // 
            this.uxStartDatePicker.Location = new System.Drawing.Point(120, 10);
            this.uxStartDatePicker.Name = "uxStartDatePicker";
            this.uxStartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.uxStartDatePicker.TabIndex = 6;
            // 
            // uxMostViewed
            // 
            this.uxMostViewed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.NumberOfViewers});
            this.uxMostViewed.GridLines = true;
            this.uxMostViewed.Location = new System.Drawing.Point(20, 131);
            this.uxMostViewed.Name = "uxMostViewed";
            this.uxMostViewed.Size = new System.Drawing.Size(300, 208);
            this.uxMostViewed.TabIndex = 11;
            this.uxMostViewed.UseCompatibleStateImageBehavior = false;
            this.uxMostViewed.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 150;
            // 
            // NumberOfViewers
            // 
            this.NumberOfViewers.Text = "Number of Viewers";
            this.NumberOfViewers.Width = 150;
            // 
            // MostViewedMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 351);
            this.Controls.Add(this.uxMostViewed);
            this.Controls.Add(this.uxSearch);
            this.Controls.Add(this.uxEndLabel);
            this.Controls.Add(this.uxEndDatePicker);
            this.Controls.Add(this.uxStartLabel);
            this.Controls.Add(this.uxStartDatePicker);
            this.Name = "MostViewedMovieForm";
            this.Text = "MostViewedMovieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSearch;
        private System.Windows.Forms.Label uxEndLabel;
        private System.Windows.Forms.DateTimePicker uxEndDatePicker;
        private System.Windows.Forms.Label uxStartLabel;
        private System.Windows.Forms.DateTimePicker uxStartDatePicker;
        private System.Windows.Forms.ListView uxMostViewed;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader NumberOfViewers;
    }
}