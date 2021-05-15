
namespace MegaDesk_Yaona
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label drawersLabel;
            this.BackBtn = new System.Windows.Forms.Button();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthTextbox = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.surfaceMaterialTextbox = new System.Windows.Forms.TextBox();
            this.surfaceMaterialLabel = new System.Windows.Forms.Label();
            this.rushCheckbox = new System.Windows.Forms.CheckBox();
            this.rushOrderDaysTextbox = new System.Windows.Forms.TextBox();
            this.drawersNumberInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.addQuoteBtn = new System.Windows.Forms.Button();
            drawersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawersNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawersLabel
            // 
            drawersLabel.AutoSize = true;
            drawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            drawersLabel.Location = new System.Drawing.Point(114, 185);
            drawersLabel.Name = "drawersLabel";
            drawersLabel.Size = new System.Drawing.Size(80, 20);
            drawersLabel.TabIndex = 8;
            drawersLabel.Text = "Drawers : ";
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
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerNameLabel.Location = new System.Drawing.Point(114, 68);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(86, 20);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer :";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Location = new System.Drawing.Point(202, 65);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(225, 23);
            this.customerNameTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(190, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add New Quote";
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(202, 104);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(225, 23);
            this.widthTextbox.TabIndex = 5;
            this.widthTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.widthTextbox_Validating);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.widthLabel.Location = new System.Drawing.Point(114, 107);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(58, 20);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width :";
            // 
            // depthTextbox
            // 
            this.depthTextbox.Location = new System.Drawing.Point(202, 146);
            this.depthTextbox.Name = "depthTextbox";
            this.depthTextbox.Size = new System.Drawing.Size(225, 23);
            this.depthTextbox.TabIndex = 7;
            this.depthTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthTextbox_KeyPress);
            this.depthTextbox.Validating += new System.ComponentModel.CancelEventHandler(this.depthTextbox_Validating);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depthLabel.Location = new System.Drawing.Point(114, 149);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(61, 20);
            this.depthLabel.TabIndex = 6;
            this.depthLabel.Text = "Depth :";
            // 
            // surfaceMaterialTextbox
            // 
            this.surfaceMaterialTextbox.Location = new System.Drawing.Point(202, 223);
            this.surfaceMaterialTextbox.Name = "surfaceMaterialTextbox";
            this.surfaceMaterialTextbox.Size = new System.Drawing.Size(225, 23);
            this.surfaceMaterialTextbox.TabIndex = 11;
            // 
            // surfaceMaterialLabel
            // 
            this.surfaceMaterialLabel.AutoSize = true;
            this.surfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surfaceMaterialLabel.Location = new System.Drawing.Point(114, 223);
            this.surfaceMaterialLabel.Name = "surfaceMaterialLabel";
            this.surfaceMaterialLabel.Size = new System.Drawing.Size(73, 20);
            this.surfaceMaterialLabel.TabIndex = 10;
            this.surfaceMaterialLabel.Text = "Material :";
            // 
            // rushCheckbox
            // 
            this.rushCheckbox.AutoSize = true;
            this.rushCheckbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rushCheckbox.Location = new System.Drawing.Point(202, 264);
            this.rushCheckbox.Name = "rushCheckbox";
            this.rushCheckbox.Size = new System.Drawing.Size(109, 25);
            this.rushCheckbox.TabIndex = 12;
            this.rushCheckbox.Text = "Rush Order";
            this.rushCheckbox.UseVisualStyleBackColor = true;
            // 
            // rushOrderDaysTextbox
            // 
            this.rushOrderDaysTextbox.Location = new System.Drawing.Point(380, 264);
            this.rushOrderDaysTextbox.Name = "rushOrderDaysTextbox";
            this.rushOrderDaysTextbox.Size = new System.Drawing.Size(47, 23);
            this.rushOrderDaysTextbox.TabIndex = 13;
            // 
            // drawersNumberInput
            // 
            this.drawersNumberInput.Location = new System.Drawing.Point(202, 182);
            this.drawersNumberInput.Name = "drawersNumberInput";
            this.drawersNumberInput.Size = new System.Drawing.Size(225, 23);
            this.drawersNumberInput.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(327, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Days:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.addQuoteBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuoteBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.addQuoteBtn.Location = new System.Drawing.Point(296, 310);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(131, 47);
            this.addQuoteBtn.TabIndex = 16;
            this.addQuoteBtn.Text = "Add Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = false;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 381);
            this.Controls.Add(this.addQuoteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawersNumberInput);
            this.Controls.Add(this.rushOrderDaysTextbox);
            this.Controls.Add(this.rushCheckbox);
            this.Controls.Add(this.surfaceMaterialTextbox);
            this.Controls.Add(this.surfaceMaterialLabel);
            this.Controls.Add(drawersLabel);
            this.Controls.Add(this.depthTextbox);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthTextbox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.BackBtn);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.drawersNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox depthTextbox;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox surfaceMaterialTextbox;
        private System.Windows.Forms.Label surfaceMaterialLabel;
        private System.Windows.Forms.CheckBox rushCheckbox;
        private System.Windows.Forms.TextBox rushOrderDaysTextbox;
        private System.Windows.Forms.NumericUpDown drawersNumberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button addQuoteBtn;
    }
}