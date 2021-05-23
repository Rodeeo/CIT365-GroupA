
namespace MegaDesk_Yaona
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewQuoteBtn = new System.Windows.Forms.Button();
            this.ViewQuotesBtn = new System.Windows.Forms.Button();
            this.SearchQuotesBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewQuoteBtn
            // 
            this.AddNewQuoteBtn.Location = new System.Drawing.Point(40, 52);
            this.AddNewQuoteBtn.Name = "AddNewQuoteBtn";
            this.AddNewQuoteBtn.Size = new System.Drawing.Size(175, 50);
            this.AddNewQuoteBtn.TabIndex = 0;
            this.AddNewQuoteBtn.Text = "&Add New Quote";
            this.AddNewQuoteBtn.UseVisualStyleBackColor = true;
            this.AddNewQuoteBtn.Click += new System.EventHandler(this.AddNewQuoteBtn_Click);
            // 
            // ViewQuotesBtn
            // 
            this.ViewQuotesBtn.Location = new System.Drawing.Point(40, 119);
            this.ViewQuotesBtn.Name = "ViewQuotesBtn";
            this.ViewQuotesBtn.Size = new System.Drawing.Size(175, 50);
            this.ViewQuotesBtn.TabIndex = 1;
            this.ViewQuotesBtn.Text = "&View Quotes";
            this.ViewQuotesBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
            // 
            // SearchQuotesBtn
            // 
            this.SearchQuotesBtn.Location = new System.Drawing.Point(40, 184);
            this.SearchQuotesBtn.Name = "SearchQuotesBtn";
            this.SearchQuotesBtn.Size = new System.Drawing.Size(175, 50);
            this.SearchQuotesBtn.TabIndex = 2;
            this.SearchQuotesBtn.Text = "&Search Quotes";
            this.SearchQuotesBtn.UseVisualStyleBackColor = true;
            this.SearchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(40, 249);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(175, 50);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "&Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_Yaona.Properties.Resources.iconfinder_BeOS_Workspace_34771;
            this.pictureBox1.Location = new System.Drawing.Point(337, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 137);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(319, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "MegaDesk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(288, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome, Admin!";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchQuotesBtn);
            this.Controls.Add(this.ViewQuotesBtn);
            this.Controls.Add(this.AddNewQuoteBtn);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddNewQuoteBtn;
        private System.Windows.Forms.Button ViewQuotesBtn;
        private System.Windows.Forms.Button SearchQuotesBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

