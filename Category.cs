using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GroceryShop
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }
        
            

        private void Category_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDataSet5.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter1.Fill(this.groceryDataSet5.Product);
            // TODO: This line of code loads data into the 'groceryDataSet4.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.groceryDataSet4.Product);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtaddCat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
