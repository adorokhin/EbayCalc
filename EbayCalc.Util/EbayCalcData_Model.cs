using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbayCalc_Utils
{
    public sealed partial class EbayCalcData_Model
    {
        public enum TransactionTypeEnum { AUCTION, STORE };
        public enum ShipmentTypeEnum { ABROAD, LOCAL };

        public TransactionTypeEnum TransactionType = TransactionTypeEnum.STORE;
        public ShipmentTypeEnum ShippingType = ShipmentTypeEnum.LOCAL;

        /// <summary>
        /// Money I would like to earn (either myself of each of us depending on condition)
        /// </summary>
        public double Want { get; set; }
        
        /// <summary>
        /// Calculated Ebay Insertion Price for all inputs
        /// </summary>
        public double InsertionPrice { get; set; }

        #region [Money Going In]
        /// <summary>
        /// Sell price of this item
        /// </summary>
        public double Price_Sold { get; set; }

        /// <summary>
        /// I'll charge this amount for shipping
        /// </summary>
        public double Shipping_Received { get; set; }

        /// <summary>
        /// I'll charge this amount to insure this item.
        /// </summary>
        public double Insurance_Received { get; set; }

        // Misc Handling amount I'll receive
        public double Handling_Received { get; set; }

        #endregion

        #region [Money Going Out]
        /// <summary>
        /// Price I paid for this item
        /// </summary>
        public double Price_Paid { get; set; }

        /// <summary>
        /// <Calculated Value> Amount Ebay charges for this Item
        /// </summary>
        public double Ebay_Charge { get; set; }

        /// <summary>
        /// <Calculated Value> Amount PayPal charges
        /// </summary>
        public double PayPal_Charge { get; set; }

        /// <summary>
        /// I'll pay this much for shipping this item
        /// </summary>
        public double Shipping_Paid { get; set; }

        // I'll pay this amount to insure this item
        public double Insurance_Paid { get; set; }

        // Misc Handling chargeamount I'll pay
        public double Handling_Paid { get; set; }

        // Approx amount I'll pay in tax 
        public double Tax { get; set; }
        #endregion
    }
}


