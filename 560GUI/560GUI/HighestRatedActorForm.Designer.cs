namespace _560GUI
{
    partial class HighestRatedActorForm
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
            this.uxActorList = new System.Windows.Forms.ListView();
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // uxActorList
            // 
            this.uxActorList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Rating});
            this.uxActorList.GridLines = true;
            this.uxActorList.Location = new System.Drawing.Point(13, 35);
            this.uxActorList.Name = "uxActorList";
            this.uxActorList.Size = new System.Drawing.Size(300, 238);
            this.uxActorList.TabIndex = 0;
            this.uxActorList.UseCompatibleStateImageBehavior = false;
            this.uxActorList.View = System.Windows.Forms.View.Details;
            // 
            // Rating
            // 
            this.Rating.Text = "Overall Rating";
            this.Rating.Width = 150;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 150;
            // 
            // HighestRatedActorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 285);
            this.Controls.Add(this.uxActorList);
            this.Name = "HighestRatedActorForm";
            this.Text = "HighestRatedActorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView uxActorList;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Rating;
    }
}