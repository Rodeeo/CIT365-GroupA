
namespace MegaDesk_Yaona
{
    partial class SearchQuotes
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
            this.searchQuoteDataGridView = new System.Windows.Forms.DataGridView();
            this.searchMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchQuoteDataGridView)).BeginInit();
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
            // searchQuoteDataGridView
            // 
            this.searchQuoteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchQuoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchQuoteDataGridView.Location = new System.Drawing.Point(12, 113);
            this.searchQuoteDataGridView.Name = "searchQuoteDataGridView";
            this.searchQuoteDataGridView.RowTemplate.Height = 25;
            this.searchQuoteDataGridView.Size = new System.Drawing.Size(531, 150);
            this.searchQuoteDataGridView.TabIndex = 1;
            // 
            // searchMaterialComboBox
            // 
            this.searchMaterialComboBox.FormattingEnabled = true;
            this.searchMaterialComboBox.Location = new System.Drawing.Point(202, 55);
            this.searchMaterialComboBox.Name = "searchMaterialComboBox";
            this.searchMaterialComboBox.Size = new System.Drawing.Size(193, 23);
            this.searchMaterialComboBox.TabIndex = 2;
            this.searchMaterialComboBox.SelectedIndexChanged += new System.EventHandler(this.searchMaterialComboBox_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(13, 57);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(183, 21);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Filter By Surface Material";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchMaterialComboBox);
            this.Controls.Add(this.searchQuoteDataGridView);
            this.Controls.Add(this.BackBtn);
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchQuoteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView searchQuoteDataGridView;
        private System.Windows.Forms.ComboBox searchMaterialComboBox;
        private System.Windows.Forms.Label searchLabel;
    }
}