
namespace _2019Example
{
    partial class LogInForm
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
            this.userIDLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userIDTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.registerHereLabel = new System.Windows.Forms.LinkLabel();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userIDLabel
            // 
            this.userIDLabel.AutoSize = true;
            this.userIDLabel.Location = new System.Drawing.Point(89, 94);
            this.userIDLabel.Name = "userIDLabel";
            this.userIDLabel.Size = new System.Drawing.Size(56, 20);
            this.userIDLabel.TabIndex = 0;
            this.userIDLabel.Text = "UserID:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(89, 171);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(73, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // userIDTextBox
            // 
            this.userIDTextBox.Location = new System.Drawing.Point(197, 94);
            this.userIDTextBox.Name = "userIDTextBox";
            this.userIDTextBox.Size = new System.Drawing.Size(125, 27);
            this.userIDTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(197, 168);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(125, 27);
            this.passwordTextBox.TabIndex = 3;
            // 
            // registerHereLabel
            // 
            this.registerHereLabel.AutoSize = true;
            this.registerHereLabel.Location = new System.Drawing.Point(103, 303);
            this.registerHereLabel.Name = "registerHereLabel";
            this.registerHereLabel.Size = new System.Drawing.Size(99, 20);
            this.registerHereLabel.TabIndex = 4;
            this.registerHereLabel.TabStop = true;
            this.registerHereLabel.Text = "Register Here";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(197, 232);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(94, 29);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.registerHereLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userIDTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userIDLabel);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userIDLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userIDTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.LinkLabel registerHereLabel;
        private System.Windows.Forms.Button enterButton;
    }
}