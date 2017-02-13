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
    public partial class Form1 : Form
    {
        public int count = 0;

        public TaxInfo []infoList = new TaxInfo[10];
        public List<TaxInfo> iL = new List<TaxInfo> (10);
        public string ssNum;
        public TaxInfo info;
        Form2 form2;

        public Form1()
        {
            InitializeComponent();

            txtSocialSecurityNum.MaxLength = 9;
            txtZipCode.MaxLength = 5;

            comboBoxStates.Items.Add("AL");
            comboBoxStates.Items.Add("AK");
            comboBoxStates.Items.Add("AZ");
            comboBoxStates.Items.Add("AR");
            comboBoxStates.Items.Add("CA");
            comboBoxStates.Items.Add("CO");
            comboBoxStates.Items.Add("CT");
            comboBoxStates.Items.Add("DE");
            comboBoxStates.Items.Add("FL");
            comboBoxStates.Items.Add("GA");
            comboBoxStates.Items.Add("HI");
            comboBoxStates.Items.Add("ID");
            comboBoxStates.Items.Add("IL");
            comboBoxStates.Items.Add("IN");
            comboBoxStates.Items.Add("IA");
            comboBoxStates.Items.Add("KS");
            comboBoxStates.Items.Add("KY");
            comboBoxStates.Items.Add("LA");
            comboBoxStates.Items.Add("ME");
            comboBoxStates.Items.Add("MD");
            comboBoxStates.Items.Add("MA");
            comboBoxStates.Items.Add("MI");
            comboBoxStates.Items.Add("MN");
            comboBoxStates.Items.Add("MS");
            comboBoxStates.Items.Add("MO");
            comboBoxStates.Items.Add("MT");
            comboBoxStates.Items.Add("NE");
            comboBoxStates.Items.Add("NV");
            comboBoxStates.Items.Add("NH");
            comboBoxStates.Items.Add("NJ");
            comboBoxStates.Items.Add("NM");
            comboBoxStates.Items.Add("NY");
            comboBoxStates.Items.Add("NC");
            comboBoxStates.Items.Add("ND");
            comboBoxStates.Items.Add("OH");
            comboBoxStates.Items.Add("OK");
            comboBoxStates.Items.Add("OR");
            comboBoxStates.Items.Add("PA");
            comboBoxStates.Items.Add("RI");
            comboBoxStates.Items.Add("SC");
            comboBoxStates.Items.Add("SD");
            comboBoxStates.Items.Add("TN");
            comboBoxStates.Items.Add("TX");
            comboBoxStates.Items.Add("UT");
            comboBoxStates.Items.Add("VT");
            comboBoxStates.Items.Add("VA");
            comboBoxStates.Items.Add("WA");
            comboBoxStates.Items.Add("WV");
            comboBoxStates.Items.Add("WI");
            comboBoxStates.Items.Add("WY");
        }

        public Form1(Form2 form)
        {
            form2 = form;
            InitializeComponent();
        }

        public void setForm2(Form2 form)
        {
            form2 = form;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    info = new TaxInfo();

                    double adjGross, taxAmount = 0;

                    // turn into function
                    info.firstName = txtFirstName.Text;
                    info.lastName = txtLastName.Text;
                    info.address = txtAddress.Text;
                    info.city = txtCity.Text;
                    info.state = comboBoxStates.SelectedItem.ToString();
                    info.zipcode = txtZipCode.Text;
                    info.socSecNum = txtSocialSecurityNum.Text;
                    info.taxpayerExemptions = Convert.ToInt32(txtTaxpayerExemptions.Text);
                    info.grossEarnings = Convert.ToDouble(txtGrossEarnings.Text);
                    info.fedTaxWithheld = Convert.ToDouble(txtFedTaxWithheld.Text);
                    info.capitalGains = Convert.ToDouble(txtCapitalGains.Text);
                    info.realEstateExp = Convert.ToDouble(txtRealEstateTax.Text);
                    info.exciseExp = Convert.ToDouble(txtExciseTax.Text);
                    info.medicalExp = Convert.ToDouble(txtMedicalExpenses.Text);

                    adjGross = info.grossEarnings;

                    // Calculate adjusted gross
                    adjGross -= info.taxpayerExemptions * 1000;
                    adjGross -= .25 * (info.realEstateExp + info.exciseExp) + .08 * info.medicalExp;
                    adjGross += .15 * info.capitalGains;
                    adjGross = (int)(adjGross + .5);
                    info.adjustedGross = adjGross;
                    

                    // Calculate tax amount
                    if(adjGross >= 30000)
                    {
                        taxAmount += (adjGross - 29999) * .28;
                        adjGross -= (adjGross - 29999);
                    }

                    if (adjGross >= 20000)
                    {
                        taxAmount += (adjGross - 19999) * .25;
                        adjGross -= (adjGross - 19999);
                    }

                    if (adjGross >= 10000)
                    {
                        taxAmount += (adjGross - 9999) * .20;
                        adjGross -= (adjGross - 9999);
                    }

                    if (adjGross >= 1000)
                    {
                        taxAmount += (adjGross - 999) * .15;
                        adjGross -= (adjGross - 999);
                    }

                    if (adjGross > 0)
                    {
                        taxAmount += adjGross * .10;
                        adjGross -= adjGross;
                    }

                    info.calculatedTax = (int)taxAmount;

                    info.penalty = (info.fedTaxWithheld < .9 * info.calculatedTax ?
                        (int)(.10 * (info.calculatedTax - info.fedTaxWithheld)) : 0);

                    info.taxOwed_Gained = info.calculatedTax - info.fedTaxWithheld + info.penalty;

                    //infoList[count] = info;
                   // 
                    form2.setDataFields(info);
                    form2.Visible = true;
                    form2.Focus();
                    this.Visible = false;
                }
            }
           
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
             
        }

        public bool IsValidData()
        {
            return

            // Validate the taxpayer name text box
            IsPresent(txtFirstName, "First Name") &&
            IsPresent(txtLastName, "Last Name") &&

            // Validate the Address name text box
            IsPresent(txtAddress, "Address") &&

            // Validate the City text box
            IsPresent(txtCity, "City") &&

            // validate state
            IsSelected(comboBoxStates, "State") &&

            // Validate the zipcode name text box
            IsPresent(txtZipCode, "Zipcode") &&
            hasMinChar(txtZipCode, "Zipcode", 5) &&
            IsWithinRange(txtZipCode, "Zipcode", 0, 99999) &&

            // Validate the Social Security Num text box
            IsPresent(txtSocialSecurityNum, "Social Security Num") &&
            IsInt32(txtSocialSecurityNum, "Social Security Num") &&
            hasMinChar(txtSocialSecurityNum, "Social Security Num", 9) &&
            IsWithinRange(txtSocialSecurityNum, "Social Security Num", 0, 999999999) &&
            IsExistingSSInInfoList(txtSocialSecurityNum, "Social Security Num")  &&

            // Validate the Taxpayer Exemptions text box - Add pos validation
            IsPresent(txtTaxpayerExemptions, "Taxpayer Exemptions") &&
            IsInt32(txtTaxpayerExemptions, "Taxpayer Exemptions") &&

            // Validate the Gross Earnings text box
            IsPresent(txtGrossEarnings, "Gross Earnings") &&
            IsDecimal(txtGrossEarnings, "Gross Earnings") &&

            // Validate the Fed Tax withheld text box
            IsPresent(txtFedTaxWithheld, "Fed Tax withheld") &&
            IsDecimal(txtFedTaxWithheld, "Fed Tax withheld") &&

            // Validate the Capital Gains/losses text box
            IsPresent(txtCapitalGains, "Capital Gains") &&
            IsDecimal(txtCapitalGains, "Capital Gains") &&

            // Validate the Real Estate Tax text box
            IsPresent(txtRealEstateTax, "Real Estate Tax") &&
            IsDecimal(txtRealEstateTax, "Real Estate Tax") &&

            // Validate the Excise Tax text box
            IsPresent(txtExciseTax, "Excise Tax") &&
            IsDecimal(txtExciseTax, "Excise Tax") &&

            // Validate the Medical Expenses text box
            IsPresent(txtMedicalExpenses, "Medical Expenses") &&
            IsDecimal(txtMedicalExpenses, "Medical Expenses");
        }             

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsSelected(ComboBox box, String name)
        {
            if (comboBoxStates.SelectedIndex == -1)
            {
                MessageBox.Show("No " + name + " choice selected", "Entry Error");
                box.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsExistingSSInInfoList(TextBox textBox, string name)
        {
            //if (iL.Count > 0)
           // {
                if (iL.Find(i => i.socSecNum.Equals(txtSocialSecurityNum.Text)) != null)
                {
                    MessageBox.Show("Social Security Number " + txtSocialSecurityNum.Text + " already exists", "Entry Error");
                    textBox.Focus();
                    return false;
                }
            //}
            return true;
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min
                    + " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool hasMinChar(TextBox textBox, string name, int minChar)
        {
            if (textBox.TextLength < minChar)
            {
                MessageBox.Show( name + " has les than " + minChar + " characters", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;

        }

        public void clearText()
        {
            txtAddress.Text = "";
            txtCapitalGains.Text = "";
            txtCity.Text = "";
            txtExciseTax.Text = "";
            txtFedTaxWithheld.Text = "";
            txtGrossEarnings.Text = "";
            txtMedicalExpenses.Text = "";
            txtRealEstateTax.Text = "";
            txtSocialSecurityNum.Text = "";
            comboBoxStates.SelectedIndex = -1;
            txtTaxpayerExemptions.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtZipCode.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            form2.Close();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }

    public class TaxInfo
    {
        public static int count;

        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipcode;
        public string socSecNum;
        public int taxpayerExemptions;
        public double grossEarnings;
        public double fedTaxWithheld;
        public double capitalGains;
        public double realEstateExp;
        public double exciseExp;
        public double medicalExp;
        public double adjustedGross;
        public double calculatedTax;
        public double penalty;
        public double taxOwed_Gained;
    }
}