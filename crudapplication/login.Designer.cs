namespace crudapplication
{
    partial class login
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
            this.loginnamr = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainlogin = new System.Windows.Forms.Button();
            this.loginpassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginnamr
            // 
            this.loginnamr.AutoSize = true;
            this.loginnamr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginnamr.Location = new System.Drawing.Point(63, 91);
            this.loginnamr.Name = "loginnamr";
            this.loginnamr.Size = new System.Drawing.Size(110, 32);
            this.loginnamr.TabIndex = 0;
            this.loginnamr.Text = "Name :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(246, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 39);
            this.textBox1.TabIndex = 1;
            // 
            // mainlogin
            // 
            this.mainlogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlogin.Location = new System.Drawing.Point(93, 324);
            this.mainlogin.Name = "mainlogin";
            this.mainlogin.Size = new System.Drawing.Size(109, 50);
            this.mainlogin.TabIndex = 2;
            this.mainlogin.Text = "Login";
            this.mainlogin.UseVisualStyleBackColor = false;
            this.mainlogin.Click += new System.EventHandler(this.mainlogin_Click);
            // 
            // loginpassword
            // 
            this.loginpassword.AutoSize = true;
            this.loginpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginpassword.Location = new System.Drawing.Point(63, 193);
            this.loginpassword.Name = "loginpassword";
            this.loginpassword.Size = new System.Drawing.Size(163, 32);
            this.loginpassword.TabIndex = 0;
            this.loginpassword.Text = "Password :";
            this.loginpassword.Click += new System.EventHandler(this.mainlogin_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(246, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 39);
            this.textBox2.TabIndex = 1;
            // 
            // Signup
            // 
            this.Signup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signup.Location = new System.Drawing.Point(282, 324);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(109, 50);
            this.Signup.TabIndex = 2;
            this.Signup.Text = "Signup";
            this.Signup.UseVisualStyleBackColor = false;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 476);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.mainlogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loginpassword);
            this.Controls.Add(this.loginnamr);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginnamr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mainlogin;
        private System.Windows.Forms.Label loginpassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Signup;
    }
}