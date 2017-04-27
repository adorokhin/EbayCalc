namespace EBayCalc
{
    partial class Form_EbayCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EbayCalc));
            this.label_PricePaid = new System.Windows.Forms.Label();
            this.label_PayPal_Charge = new System.Windows.Forms.Label();
            this.label_Ebay_InsertionFee_Charge = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox_ShareWithDed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.checkBox_StayOnTop = new System.Windows.Forms.CheckBox();
            this.label_Want = new System.Windows.Forms.Label();
            this.groupBox_Pay = new System.Windows.Forms.GroupBox();
            this.label_Tax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_Projected_Receive = new System.Windows.Forms.GroupBox();
            this.radioButton_Sold_Abroad = new System.Windows.Forms.RadioButton();
            this.radioButton_Sold_USA = new System.Windows.Forms.RadioButton();
            this.panel_ShipTo = new System.Windows.Forms.Panel();
            this.radioButton_Store = new System.Windows.Forms.RadioButton();
            this.radioButton_Auction = new System.Windows.Forms.RadioButton();
            this.panel_Store_Auction = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_Handling_Received = new EBayCalc.TextBox_Numeric();
            this.textBox_Shipping_Received = new EBayCalc.TextBox_Numeric();
            this.textBox_Insurance_Received = new EBayCalc.TextBox_Numeric();
            this.textBox_Tax = new EBayCalc.TextBox_Numeric();
            this.textBox_PayPalFee = new EBayCalc.TextBox_Numeric();
            this.textBox_Handling_Paid = new EBayCalc.TextBox_Numeric();
            this.textBox_EBay_InsertionFee_Charge = new EBayCalc.TextBox_Numeric();
            this.textBox_Shipping_Paid = new EBayCalc.TextBox_Numeric();
            this.textBox_Insurance_Paid = new EBayCalc.TextBox_Numeric();
            this.textBox_Want = new EBayCalc.TextBox_Numeric();
            this.textBox_InsertionPrice = new EBayCalc.TextBox_Numeric();
            this.textBox_PricePaid = new EBayCalc.TextBox_Numeric();
            this.groupBox_Pay.SuspendLayout();
            this.groupBox_Projected_Receive.SuspendLayout();
            this.panel_ShipTo.SuspendLayout();
            this.panel_Store_Auction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_PricePaid
            // 
            this.label_PricePaid.AutoSize = true;
            this.label_PricePaid.Location = new System.Drawing.Point(5, 3);
            this.label_PricePaid.Name = "label_PricePaid";
            this.label_PricePaid.Size = new System.Drawing.Size(55, 13);
            this.label_PricePaid.TabIndex = 0;
            this.label_PricePaid.Text = "Price Paid";
            // 
            // label_PayPal_Charge
            // 
            this.label_PayPal_Charge.AutoSize = true;
            this.label_PayPal_Charge.Location = new System.Drawing.Point(58, 15);
            this.label_PayPal_Charge.Name = "label_PayPal_Charge";
            this.label_PayPal_Charge.Size = new System.Drawing.Size(40, 13);
            this.label_PayPal_Charge.TabIndex = 8;
            this.label_PayPal_Charge.Text = "PayPal";
            // 
            // label_Ebay_InsertionFee_Charge
            // 
            this.label_Ebay_InsertionFee_Charge.AutoSize = true;
            this.label_Ebay_InsertionFee_Charge.Location = new System.Drawing.Point(6, 15);
            this.label_Ebay_InsertionFee_Charge.Name = "label_Ebay_InsertionFee_Charge";
            this.label_Ebay_InsertionFee_Charge.Size = new System.Drawing.Size(44, 13);
            this.label_Ebay_InsertionFee_Charge.TabIndex = 6;
            this.label_Ebay_InsertionFee_Charge.Text = "EBay IF";
            this.toolTip1.SetToolTip(this.label_Ebay_InsertionFee_Charge, "EBay Insertion Fee");
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(80, 274);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(47, 23);
            this.button_Reset.TabIndex = 9;
            this.button_Reset.Text = "&Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // checkBox_ShareWithDed
            // 
            this.checkBox_ShareWithDed.AutoSize = true;
            this.checkBox_ShareWithDed.Checked = true;
            this.checkBox_ShareWithDed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ShareWithDed.Location = new System.Drawing.Point(145, 22);
            this.checkBox_ShareWithDed.Name = "checkBox_ShareWithDed";
            this.checkBox_ShareWithDed.Size = new System.Drawing.Size(15, 14);
            this.checkBox_ShareWithDed.TabIndex = 14;
            this.toolTip1.SetToolTip(this.checkBox_ShareWithDed, "If Checked  - means that BOTH you and GSB \r\nexpect to make whatever is entered in" +
                    "  `Want` \r\n");
            this.checkBox_ShareWithDed.UseVisualStyleBackColor = true;
            this.checkBox_ShareWithDed.CheckedChanged += new System.EventHandler(this.checkBox_ShareWithDed_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insertion Price";
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(8, 274);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(66, 23);
            this.button_Calculate.TabIndex = 8;
            this.button_Calculate.Text = "&Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // checkBox_StayOnTop
            // 
            this.checkBox_StayOnTop.AutoSize = true;
            this.checkBox_StayOnTop.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox_StayOnTop.Checked = true;
            this.checkBox_StayOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_StayOnTop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBox_StayOnTop.Location = new System.Drawing.Point(0, 299);
            this.checkBox_StayOnTop.Name = "checkBox_StayOnTop";
            this.checkBox_StayOnTop.Size = new System.Drawing.Size(174, 17);
            this.checkBox_StayOnTop.TabIndex = 0;
            this.checkBox_StayOnTop.TabStop = false;
            this.checkBox_StayOnTop.Text = "Stay On Top";
            this.checkBox_StayOnTop.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.checkBox_StayOnTop.UseVisualStyleBackColor = true;
            this.checkBox_StayOnTop.CheckedChanged += new System.EventHandler(this.checkBox_StayOnTop_CheckedChanged);
            // 
            // label_Want
            // 
            this.label_Want.AutoSize = true;
            this.label_Want.Location = new System.Drawing.Point(76, 3);
            this.label_Want.Name = "label_Want";
            this.label_Want.Size = new System.Drawing.Size(33, 13);
            this.label_Want.TabIndex = 13;
            this.label_Want.Text = "Want";
            // 
            // groupBox_Pay
            // 
            this.groupBox_Pay.Controls.Add(this.textBox_Tax);
            this.groupBox_Pay.Controls.Add(this.label_Tax);
            this.groupBox_Pay.Controls.Add(this.textBox_PayPalFee);
            this.groupBox_Pay.Controls.Add(this.textBox_Handling_Paid);
            this.groupBox_Pay.Controls.Add(this.label_PayPal_Charge);
            this.groupBox_Pay.Controls.Add(this.textBox_EBay_InsertionFee_Charge);
            this.groupBox_Pay.Controls.Add(this.label2);
            this.groupBox_Pay.Controls.Add(this.label_Ebay_InsertionFee_Charge);
            this.groupBox_Pay.Controls.Add(this.label4);
            this.groupBox_Pay.Controls.Add(this.label3);
            this.groupBox_Pay.Controls.Add(this.textBox_Shipping_Paid);
            this.groupBox_Pay.Controls.Add(this.textBox_Insurance_Paid);
            this.groupBox_Pay.Location = new System.Drawing.Point(3, 84);
            this.groupBox_Pay.Name = "groupBox_Pay";
            this.groupBox_Pay.Size = new System.Drawing.Size(168, 91);
            this.groupBox_Pay.TabIndex = 5;
            this.groupBox_Pay.TabStop = false;
            this.groupBox_Pay.Text = "$$$ I\'ll Pay";
            // 
            // label_Tax
            // 
            this.label_Tax.AutoSize = true;
            this.label_Tax.Location = new System.Drawing.Point(111, 15);
            this.label_Tax.Name = "label_Tax";
            this.label_Tax.Size = new System.Drawing.Size(25, 13);
            this.label_Tax.TabIndex = 20;
            this.label_Tax.Text = "Tax";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Shipping";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Handling";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Insurance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Handling";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Shipping";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Insurance";
            // 
            // groupBox_Projected_Receive
            // 
            this.groupBox_Projected_Receive.Controls.Add(this.textBox_Handling_Received);
            this.groupBox_Projected_Receive.Controls.Add(this.label6);
            this.groupBox_Projected_Receive.Controls.Add(this.label5);
            this.groupBox_Projected_Receive.Controls.Add(this.label7);
            this.groupBox_Projected_Receive.Controls.Add(this.textBox_Shipping_Received);
            this.groupBox_Projected_Receive.Controls.Add(this.textBox_Insurance_Received);
            this.groupBox_Projected_Receive.Location = new System.Drawing.Point(3, 176);
            this.groupBox_Projected_Receive.Name = "groupBox_Projected_Receive";
            this.groupBox_Projected_Receive.Size = new System.Drawing.Size(168, 56);
            this.groupBox_Projected_Receive.TabIndex = 6;
            this.groupBox_Projected_Receive.TabStop = false;
            this.groupBox_Projected_Receive.Text = "$$$ I\'ll Receive";
            // 
            // radioButton_Sold_Abroad
            // 
            this.radioButton_Sold_Abroad.AutoSize = true;
            this.radioButton_Sold_Abroad.Checked = true;
            this.radioButton_Sold_Abroad.Location = new System.Drawing.Point(3, 21);
            this.radioButton_Sold_Abroad.Name = "radioButton_Sold_Abroad";
            this.radioButton_Sold_Abroad.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Sold_Abroad.TabIndex = 2;
            this.radioButton_Sold_Abroad.TabStop = true;
            this.radioButton_Sold_Abroad.Text = "Abroad";
            this.radioButton_Sold_Abroad.UseVisualStyleBackColor = true;
            // 
            // radioButton_Sold_USA
            // 
            this.radioButton_Sold_USA.AutoSize = true;
            this.radioButton_Sold_USA.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Sold_USA.Name = "radioButton_Sold_USA";
            this.radioButton_Sold_USA.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Sold_USA.TabIndex = 1;
            this.radioButton_Sold_USA.Text = "USA";
            this.radioButton_Sold_USA.UseVisualStyleBackColor = true;
            // 
            // panel_ShipTo
            // 
            this.panel_ShipTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_ShipTo.Controls.Add(this.radioButton_Sold_USA);
            this.panel_ShipTo.Controls.Add(this.radioButton_Sold_Abroad);
            this.panel_ShipTo.Location = new System.Drawing.Point(78, 42);
            this.panel_ShipTo.Name = "panel_ShipTo";
            this.panel_ShipTo.Size = new System.Drawing.Size(64, 42);
            this.panel_ShipTo.TabIndex = 4;
            this.panel_ShipTo.TabStop = true;
            // 
            // radioButton_Store
            // 
            this.radioButton_Store.AutoSize = true;
            this.radioButton_Store.Checked = true;
            this.radioButton_Store.Location = new System.Drawing.Point(3, 21);
            this.radioButton_Store.Name = "radioButton_Store";
            this.radioButton_Store.Size = new System.Drawing.Size(50, 17);
            this.radioButton_Store.TabIndex = 2;
            this.radioButton_Store.TabStop = true;
            this.radioButton_Store.Text = "Store";
            this.radioButton_Store.UseVisualStyleBackColor = true;
            // 
            // radioButton_Auction
            // 
            this.radioButton_Auction.AutoSize = true;
            this.radioButton_Auction.Location = new System.Drawing.Point(3, 3);
            this.radioButton_Auction.Name = "radioButton_Auction";
            this.radioButton_Auction.Size = new System.Drawing.Size(61, 17);
            this.radioButton_Auction.TabIndex = 1;
            this.radioButton_Auction.TabStop = true;
            this.radioButton_Auction.Text = "Auction";
            this.radioButton_Auction.UseVisualStyleBackColor = true;
            // 
            // panel_Store_Auction
            // 
            this.panel_Store_Auction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Store_Auction.Controls.Add(this.radioButton_Auction);
            this.panel_Store_Auction.Controls.Add(this.radioButton_Store);
            this.panel_Store_Auction.Location = new System.Drawing.Point(6, 42);
            this.panel_Store_Auction.Name = "panel_Store_Auction";
            this.panel_Store_Auction.Size = new System.Drawing.Size(69, 42);
            this.panel_Store_Auction.TabIndex = 3;
            this.panel_Store_Auction.TabStop = true;
            // 
            // button_Exit
            // 
            this.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Exit.Location = new System.Drawing.Point(133, 274);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(33, 23);
            this.button_Exit.TabIndex = 10;
            this.button_Exit.Text = "E&xit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_Handling_Received
            // 
            this.textBox_Handling_Received.AllowSpace = false;
            this.textBox_Handling_Received.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Handling_Received.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EBayCalc.Properties.Settings.Default, "Handling_Received", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Handling_Received.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Handling_Received.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_Handling_Received.Location = new System.Drawing.Point(111, 30);
            this.textBox_Handling_Received.MaxLength = 7;
            this.textBox_Handling_Received.Name = "textBox_Handling_Received";
            this.textBox_Handling_Received.Size = new System.Drawing.Size(50, 21);
            this.textBox_Handling_Received.TabIndex = 3;
            this.textBox_Handling_Received.Text = global::EBayCalc.Properties.Settings.Default.Handling_Received;
            this.textBox_Handling_Received.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_Handling_Received, "Handling Received");
            this.textBox_Handling_Received.Click += new System.EventHandler(this.textBox_Handling_Received_Click);
            // 
            // textBox_Shipping_Received
            // 
            this.textBox_Shipping_Received.AllowSpace = false;
            this.textBox_Shipping_Received.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Shipping_Received.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EBayCalc.Properties.Settings.Default, "Shipping_Received", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Shipping_Received.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Shipping_Received.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_Shipping_Received.Location = new System.Drawing.Point(5, 30);
            this.textBox_Shipping_Received.MaxLength = 7;
            this.textBox_Shipping_Received.Name = "textBox_Shipping_Received";
            this.textBox_Shipping_Received.Size = new System.Drawing.Size(50, 21);
            this.textBox_Shipping_Received.TabIndex = 1;
            this.textBox_Shipping_Received.Text = global::EBayCalc.Properties.Settings.Default.Shipping_Received;
            this.textBox_Shipping_Received.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_Shipping_Received, "Shipping Received");
            this.textBox_Shipping_Received.Click += new System.EventHandler(this.textBox_Shipping_Received_Click);
            // 
            // textBox_Insurance_Received
            // 
            this.textBox_Insurance_Received.AllowSpace = false;
            this.textBox_Insurance_Received.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Insurance_Received.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EBayCalc.Properties.Settings.Default, "Insurance_Received", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Insurance_Received.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Insurance_Received.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox_Insurance_Received.Location = new System.Drawing.Point(58, 30);
            this.textBox_Insurance_Received.MaxLength = 7;
            this.textBox_Insurance_Received.Name = "textBox_Insurance_Received";
            this.textBox_Insurance_Received.Size = new System.Drawing.Size(50, 21);
            this.textBox_Insurance_Received.TabIndex = 2;
            this.textBox_Insurance_Received.Text = global::EBayCalc.Properties.Settings.Default.Insurance_Received;
            this.textBox_Insurance_Received.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_Insurance_Received, "Insurance Received");
            this.textBox_Insurance_Received.Click += new System.EventHandler(this.textBox_Insurance_Received_Click);
            // 
            // textBox_Tax
            // 
            this.textBox_Tax.AllowSpace = false;
            this.textBox_Tax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Tax.Enabled = false;
            this.textBox_Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Tax.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox_Tax.Location = new System.Drawing.Point(111, 31);
            this.textBox_Tax.MaxLength = 7;
            this.textBox_Tax.Name = "textBox_Tax";
            this.textBox_Tax.Size = new System.Drawing.Size(50, 21);
            this.textBox_Tax.TabIndex = 19;
            // 
            // textBox_PayPalFee
            // 
            this.textBox_PayPalFee.AllowSpace = false;
            this.textBox_PayPalFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PayPalFee.Enabled = false;
            this.textBox_PayPalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PayPalFee.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox_PayPalFee.Location = new System.Drawing.Point(58, 31);
            this.textBox_PayPalFee.MaxLength = 7;
            this.textBox_PayPalFee.Name = "textBox_PayPalFee";
            this.textBox_PayPalFee.Size = new System.Drawing.Size(50, 21);
            this.textBox_PayPalFee.TabIndex = 2;
            // 
            // textBox_Handling_Paid
            // 
            this.textBox_Handling_Paid.AllowSpace = false;
            this.textBox_Handling_Paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Handling_Paid.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EBayCalc.Properties.Settings.Default, "Handling_Paid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Handling_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Handling_Paid.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox_Handling_Paid.Location = new System.Drawing.Point(111, 66);
            this.textBox_Handling_Paid.MaxLength = 7;
            this.textBox_Handling_Paid.Name = "textBox_Handling_Paid";
            this.textBox_Handling_Paid.Size = new System.Drawing.Size(50, 21);
            this.textBox_Handling_Paid.TabIndex = 5;
            this.textBox_Handling_Paid.Text = global::EBayCalc.Properties.Settings.Default.Handling_Paid;
            this.textBox_Handling_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_Handling_Paid, "Paid Handling");
            this.textBox_Handling_Paid.Click += new System.EventHandler(this.textBox_Handling_Paid_Click);
            // 
            // textBox_EBay_InsertionFee_Charge
            // 
            this.textBox_EBay_InsertionFee_Charge.AllowSpace = false;
            this.textBox_EBay_InsertionFee_Charge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EBay_InsertionFee_Charge.Enabled = false;
            this.textBox_EBay_InsertionFee_Charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EBay_InsertionFee_Charge.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox_EBay_InsertionFee_Charge.Location = new System.Drawing.Point(6, 31);
            this.textBox_EBay_InsertionFee_Charge.MaxLength = 7;
            this.textBox_EBay_InsertionFee_Charge.Name = "textBox_EBay_InsertionFee_Charge";
            this.textBox_EBay_InsertionFee_Charge.Size = new System.Drawing.Size(50, 21);
            this.textBox_EBay_InsertionFee_Charge.TabIndex = 1;
            this.textBox_EBay_InsertionFee_Charge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_EBay_InsertionFee_Charge, "EBay Insertion Fee");
            // 
            // textBox_Shipping_Paid
            // 
            this.textBox_Shipping_Paid.AllowSpace = false;
            this.textBox_Shipping_Paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Shipping_Paid.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EBayCalc.Properties.Settings.Default, "Shipping_Paid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Shipping_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Shipping_Paid.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox_Shipping_Paid.Location = new System.Drawing.Point(6, 66);
            this.textBox_Shipping_Paid.MaxLength = 7;
            this.textBox_Shipping_Paid.Name = "textBox_Shipping_Paid";
            this.textBox_Shipping_Paid.Size = new System.Drawing.Size(50, 21);
            this.textBox_Shipping_Paid.TabIndex = 3;
            this.textBox_Shipping_Paid.Text = global::EBayCalc.Properties.Settings.Default.Shipping_Paid;
            this.textBox_Shipping_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_Shipping_Paid, "Paid Shiping");
            this.textBox_Shipping_Paid.Click += new System.EventHandler(this.textBox_Shipping_Paid_Click);
            // 
            // textBox_Insurance_Paid
            // 
            this.textBox_Insurance_Paid.AllowSpace = false;
            this.textBox_Insurance_Paid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Insurance_Paid.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EBayCalc.Properties.Settings.Default, "Insurance_Paid", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Insurance_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Insurance_Paid.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox_Insurance_Paid.Location = new System.Drawing.Point(58, 66);
            this.textBox_Insurance_Paid.MaxLength = 7;
            this.textBox_Insurance_Paid.Name = "textBox_Insurance_Paid";
            this.textBox_Insurance_Paid.Size = new System.Drawing.Size(50, 21);
            this.textBox_Insurance_Paid.TabIndex = 4;
            this.textBox_Insurance_Paid.Text = global::EBayCalc.Properties.Settings.Default.Insurance_Paid;
            this.textBox_Insurance_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_Insurance_Paid, "Paid Insurance");
            this.textBox_Insurance_Paid.Click += new System.EventHandler(this.textBox_Insurance_Paid_Click);
            // 
            // textBox_Want
            // 
            this.textBox_Want.AllowSpace = false;
            this.textBox_Want.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Want.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Want.Location = new System.Drawing.Point(77, 19);
            this.textBox_Want.MaxLength = 7;
            this.textBox_Want.Name = "textBox_Want";
            this.textBox_Want.Size = new System.Drawing.Size(65, 21);
            this.textBox_Want.TabIndex = 2;
            this.textBox_Want.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_Want, "$$$ Earned after all expences and GSB share");
            // 
            // textBox_InsertionPrice
            // 
            this.textBox_InsertionPrice.AllowSpace = false;
            this.textBox_InsertionPrice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_InsertionPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_InsertionPrice.Enabled = false;
            this.textBox_InsertionPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InsertionPrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox_InsertionPrice.Location = new System.Drawing.Point(50, 249);
            this.textBox_InsertionPrice.MaxLength = 7;
            this.textBox_InsertionPrice.Name = "textBox_InsertionPrice";
            this.textBox_InsertionPrice.ReadOnly = true;
            this.textBox_InsertionPrice.Size = new System.Drawing.Size(74, 21);
            this.textBox_InsertionPrice.TabIndex = 7;
            this.textBox_InsertionPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_InsertionPrice, "Your desired Insertion Price");
            // 
            // textBox_PricePaid
            // 
            this.textBox_PricePaid.AllowSpace = false;
            this.textBox_PricePaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PricePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PricePaid.Location = new System.Drawing.Point(6, 19);
            this.textBox_PricePaid.MaxLength = 7;
            this.textBox_PricePaid.Name = "textBox_PricePaid";
            this.textBox_PricePaid.Size = new System.Drawing.Size(69, 21);
            this.textBox_PricePaid.TabIndex = 1;
            this.textBox_PricePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.textBox_PricePaid, "What we paid for this item");
            // 
            // Form_EbayCalc
            // 
            this.AcceptButton = this.button_Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Exit;
            this.ClientSize = new System.Drawing.Size(174, 316);
            this.Controls.Add(this.checkBox_ShareWithDed);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox_Projected_Receive);
            this.Controls.Add(this.panel_ShipTo);
            this.Controls.Add(this.panel_Store_Auction);
            this.Controls.Add(this.groupBox_Pay);
            this.Controls.Add(this.textBox_Want);
            this.Controls.Add(this.label_Want);
            this.Controls.Add(this.checkBox_StayOnTop);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.textBox_InsertionPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.textBox_PricePaid);
            this.Controls.Add(this.label_PricePaid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_EbayCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebay Calculator";
            this.groupBox_Pay.ResumeLayout(false);
            this.groupBox_Pay.PerformLayout();
            this.groupBox_Projected_Receive.ResumeLayout(false);
            this.groupBox_Projected_Receive.PerformLayout();
            this.panel_ShipTo.ResumeLayout(false);
            this.panel_ShipTo.PerformLayout();
            this.panel_Store_Auction.ResumeLayout(false);
            this.panel_Store_Auction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PricePaid;
        private TextBox_Numeric textBox_PricePaid;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_Reset;
        private TextBox_Numeric textBox_InsertionPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Calculate;
        private TextBox_Numeric textBox_PayPalFee;
        private System.Windows.Forms.Label label_PayPal_Charge;
        private TextBox_Numeric textBox_EBay_InsertionFee_Charge;
        private System.Windows.Forms.Label label_Ebay_InsertionFee_Charge;
        private System.Windows.Forms.CheckBox checkBox_StayOnTop;
        private TextBox_Numeric textBox_Want;
        private System.Windows.Forms.Label label_Want;
        private System.Windows.Forms.GroupBox groupBox_Pay;
        private TextBox_Numeric textBox_Shipping_Paid;
        private System.Windows.Forms.Label label2;
        private TextBox_Numeric textBox_Insurance_Paid;
        private System.Windows.Forms.Label label3;
        private TextBox_Numeric textBox_Handling_Paid;
        private System.Windows.Forms.Label label4;
        private TextBox_Numeric textBox_Handling_Received;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private TextBox_Numeric textBox_Insurance_Received;
        private TextBox_Numeric textBox_Shipping_Received;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_Projected_Receive;
        private System.Windows.Forms.RadioButton radioButton_Sold_Abroad;
        private System.Windows.Forms.RadioButton radioButton_Sold_USA;
        private System.Windows.Forms.Panel panel_ShipTo;
        private System.Windows.Forms.RadioButton radioButton_Store;
        private System.Windows.Forms.RadioButton radioButton_Auction;
        private System.Windows.Forms.Panel panel_Store_Auction;
        private System.Windows.Forms.Button button_Exit;
        private TextBox_Numeric textBox_Tax;
        private System.Windows.Forms.Label label_Tax;
        private System.Windows.Forms.CheckBox checkBox_ShareWithDed;
    }
}

