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

        //Product 4
        int Product4Amount = 0;
        int Product4Price = 69;
        int Product4Total = 0;

        //Product 5
        int Product5Amount = 0;
        int Product5Price = 69;
        int Product5Total = 0;

        //Product 6
        int Product6Amount = 0;
        int Product6Price = 69;
        int Product6Total = 0;

        //Product 7
        int Product7Amount = 0;
        int Product7Price = 50;
        int Product7Total = 0;

        //Product 8
        int Product8Amount = 0;
        int Product8Price = 80;
        int Product8Total = 0;

        //Product 9
        int Product9Amount = 0;
        int Product9Price = 60;
        int Product9Total = 0;

        //Product 10
        int Product10Amount = 0;
        int Product10Price = 55;
        int Product10Total = 0;

        //Product 11
        int Product11Amount = 0;
        int Product11Price = 120;
        int Product11Total = 0;

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
            Product4quantity.Text = Convert.ToString(Product4Amount);
            Product5quantity.Text = Convert.ToString(Product5Amount);
            Product6quantity.Text = Convert.ToString(Product6Amount);
            Product7quantity.Text = Convert.ToString(Product7Amount);
            Product8quantity.Text = Convert.ToString(Product8Amount);
            Product9quantity.Text = Convert.ToString(Product9Amount);
            Product10quantity.Text = Convert.ToString(Product10Amount);
            Product11quantity.Text = Convert.ToString(Product11Amount);
        }
        #endregion

        #region Increment Decriment
        /// <summary>
        /// This manages the quantity of products
        /// Increment and Decrements products
        /// </summary>
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
            UpdateOrderBox();
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

        private void btnPlus4_Click(object sender, EventArgs e)
        {
            //Increments product 4
            Product4Amount += 1;
            Product4quantity.Text = Convert.ToString(Product4Amount);
            UpdateOrderBox();
        }

        private void btnMinus4_Click(object sender, EventArgs e)
        {
            //Decrements product 4
            Product4Amount -= 1;
            if (Product4Amount < 0)
            {
                Product4Amount = 0;
            }
            Product4quantity.Text = Convert.ToString(Product4Amount);
            UpdateOrderBox();
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            //Increments product 5
            Product5Amount += 1;
            Product5quantity.Text = Convert.ToString(Product5Amount);
            UpdateOrderBox();
        }

        private void btnMinus5_Click(object sender, EventArgs e)
        {
            //Decrements product 5
            Product5Amount -= 1;
            if (Product5Amount < 0)
            {
                Product5Amount = 0;
            }
            Product5quantity.Text = Convert.ToString(Product5Amount);
            UpdateOrderBox();
        }

        private void btnPlus6_Click(object sender, EventArgs e)
        {
            //Increments product 6
            Product6Amount += 1;
            Product6quantity.Text = Convert.ToString(Product6Amount);
            UpdateOrderBox();
        }

        private void btnMinus6_Click(object sender, EventArgs e)
        {
            //Decrements product 6
            Product6Amount -= 1;
            if (Product6Amount < 0)
            {
                Product6Amount = 0;
            }
            Product6quantity.Text = Convert.ToString(Product6Amount);
            UpdateOrderBox();
        }

        private void btnPlus7_Click(object sender, EventArgs e)
        {
            //Increments product 7
            Product7Amount += 1;
            Product7quantity.Text = Convert.ToString(Product7Amount);
            UpdateOrderBox();
        }

        private void btnMinus7_Click(object sender, EventArgs e)
        {
            //Decrements product 7
            Product7Amount -= 1;
            if (Product7Amount < 0)
            {
                Product7Amount = 0;
            }
            Product7quantity.Text = Convert.ToString(Product7Amount);
            UpdateOrderBox();
        }

        private void btnPlus8_Click(object sender, EventArgs e)
        {
            //Increments product 8
            Product8Amount += 1;
            Product8quantity.Text = Convert.ToString(Product8Amount);
            UpdateOrderBox();
        }

        private void btnMinus8_Click(object sender, EventArgs e)
        {
            //Decrements product 8
            Product8Amount -= 1;
            if (Product8Amount < 0)
            {
                Product8Amount = 0;
            }
            Product8quantity.Text = Convert.ToString(Product8Amount);
            UpdateOrderBox();
        }

        private void btnPlus9_Click(object sender, EventArgs e)
        {
            //Increments product 9
            Product9Amount += 1;
            Product9quantity.Text = Convert.ToString(Product9Amount);
            UpdateOrderBox();
        }

        private void btnMinus9_Click(object sender, EventArgs e)
        {
            //Decrements product 9
            Product9Amount -= 1;
            if (Product9Amount < 0)
            {
                Product9Amount = 0;
            }
            Product9quantity.Text = Convert.ToString(Product9Amount);
            UpdateOrderBox();
        }

        private void btnPlus10_Click(object sender, EventArgs e)
        {
            //Increments product 10
            Product10Amount += 1;
            Product10quantity.Text = Convert.ToString(Product10Amount);
            UpdateOrderBox();
        }

        private void btnMinus10_Click(object sender, EventArgs e)
        {
            //Decrements product 10
            Product10Amount -= 1;
            if (Product10Amount < 0)
            {
                Product10Amount = 0;
            }
            Product10quantity.Text = Convert.ToString(Product10Amount);
            UpdateOrderBox();
        }

        private void btnPlus11_Click(object sender, EventArgs e)
        {
            //Increments product 11
            Product11Amount += 1;
            Product11quantity.Text = Convert.ToString(Product11Amount);
            UpdateOrderBox();
        }

        private void btnMinus11_Click(object sender, EventArgs e)
        {
            //Decrements product 11
            Product11Amount -= 1;
            if (Product11Amount < 0)
            {
                Product11Amount = 0;
            }
            Product11quantity.Text = Convert.ToString(Product11Amount);
            UpdateOrderBox();
        }
        #endregion

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
            if (Product4Amount != 0)
            {
                Product4Total = Product4Amount * Product4Price;
                OrderInfoBox.Text += "Strawberry Milktea: x" + Product4Amount + "   Price: " + Product4Total + " \r\n";
            }
            if (Product5Amount != 0)
            {
                Product5Total = Product5Amount * Product5Price;
                OrderInfoBox.Text += "Taro Milktea: x" + Product5Amount + "   Price: " + Product5Total + " \r\n";
            }
            if (Product6Amount != 0)
            {
                Product6Total = Product6Amount * Product6Price;
                OrderInfoBox.Text += "Coffee Milktea: x" + Product6Amount + "   Price: " + Product6Total + " \r\n";
            }
            if(Product7Amount != 0)
            {
                Product7Total = Product7Amount * Product7Price;
                OrderInfoBox.Text += "Fries: x" + Product7Amount + "   Price: " + Product7Total + " \r\n";
            }
            if (Product8Amount != 0)
            {
                Product8Total = Product8Amount * Product8Price;
                OrderInfoBox.Text += "Burger: x" + Product8Amount + "   Price: " + Product8Total + " \r\n";
            }
            if (Product9Amount != 0)
            {
                Product9Total = Product9Amount * Product9Price;
                OrderInfoBox.Text += "Tacos: x" + Product9Amount + "   Price: " + Product9Total + " \r\n";
            }
            if (Product10Amount != 0)
            {
                Product10Total = Product10Amount * Product10Price;
                OrderInfoBox.Text += "Shawarma: x" + Product10Amount + "   Price: " + Product10Total + " \r\n";
            }
            if (Product11Amount != 0)
            {
                Product11Total = Product11Amount * Product11Price;
                OrderInfoBox.Text += "Pizza: x" + Product11Amount + "   Price: " + Product11Total + " \r\n";
            }
            //Here is where it will add up the products quantity and total
            ProductTotal = (Product1Total + Product2Total + Product3Total + Product4Total + Product5Total + Product6Total + Product7Total + Product8Total + Product9Total + Product10Total + Product11Total);
        }
        #endregion

        #region Clear  and Order Buttons
        // Displays the total amount of the orders
        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            TotalAmount.Text = "P " + ProductTotal;
        }
        // Clears the total amount of the order
        private void btnClear_Click(object sender, EventArgs e)
        {
            TotalAmount.Text = String.Empty;  
        }
        #endregion
    }
}
