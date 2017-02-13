namespace DisturboTax
{
    partial class Form3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSSList = new System.Windows.Forms.TextBox();
            this.txtFirstList = new System.Windows.Forms.TextBox();
            this.txtLastList = new System.Windows.Forms.TextBox();
            this.txtAmountList = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(468, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tax Owed";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "First Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "SS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSSList
            // 
            this.txtSSList.CausesValidation = false;
            this.txtSSList.Enabled = false;
            this.txtSSList.Location = new System.Drawing.Point(55, 75);
            this.txtSSList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtSSList.Multiline = true;
            this.txtSSList.Name = "txtSSList";
            this.txtSSList.ReadOnly = true;
            this.txtSSList.Size = new System.Drawing.Size(66, 246);
            this.txtSSList.TabIndex = 37;
            this.txtSSList.TabStop = false;
            // 
            // txtFirstList
            // 
            this.txtFirstList.Enabled = false;
            this.txtFirstList.Location = new System.Drawing.Point(186, 75);
            this.txtFirstList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtFirstList.Multiline = true;
            this.txtFirstList.Name = "txtFirstList";
            this.txtFirstList.ReadOnly = true;
            this.txtFirstList.Size = new System.Drawing.Size(66, 246);
            this.txtFirstList.TabIndex = 38;
            this.txtFirstList.TabStop = false;
            // 
            // txtLastList
            // 
            this.txtLastList.Enabled = false;
            this.txtLastList.Location = new System.Drawing.Point(328, 75);
            this.txtLastList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtLastList.Multiline = true;
            this.txtLastList.Name = "txtLastList";
            this.txtLastList.ReadOnly = true;
            this.txtLastList.Size = new System.Drawing.Size(66, 246);
            this.txtLastList.TabIndex = 39;
            this.txtLastList.TabStop = false;
            // 
            // txtAmountList
            // 
            this.txtAmountList.Enabled = false;
            this.txtAmountList.Location = new System.Drawing.Point(464, 75);
            this.txtAmountList.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtAmountList.Multiline = true;
            this.txtAmountList.Name = "txtAmountList";
            this.txtAmountList.ReadOnly = true;
            this.txtAmountList.Size = new System.Drawing.Size(66, 246);
            this.txtAmountList.TabIndex = 40;
            this.txtAmountList.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonExit.Location = new System.Drawing.Point(258, 355);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 41;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(607, 400);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.txtAmountList);
            this.Controls.Add(this.txtLastList);
            this.Controls.Add(this.txtFirstList);
            this.Controls.Add(this.txtSSList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSSList;
        private System.Windows.Forms.TextBox txtFirstList;
        private System.Windows.Forms.TextBox txtLastList;
        private System.Windows.Forms.TextBox txtAmountList;
        private System.Windows.Forms.Button buttonExit;
    }
}