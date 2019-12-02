namespace _560GUI
{
    partial class BestTimeForm
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
            this.uxBestTime = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayOfTheWeek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfViewers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uxBestTime
            // 
            this.uxBestTime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.DayOfTheWeek,
            this.NumberOfViewers});
            this.uxBestTime.GridLines = true;
            this.uxBestTime.Location = new System.Drawing.Point(36, 69);
            this.uxBestTime.Name = "uxBestTime";
            this.uxBestTime.Size = new System.Drawing.Size(498, 222);
            this.uxBestTime.TabIndex = 0;
            this.uxBestTime.UseCompatibleStateImageBehavior = false;
            this.uxBestTime.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 166;
            // 
            // DayOfTheWeek
            // 
            this.DayOfTheWeek.Text = "Day of the Week";
            this.DayOfTheWeek.Width = 166;
            // 
            // NumberOfViewers
            // 
            this.NumberOfViewers.Text = "Number of Viewers";
            this.NumberOfViewers.Width = 166;
            // 
            // BestTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 303);
            this.Controls.Add(this.uxBestTime);
            this.Name = "BestTimeForm";
            this.Text = "Best Time";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView uxBestTime;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader DayOfTheWeek;
        private System.Windows.Forms.ColumnHeader NumberOfViewers;
    }
}