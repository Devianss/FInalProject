using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class Form2 : Form
    {
        #region Variable Initialization
        //Product Total
        int ProductTotal = 0;

        //Product 1
        int Product1Amount = 0;
        int Product1Price = 99;
        int Product1Total = 0;

        //Product 2
        int Product2Amount = 0;
        int Product2Price = 69;
        int Product2Total = 0;
        //Product 3
        int Product3Amount = 0;
        int Product3Price = 69;
        int Product3Total = 0;

        #endregion

        #region Initialization
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Sets the value to zero
            Product1quantity.Text = Convert.ToString(Product1Amount);
            Product2quantity.Text = Convert.ToString(Product2Amount);
            Product3quantity.Text = Convert.ToString(Product3Amount);
        }
        #endregion


        private void btnPlus1_Click(object sender, EventArgs e)
        {
            //Increments product 1
            Product1Amount += 1;
            Product1quantity.Text = Convert.ToString(Product1Amount);
            UpdateOrderBox();
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            //Decrements product 1
            Product1Amount -= 1;
            if (Product1Amount < 0)
            {
                Product1Amount = 0;
            }
            Product1quantity.Text = Convert.ToString(Product1Amount);
            UpdateOrderBox();
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            //Increments product 2
            Product2Amount += 1;
            Product2quantity.Text = Convert.ToString(Product2Amount);
            UpdateOrderBox();
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            //Decrements product 2
            Product2Amount -= 1;
            if (Product2Amount < 0)
            {
                Product2Amount = 0;
            }
            Product2quantity.Text = Convert.ToString(Product2Amount);
            UpdateOrderBox();
        }
        
        private void btnPlus3_Click(object sender, EventArgs e)
        {
            //Increments product 3
            Product3Amount += 1;
            Product3quantity.Text = Convert.ToString(Product3Amount);
        }

        private void btnMinus3_Click(object sender, EventArgs e)
        {
            //Decrements product 3
            Product3Amount -= 1;
            if (Product3Amount < 0)
            {
                Product3Amount = 0;
            }
            Product3quantity.Text = Convert.ToString(Product3Amount);
            UpdateOrderBox();
        }
        

        #region Manages The OrderBoxes
        //Updates OrderBox
        private void UpdateOrderBox()
        {
            OrderInfoBox.Text = null;

            if (Product1Amount != 0)
            {
                Product1Total = Product1Amount * Product1Price;
                OrderInfoBox.Text += "BOO Tea: x" + Product1Amount + "   Price: " + Product1Total + " \r\n";
            }
            if (Product2Amount != 0)
            {
                Product2Total = Product2Amount * Product2Price;
                OrderInfoBox.Text += "Thai Milktea: x" + Product2Amount + "   Price: " + Product2Total + " \r\n";
            }
            if (Product3Amount != 0)
            {
                Product3Total = Product3Amount * Product3Price;
                OrderInfoBox.Text += "Matcha Milktea: x" + Product3Amount + "   Price: " + Product3Total + " \r\n";
            }

            ProductTotal = (Product1Total + Product2Total + Product3Total);
        }
        //Total Amount
        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            TotalAmount.Text = "P " + ProductTotal;
        }
        //Clear Button  
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            TotalAmount.Text = String.Empty;
        }
        
        #endregion
    }
}
