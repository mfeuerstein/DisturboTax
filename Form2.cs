using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisturboTax
{
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void setForm1(Form1 form)
        {
            form1 = form;
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {
            form1.Visible = true;
            form1.Focus();
            this.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //form1.iL[form1.count].socSecNum = form1.ssNum;
            form1.iL.Insert(form1.count, form1.info);
            form1.count++;
            if (form1.count == 10)
            {
                form1.iL.Sort((l, r) => l.socSecNum.CompareTo(r.socSecNum));
                Form3 form3 = new Form3(form1.iL, form1.count);
                form3.setTextFields();
                form3.Visible = true;
                form3.Focus();
                this.Visible = false;
            }
            else
            {
                form1.clearText();
                form1.Visible = true;
                form1.Focus();
                this.Visible = false;
            }
        }

        public void setDataFields(TaxInfo info)
        {
            txtAdjustedGross.Text = info.adjustedGross + "";
            txtAmountOfTaxCalc.Text = info.calculatedTax + "";
            txtAmountOfTaxWithheld.Text = info.fedTaxWithheld + "";
            txtPenalty.Text = info.penalty + "";
            txtTaxBalance.Text = info.taxOwed_Gained + "";
        }
    }
}
