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
    public partial class ReportCard : Form
    {
        public ReportCard()
        {
            InitializeComponent();
        }

        private void ReportCard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groceryDataSet24.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter3.Fill(this.groceryDataSet24.Product);
            // TODO: This line of code loads data into the 'groceryDataSet23.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter2.Fill(this.groceryDataSet23.Product);
            // TODO: This line of code loads data into the 'groceryDataSet22.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.groceryDataSet22.Product);
            // TODO: This line of code loads data into the 'groceryDataSet21.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.groceryDataSet21.Customer);
            // TODO: This line of code loads data into the 'groceryDataSet20.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groceryDataSet20.Customer);
            // TODO: This line of code loads data into the 'groceryDataSetRPCat.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.groceryDataSetRPCat.Category);
            // TODO: This line of code loads data into the 'groceryDataSetPRProduct.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.groceryDataSetPRProduct.Product);
            // TODO: This line of code loads data into the 'groceryDataSetPRCust.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.groceryDataSetPRCust.Customer);
            //dataGridViewproduct.Visible = false;
            // TODO: This line of code loads data into the 'groceryDataSetProd.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter2.Fill(this.groceryDataSetProd.Product);
            // TODO: This line of code loads data into the 'groceryDataSetSales.Invoice' table. You can move, or remove it, as needed.
            //this.invoiceTableAdapter.Fill(this.groceryDataSetSales.Invoice);
            // TODO: This line of code loads data into the 'groceryDataSetCat.Category' table. You can move, or remove it, as needed.
            //this.categoryTableAdapter.Fill(this.groceryDataSetCat.Category);
            // TODO: This line of code loads data into the 'groceryDataSetCustomer.Customer' table. You can move, or remove it, as needed.
            //this.customerTableAdapter.Fill(this.groceryDataSetCustomer.Customer);
            
            // TODO: This line of code loads data into the 'groceryDataSetProduct.Product' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'groceryDataSet17.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.groceryDataSet17.Product);

            // panel off
            p1.Visible = false;
            p3.Visible = false;
            p2.Visible = false;
            p4.Visible = false;
            p5.Visible = false;

            PStock.Visible = false;
            PRcustomer.Visible = false;
            PRproduct.Visible = false;
            PRCategory.Visible = false;
            PSales.Visible = false;
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            //dataGridViewproduct.Visible = true;
            PStock.Visible = false;
            PRCategory.Visible = false;
            PRcustomer.Visible = false;
            PRproduct.Visible = true;
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            //dataGridViewCust.Visible = true;
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            //dataGridViewCat.Visible = true;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
        //    dataGridViewSales.Visible = true;
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnproduct_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = true;
            p3.Visible = false;
            p2.Visible = false;
        }

        private void btncust_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p3.Visible = false;
            p2.Visible = true;
        }

        private void btnCat_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p2.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p3.Visible = true;
        }

        private void btnSales_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p3.Visible = false;
            p2.Visible = false;
        }

        private void p3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSales_Click_1(object sender, EventArgs e)
        {

        }

        private void btncust_Click_1(object sender, EventArgs e)
        {
            PStock.Visible = false;
            PRCategory.Visible = false;
            PRproduct.Visible = false;
            PSales.Visible = false;
            PRcustomer.Visible = true;
        }

        private void btnCat_Click_1(object sender, EventArgs e)
        {
            PStock.Visible = false;
            PRproduct.Visible = false;
            PRcustomer.Visible = false;
            PSales.Visible = false;
            PRCategory.Visible = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            PRproduct.Visible = false;
            PRcustomer.Visible = false;
            PRCategory.Visible = false;
            PSales.Visible = false;
            PStock.Visible = true;
        }

        private void btnSales_Click_2(object sender, EventArgs e)
        {
            PRproduct.Visible = false;
            PRcustomer.Visible = false;
            PRCategory.Visible = false;
            PStock.Visible = false;
            PSales.Visible = true;
        }

        private DataTable getTable()
        {
            DataTable tab = new DataTable();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            // insert data query
            //string sel = "select * from Invoice where Date='" + dateTimePickersales.Text + "'" + "' ORDER BY Price";

            SqlCommand cmd = new SqlCommand("select * from Invoice where Date='" + dateTimePickersales.Text + "' ORDER BY Price", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            tab.Load(dr);
            return tab;
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("selected date is : " + dateTimePickersales.Text);
            dataGridViewsales.DataSource = getTable();
        }

        private void btnStock_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p5.Visible = false;
            p4.Visible = true;
        }

        private void btnSales_MouseMove_1(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p2.Visible = false;
            p4.Visible = false;
            p3.Visible = false;
            p5.Visible = true;
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Window ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void picmax_Click(object sender, EventArgs e)
        {
            if (WindowState.ToString() == "Normal")
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
