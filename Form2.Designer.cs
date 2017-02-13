namespace DisturboTax
{
    partial class Form2
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
            this.txtTaxBalance = new System.Windows.Forms.TextBox();
            this.labelTaxBalance = new System.Windows.Forms.Label();
            this.txtPenalty = new System.Windows.Forms.TextBox();
            this.txtAmountOfTaxWithheld = new System.Windows.Forms.TextBox();
            this.txtAmountOfTaxCalc = new System.Windows.Forms.TextBox();
            this.txtAdjustedGross = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTaxBalance
            // 
            this.txtTaxBalance.Location = new System.Drawing.Point(228, 139);
            this.txtTaxBalance.Name = "txtTaxBalance";
            this.txtTaxBalance.ReadOnly = true;
            this.txtTaxBalance.Size = new System.Drawing.Size(84, 20);
            this.txtTaxBalance.TabIndex = 32;
            this.txtTaxBalance.TabStop = false;
            this.txtTaxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTaxBalance
            // 
            this.labelTaxBalance.Location = new System.Drawing.Point(23, 137);
            this.labelTaxBalance.Name = "labelTaxBalance";
            this.labelTaxBalance.Size = new System.Drawing.Size(187, 20);
            this.labelTaxBalance.TabIndex = 31;
            this.labelTaxBalance.Text = "Tax Owed to the Federal Government:";
            this.labelTaxBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPenalty
            // 
            this.txtPenalty.Location = new System.Drawing.Point(228, 110);
            this.txtPenalty.Name = "txtPenalty";
            this.txtPenalty.ReadOnly = true;
            this.txtPenalty.Size = new System.Drawing.Size(84, 20);
            this.txtPenalty.TabIndex = 30;
            this.txtPenalty.TabStop = false;
            this.txtPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmountOfTaxWithheld
            // 
            this.txtAmountOfTaxWithheld.Location = new System.Drawing.Point(228, 81);
            this.txtAmountOfTaxWithheld.Name = "txtAmountOfTaxWithheld";
            this.txtAmountOfTaxWithheld.ReadOnly = true;
            this.txtAmountOfTaxWithheld.Size = new System.Drawing.Size(84, 20);
            this.txtAmountOfTaxWithheld.TabIndex = 29;
            this.txtAmountOfTaxWithheld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmountOfTaxCalc
            // 
            this.txtAmountOfTaxCalc.Location = new System.Drawing.Point(228, 51);
            this.txtAmountOfTaxCalc.Name = "txtAmountOfTaxCalc";
            this.txtAmountOfTaxCalc.ReadOnly = true;
            this.txtAmountOfTaxCalc.Size = new System.Drawing.Size(84, 20);
            this.txtAmountOfTaxCalc.TabIndex = 28;
            this.txtAmountOfTaxCalc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAdjustedGross
            // 
            this.txtAdjustedGross.Location = new System.Drawing.Point(228, 22);
            this.txtAdjustedGross.Name = "txtAdjustedGross";
            this.txtAdjustedGross.ReadOnly = true;
            this.txtAdjustedGross.Size = new System.Drawing.Size(84, 20);
            this.txtAdjustedGross.TabIndex = 27;
            this.txtAdjustedGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Penalty:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Amount of Tax Withheld from W-2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount of Tax(Calculated):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Adjusted Gross:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNext.Location = new System.Drawing.Point(258, 176);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 34;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnPrev.Location = new System.Drawing.Point(171, 176);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 33;
            this.btnPrev.Text = "&Previous";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(345, 215);
            this.ControlBox = false;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtTaxBalance);
            this.Controls.Add(this.labelTaxBalance);
            this.Controls.Add(this.txtPenalty);
            this.Controls.Add(this.txtAmountOfTaxWithheld);
            this.Controls.Add(this.txtAmountOfTaxCalc);
            this.Controls.Add(this.txtAdjustedGross);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaxBalance;
        private System.Windows.Forms.Label labelTaxBalance;
        private System.Windows.Forms.TextBox txtPenalty;
        private System.Windows.Forms.TextBox txtAmountOfTaxWithheld;
        private System.Windows.Forms.TextBox txtAmountOfTaxCalc;
        private System.Windows.Forms.TextBox txtAdjustedGross;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
    }
}