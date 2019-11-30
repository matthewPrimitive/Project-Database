namespace _560GUI
{
    partial class loginForm
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
            this.finalLoginButton = new System.Windows.Forms.Button();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.createAccountLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // finalLoginButton
            // 
            this.finalLoginButton.Location = new System.Drawing.Point(134, 130);
            this.finalLoginButton.Name = "finalLoginButton";
            this.finalLoginButton.Size = new System.Drawing.Size(75, 23);
            this.finalLoginButton.TabIndex = 1;
            this.finalLoginButton.Text = "Login";
            this.finalLoginButton.UseVisualStyleBackColor = true;
            this.finalLoginButton.Click += new System.EventHandler(this.finalLoginButton_Click);
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(37, 61);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(253, 20);
            this.userTextBox.TabIndex = 2;
            // 
            // pwTextBox
            // 
            this.pwTextBox.Location = new System.Drawing.Point(37, 104);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(253, 20);
            this.pwTextBox.TabIndex = 3;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(34, 45);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Username";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(37, 88);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(53, 13);
            this.pwLabel.TabIndex = 5;
            this.pwLabel.Text = "Password";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(32, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(288, 26);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Returning User? Login Here!";
            // 
            // createAccountLink
            // 
            this.createAccountLink.AutoSize = true;
            this.createAccountLink.Location = new System.Drawing.Point(116, 188);
            this.createAccountLink.Name = "createAccountLink";
            this.createAccountLink.Size = new System.Drawing.Size(103, 13);
            this.createAccountLink.TabIndex = 7;
            this.createAccountLink.TabStop = true;
            this.createAccountLink.Text = "Create new account";
            this.createAccountLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccountLink_LinkClicked);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 230);
            this.Controls.Add(this.createAccountLink);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.pwTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.finalLoginButton);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button finalLoginButton;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.LinkLabel createAccountLink;
    }
}