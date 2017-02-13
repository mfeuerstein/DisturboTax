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
    public partial class Form3 : Form
    {
        List<TaxInfo> infoList;
        int count;

        public Form3(List<TaxInfo> list, int num)
        {
            infoList = list;
            count = num;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void setTextFields()
        {
            for(int i = 0; i < count; i++)
            {
                txtSSList.Text += infoList[i].socSecNum + Environment.NewLine;
                txtLastList.Text += infoList[i].lastName + Environment.NewLine;
                txtFirstList.Text += infoList[i].firstName + Environment.NewLine;
                txtAmountList.Text += infoList[i].taxOwed_Gained + Environment.NewLine;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
