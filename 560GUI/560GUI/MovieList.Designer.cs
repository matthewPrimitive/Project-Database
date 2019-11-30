namespace _560GUI
{
    partial class MovieList
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.mlSignedinLabel = new System.Windows.Forms.Label();
            this.castButton = new System.Windows.Forms.Button();
            this.reviewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(32, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 253);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mlSignedinLabel
            // 
            this.mlSignedinLabel.AutoSize = true;
            this.mlSignedinLabel.Location = new System.Drawing.Point(228, 9);
            this.mlSignedinLabel.Name = "mlSignedinLabel";
            this.mlSignedinLabel.Size = new System.Drawing.Size(72, 13);
            this.mlSignedinLabel.TabIndex = 1;
            this.mlSignedinLabel.Text = "Not Signed In";
            // 
            // castButton
            // 
            this.castButton.Location = new System.Drawing.Point(285, 59);
            this.castButton.Name = "castButton";
            this.castButton.Size = new System.Drawing.Size(75, 40);
            this.castButton.TabIndex = 2;
            this.castButton.Text = "Search Cast";
            this.castButton.UseVisualStyleBackColor = true;
            // 
            // reviewButton
            // 
            this.reviewButton.Location = new System.Drawing.Point(285, 105);
            this.reviewButton.Name = "reviewButton";
            this.reviewButton.Size = new System.Drawing.Size(75, 39);
            this.reviewButton.TabIndex = 3;
            this.reviewButton.Text = "Reviews";
            this.reviewButton.UseVisualStyleBackColor = true;
            this.reviewButton.Click += new System.EventHandler(this.reviewButton_Click);
            // 
            // MovieList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 342);
            this.Controls.Add(this.reviewButton);
            this.Controls.Add(this.castButton);
            this.Controls.Add(this.mlSignedinLabel);
            this.Controls.Add(this.listView1);
            this.Name = "MovieList";
            this.Text = "Move List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label mlSignedinLabel;
        private System.Windows.Forms.Button castButton;
        private System.Windows.Forms.Button reviewButton;
    }
}