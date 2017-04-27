using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EBayCalc
{
    public partial class Form_EbayCalc : Form
    {
        public Form_EbayCalc()
        {
            InitializeComponent();

            m_dShipping_Received_Default = GetDoubleFromTextBox(textBox_Shipping_Received);
            m_dInsurance_Received_Default = GetDoubleFromTextBox(textBox_Insurance_Received);
            m_dHandling_Received_Default = GetDoubleFromTextBox(textBox_Handling_Received);

            m_dShipping_Paid_Default = GetDoubleFromTextBox(textBox_Shipping_Paid);
            m_dInsurance_Paid_Default = GetDoubleFromTextBox(textBox_Insurance_Paid);
            m_dHandling_Paid_Default = GetDoubleFromTextBox(textBox_Handling_Paid);
            SetWantLabel();

        }

        const double TAX_RATE = 0.28;

        #region [Default Values]
        private double m_dShipping_Received_Default = 0.00;
        private double m_dShipping_Paid_Default = 0.00;
        private double m_dInsurance_Received_Default = 0.00;
        private double m_dInsurance_Paid_Default = 0.00;
        private double m_dHandling_Paid_Default = 0.00;
        private double m_dHandling_Received_Default = 0.00;
        #endregion

        private double m_dWant = 0.00;
        private double m_dPrice_Paid = 0.00;
        private double m_dPrice_Sold = 0.00;
        private double m_dEbay_Charge = 0.00;
        private double m_dPayPal_Charge = 0.00;
        private double m_dShipping_Received = 0.00;
        private double m_dShipping_Paid = 0.00;
        private double m_dInsurance_Received = 0.00;
        private double m_dInsurance_Paid = 0.00;
        private double m_dHandling_Paid = 0.00;
        private double m_dHandling_Received = 0.00;
        private double m_dTax = 0.00;

        bool m_bStore = false;
        bool m_Abroad = false;

        private double GetMoneyReceived
        {
            get { return m_dPrice_Sold + m_dShipping_Received + m_dInsurance_Received + m_dHandling_Received; }
        }

        private double GetMoneyPaid
        {
            get
            {
                return m_dPrice_Paid +
                        m_dEbay_Charge +
                        m_dPayPal_Charge +
                        m_dShipping_Paid +
                        m_dInsurance_Paid +
                        m_dHandling_Paid +
                        m_dTax;
            }
        }

        private double Deductions
        {
            get
            {
                return m_dPrice_Paid +
                       m_dEbay_Charge +
                       m_dPayPal_Charge +
                       m_dShipping_Paid +
                       m_dInsurance_Paid +
                       m_dHandling_Paid;
            }
        }

        private double TaxableIncome
        {
            get { return GetMoneyReceived - Deductions; }
        }

        private double Tax { get { return TAX_RATE * TaxableIncome; } }

        /// <summary>
        /// Calculates PayPal Charge
        /// </summary>
        /// <returns></returns>
        private double Calc_PayPalFee()
        {
            if (radioButton_Sold_Abroad.Checked == true)
                m_dPayPal_Charge = 0.50 + GetMoneyReceived * 0.039;
            else
                m_dPayPal_Charge = 0.30 + GetMoneyReceived * 0.029;
            return m_dPayPal_Charge;
            //if (radioButton_Sold_Abroad.Checked == true)
            //    m_dPayPal_Charge = 0.30 + GetMoneyReceived * 0.035;
            //else
            //    m_dPayPal_Charge = 0.30 + GetMoneyReceived * 0.025;
            //return m_dPayPal_Charge;
        }

        private double GetEbayInsertionFee(double dPrice_Sold, bool isStore)
        {
            double dInsertionFee = 0.00;
            //if (isStore == false) //Auction
            //{
            //    if (dPrice_Sold >= 200.00)
            //        dInsertionFee = 2.00;
            //    else if (dPrice_Sold >= 50.00)
            //        dInsertionFee = 1.00;
            //    else if (dPrice_Sold >= 25.00)
            //        dInsertionFee = 0.75;
            //    else if (dPrice_Sold >= 10.00)
            //        dInsertionFee = 0.50;
            //    else if (dPrice_Sold >= 1.00)
            //        dInsertionFee = 0.25;
            //    else
            //        dInsertionFee = 0.10;
            //}
            //else //Store
            //    dInsertionFee = 0.05;
            return dInsertionFee;
        }

        private double GetEbayFinalValueFee(double dPrice_Sold, bool isStore)
        {
            return dPrice_Sold * 0.06;
            
            //double dFinalValueFee = 0.00;

            //if (isStore == false) //Auction
            //{
            //    if (dPrice_Sold >= 1000.00)
            //        dFinalValueFee = (50.00 * 0.0875) + ((1000 - 50.01) * 0.04) + (dPrice_Sold - 1000.01) * 0.02;
            //    else if (dPrice_Sold >= 50.00)
            //        dFinalValueFee = (50.00 * 0.0875) + (dPrice_Sold - 50.01) * 0.04;
            //    else
            //        dFinalValueFee = (dPrice_Sold * 0.0875);
            //}
            //else //Store
            //{
            //    if (dPrice_Sold >= 1000.00)
            //        dFinalValueFee = (50.00 * 0.12) + ((1000 - 50.01) * 0.06) + (dPrice_Sold - 1000.01) * 0.02;
            //    else if (m_dPrice_Sold >= 50.00)
            //        dFinalValueFee = (50.00 * 0.12) + (dPrice_Sold - 50.01) * 0.06;
            //    else
            //        dFinalValueFee = (dPrice_Sold * 0.12);
            //}
            //return dFinalValueFee;
        }

        /// <summary>
        /// Calculates Ebay Charge
        /// </summary>
        /// <returns></returns>
        private double Calc_EbayFee()
        {
            double dInsertionFee = GetEbayInsertionFee(m_dPrice_Sold, m_bStore);
            double dFinalValueFee = GetEbayFinalValueFee(m_dPrice_Sold + m_dShipping_Received, m_bStore);
            m_dEbay_Charge = dInsertionFee + dFinalValueFee;
            return m_dEbay_Charge;
        }


        private void checkBox_StayOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = this.checkBox_StayOnTop.Checked;
        }

        private void PutDoubleToTextBox(TextBox tb, double d)
        {
            tb.Text = String.Format("{0:0.00}", d);
        }

        private double GetDoubleFromTextBox(TextBox tb)
        {
            double result = 0.00;
            string s = tb.Text.ToString().Trim();
            try
            {
                result = double.Parse(tb.Text.ToString());
            }
            catch { }
            return result;
        }
        /// <summary>
        /// Calculate insertion fee which will produce desired after tax income
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Calculate_Click(object sender, EventArgs e)
        {
            m_dPrice_Paid = GetDoubleFromTextBox(textBox_PricePaid);
           
            m_dWant = GetDoubleFromTextBox(textBox_Want); 
            if (true == checkBox_ShareWithDed.Checked)
                m_dWant *= 2;

            m_dShipping_Received = GetDoubleFromTextBox(textBox_Shipping_Received);
            m_dInsurance_Received = GetDoubleFromTextBox(textBox_Insurance_Received);
            m_dHandling_Received = GetDoubleFromTextBox(textBox_Handling_Received);

            m_dShipping_Paid = GetDoubleFromTextBox(textBox_Shipping_Paid);
            m_dInsurance_Paid = GetDoubleFromTextBox(textBox_Insurance_Paid);
            m_dHandling_Paid = GetDoubleFromTextBox(textBox_Handling_Paid);

            m_bStore = radioButton_Store.Checked;
            m_Abroad = radioButton_Sold_Abroad.Checked;
            bool bShareWithDed = checkBox_ShareWithDed.Checked;

            if (m_dPrice_Paid <= 0.0)
            {
                textBox_PricePaid.Focus();
                return;
            }

            if (m_dWant <= 0.0)
            {
                textBox_Want.Focus();
                return;
            }

            CalculatePrice();

            PutDoubleToTextBox(textBox_EBay_InsertionFee_Charge, m_dEbay_Charge);
            PutDoubleToTextBox(textBox_PayPalFee, m_dPayPal_Charge);
            PutDoubleToTextBox(textBox_Tax, Tax);
            PutDoubleToTextBox(textBox_InsertionPrice, m_dPrice_Sold);

            textBox_Want.Focus();
            textBox_Want.SelectAll();

        }

        private void CalculatePrice()
        {
            int i = 0;
            double dMade = 0.00;
            double delta = 0.00;
            double precision = 0.01;

            m_dPrice_Sold = 2 * (m_dPrice_Paid + m_dWant);  //Start Somewhere

            while (true)
            {

                if (i > 100)
                {
                    MessageBox.Show("Not converging fast enough");
                    break;
                }

                Calc_EbayFee();
                Calc_PayPalFee();
                m_dTax = Tax;
                dMade = GetMoneyReceived - GetMoneyPaid;
                delta = dMade - m_dWant;

                if (delta <= precision)
                    break;
                m_dPrice_Sold -= delta / 2;

            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_PricePaid.Text = string.Empty;
            textBox_Want.Text = string.Empty;
            textBox_EBay_InsertionFee_Charge.Text = string.Empty;
            textBox_PayPalFee.Text = string.Empty;
            textBox_Tax.Text = string.Empty;
            PutDoubleToTextBox(textBox_Shipping_Paid, m_dShipping_Paid_Default);
            PutDoubleToTextBox(textBox_Insurance_Paid, m_dInsurance_Paid_Default);
            PutDoubleToTextBox(textBox_Handling_Paid, m_dHandling_Paid_Default);
            PutDoubleToTextBox(textBox_Shipping_Received, m_dShipping_Received_Default);
            PutDoubleToTextBox(textBox_Insurance_Received, m_dInsurance_Received_Default);
            PutDoubleToTextBox(textBox_Handling_Received, m_dHandling_Received_Default);
            textBox_InsertionPrice.Text = string.Empty;
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_Shipping_Paid_Click(object sender, EventArgs e)
        {
            textBox_Shipping_Paid.SelectAll();
        }

        private void textBox_Insurance_Paid_Click(object sender, EventArgs e)
        {
            textBox_Insurance_Paid.SelectAll();
        }

        private void textBox_Handling_Paid_Click(object sender, EventArgs e)
        {
            textBox_Handling_Paid.SelectAll();
        }

        private void textBox_Shipping_Received_Click(object sender, EventArgs e)
        {
            textBox_Shipping_Received.SelectAll();
        }

        private void textBox_Insurance_Received_Click(object sender, EventArgs e)
        {
            textBox_Insurance_Received.SelectAll();
        }

        private void textBox_Handling_Received_Click(object sender, EventArgs e)
        {
            textBox_Handling_Received.SelectAll();
        }

        private void SetWantLabel()
        {
            label_Want.Text = (checkBox_ShareWithDed.Checked) ? "Each Wants" : "I Want";
        }

        private void checkBox_ShareWithDed_CheckedChanged(object sender, EventArgs e)
        {
            SetWantLabel();
        }
    }
}
