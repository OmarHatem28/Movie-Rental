namespace HereWeGo
{
    partial class CustomerSignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.TextBox();
            this.First_Name = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Last_Name = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // SSN
            // 
            this.SSN.Location = new System.Drawing.Point(240, 34);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(180, 22);
            this.SSN.TabIndex = 6;
            // 
            // First_Name
            // 
            this.First_Name.Location = new System.Drawing.Point(240, 77);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(180, 22);
            this.First_Name.TabIndex = 7;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(240, 175);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(180, 22);
            this.Phone.TabIndex = 8;
            // 
            // Last_Name
            // 
            this.Last_Name.Location = new System.Drawing.Point(240, 121);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(180, 22);
            this.Last_Name.TabIndex = 9;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(240, 222);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(180, 22);
            this.Address.TabIndex = 10;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(240, 270);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(180, 22);
            this.Pass.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sign Up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Last_Name);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSignUp";
            this.Text = "CustomerSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SSN;
        private System.Windows.Forms.TextBox First_Name;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Last_Name;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button button1;
    }
}