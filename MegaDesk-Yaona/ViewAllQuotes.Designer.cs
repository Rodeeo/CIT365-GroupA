
namespace MegaDesk_Yaona
{
    partial class ViewAllQuotes
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.viewQuotesGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewQuoteCustomerNameLabel = new System.Windows.Forms.Label();
            this.viewQuoteCostLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.viewQuoteSpecsLabel = new System.Windows.Forms.Label();
            this.viewQuoteMaterialLabel = new System.Windows.Forms.Label();
            this.viewQuoteRushDaysLabel = new System.Windows.Forms.Label();
            this.viewQuoteDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "<< Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // viewQuotesGrid
            // 
            this.viewQuotesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewQuotesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewQuotesGrid.Location = new System.Drawing.Point(12, 90);
            this.viewQuotesGrid.Name = "viewQuotesGrid";
            this.viewQuotesGrid.RowTemplate.Height = 25;
            this.viewQuotesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewQuotesGrid.Size = new System.Drawing.Size(540, 132);
            this.viewQuotesGrid.TabIndex = 1;
            this.viewQuotesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.viewQuotesGrid.SelectionChanged += new System.EventHandler(this.viewQuotesGrid_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Saved Quotes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quote Details:";
            // 
            // viewQuoteCustomerNameLabel
            // 
            this.viewQuoteCustomerNameLabel.AutoSize = true;
            this.viewQuoteCustomerNameLabel.Location = new System.Drawing.Point(12, 270);
            this.viewQuoteCustomerNameLabel.Name = "viewQuoteCustomerNameLabel";
            this.viewQuoteCustomerNameLabel.Size = new System.Drawing.Size(38, 15);
            this.viewQuoteCustomerNameLabel.TabIndex = 4;
            this.viewQuoteCustomerNameLabel.Text = "label3";
            // 
            // viewQuoteCostLabel
            // 
            this.viewQuoteCostLabel.AutoSize = true;
            this.viewQuoteCostLabel.Location = new System.Drawing.Point(13, 292);
            this.viewQuoteCostLabel.Name = "viewQuoteCostLabel";
            this.viewQuoteCostLabel.Size = new System.Drawing.Size(38, 15);
            this.viewQuoteCostLabel.TabIndex = 5;
            this.viewQuoteCostLabel.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(241, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Desk Details:";
            // 
            // viewQuoteSpecsLabel
            // 
            this.viewQuoteSpecsLabel.AutoSize = true;
            this.viewQuoteSpecsLabel.Location = new System.Drawing.Point(241, 270);
            this.viewQuoteSpecsLabel.Name = "viewQuoteSpecsLabel";
            this.viewQuoteSpecsLabel.Size = new System.Drawing.Size(38, 15);
            this.viewQuoteSpecsLabel.TabIndex = 7;
            this.viewQuoteSpecsLabel.Text = "label6";
            // 
            // viewQuoteMaterialLabel
            // 
            this.viewQuoteMaterialLabel.AutoSize = true;
            this.viewQuoteMaterialLabel.Location = new System.Drawing.Point(241, 292);
            this.viewQuoteMaterialLabel.Name = "viewQuoteMaterialLabel";
            this.viewQuoteMaterialLabel.Size = new System.Drawing.Size(38, 15);
            this.viewQuoteMaterialLabel.TabIndex = 8;
            this.viewQuoteMaterialLabel.Text = "label7";
            // 
            // viewQuoteRushDaysLabel
            // 
            this.viewQuoteRushDaysLabel.AutoSize = true;
            this.viewQuoteRushDaysLabel.Location = new System.Drawing.Point(241, 312);
            this.viewQuoteRushDaysLabel.Name = "viewQuoteRushDaysLabel";
            this.viewQuoteRushDaysLabel.Size = new System.Drawing.Size(38, 15);
            this.viewQuoteRushDaysLabel.TabIndex = 9;
            this.viewQuoteRushDaysLabel.Text = "label3";
            // 
            // viewQuoteDateLabel
            // 
            this.viewQuoteDateLabel.AutoSize = true;
            this.viewQuoteDateLabel.Location = new System.Drawing.Point(13, 312);
            this.viewQuoteDateLabel.Name = "viewQuoteDateLabel";
            this.viewQuoteDateLabel.Size = new System.Drawing.Size(38, 15);
            this.viewQuoteDateLabel.TabIndex = 10;
            this.viewQuoteDateLabel.Text = "label3";
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.viewQuoteDateLabel);
            this.Controls.Add(this.viewQuoteRushDaysLabel);
            this.Controls.Add(this.viewQuoteMaterialLabel);
            this.Controls.Add(this.viewQuoteSpecsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.viewQuoteCostLabel);
            this.Controls.Add(this.viewQuoteCustomerNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewQuotesGrid);
            this.Controls.Add(this.BackBtn);
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewQuotesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView viewQuotesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label viewQuoteCustomerNameLabel;
        private System.Windows.Forms.Label viewQuoteCostLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label viewQuoteSpecsLabel;
        private System.Windows.Forms.Label viewQuoteMaterialLabel;
        private System.Windows.Forms.Label viewQuoteRushDaysLabel;
        private System.Windows.Forms.Label viewQuoteDateLabel;
    }
}