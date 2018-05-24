namespace HereWeGo
{
    partial class Insert
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
            this.Title = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Store = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(170, 59);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(216, 22);
            this.Title.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(170, 103);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(216, 22);
            this.Price.TabIndex = 2;
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(170, 148);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(216, 22);
            this.Duration.TabIndex = 3;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(170, 191);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(216, 22);
            this.Quantity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Categories
            // 
            this.Categories.Location = new System.Drawing.Point(170, 241);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(216, 22);
            this.Categories.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Categories";
            // 
            // Store
            // 
            this.Store.Location = new System.Drawing.Point(170, 13);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(216, 22);
            this.Store.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Store";
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Store);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Title);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Categories;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Store;
        private System.Windows.Forms.Label label1;
    }
}