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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        int id;
        int amount = 0;
        private void btninsert_Click(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblerrmsg.Visible = false;
            btnproducts.Enabled = false;
            btncat.Enabled = false;
            btnreports.Enabled = false;
            btninv.Enabled = false;
            btncust.Enabled = false;
            // TODO: This line of code loads data into the 'groceryDataSetNewCust.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter3.Fill(this.groceryDataSetNewCust.Customer);
            // TODO: This line of code loads data into the 'groceryDataSetProductCatCB.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.groceryDataSetProductCatCB.Category);
            // TODO: This line of code loads data into the 'groceryDataSetCBProductID.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.groceryDataSetCBProductID.Product);
            // TODO: This line of code loads data into the 'groceryDataSetInvCust.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.groceryDataSetInvCust.Customer);
            // TODO: This line of code loads data into the 'groceryDataSetInvPro.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.groceryDataSetInvPro.Product);
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            
            pinvoice.Visible = false;
            panelinvoice.Visible = false;
            lbldays.Visible = false;
            txtTotalAmount.Visible = false;
            txtinstock.Visible = false;
            lbldays.Visible = false;
            pcategory.Visible = false;
            pcustomer.Visible = false;
            pproduct.Visible = false;
            txtcnamecb.Enabled = false;
            lblcbid.Visible = false;
            lblcbname.Visible = false;
            comboBoxname.Visible = false;
            lblx.Visible = false;
            txtqty.Visible = false;
            txttotalweight.Visible = false;
            comboBoxdelete.Visible = false;
            label9.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtunit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpurc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsell_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnreports_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        /// <summary>
        /// login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlogin_Click(object sender, EventArgs e)
        {
            lblerrmsg.Visible = true;
 
            if (txtusername.Text == "admin" && txtpasswrd.Text == "admin")
            {
                lblerrmsg.Text = "     Logged In...!";
                btnproducts.Enabled = true;
                btncat.Enabled = true;
                btnreports.Enabled = true;
                btninv.Enabled = true;
                btncust.Enabled = true;
                txtusername.Clear();
                txtpasswrd.Clear();
            }
            else
            {
                lblerrmsg.Text = "Invalid username & password..!";
                txtpasswrd.Clear();
                txtusername.Clear();
            }

        }

        private void btninv_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void plogin_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            plogin.Visible = false;
            pproduct.Visible = false;
            pinvoice.Visible = false;
            pcategory.Visible = false;
            pcustomer.Visible = true;
        }

        /// <summary>
        /// customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnadd_Click(object sender, EventArgs e)
        {
            // sql database connection & open
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();

            // insert data query
            string insert = "insert into Customer values(@Name,@MobileNO,@EMail,@Address,@Gender)";

            // add values into table
            SqlCommand cmd = new SqlCommand(insert, cn);
            cmd.Parameters.AddWithValue("@Name", txtname.Text);
            cmd.Parameters.AddWithValue("@MobileNO", txtmobile.Text);
            cmd.Parameters.AddWithValue("@EMail", txtemail.Text);
            cmd.Parameters.AddWithValue("@Address", txtadd.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.SelectedItem);
            cmd.ExecuteNonQuery();

            // close connection
            cn.Close();

            // clear text
            txtname.Clear();
            txtmobile.Clear();
            txtadd.Clear();
            txtemail.Clear();
            comboBox1.SelectedText = "";

            // focus on name TextBox Name
            txtname.Focus();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            // sql database connection & open
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();

            // update data query
            string update = "update Customer set Name='" + txtname.Text + "',MobileNo='" + txtmobile.Text + "',EMail='" + txtemail.Text + "',Address='" + txtadd.Text
                            + "',Gender='" + comboBox1.SelectedItem + "'where ID='" + comboBox2.Text + "'";

            // update values from table
            SqlCommand cmd = new SqlCommand(update, cn);
            cmd.ExecuteNonQuery();

            // close connection
            cn.Close();

            // clear text
            txtname.Clear();
            txtmobile.Clear();
            txtemail.Clear();
            txtadd.Clear();
            comboBox2.Refresh();
            // focus on name TextBox Name
            txtname.Focus();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            // sql database connection & open
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();

            // delete data query
            string delet = "delete from Customer where ID='" + comboBox2.Text + "'";

            // delete values from table
            SqlCommand cmd = new SqlCommand(delet, cn);
            cmd.ExecuteNonQuery();

            // close connection
            cn.Close();

            // clear text
            txtname.Clear();
            txtmobile.Clear();
            txtemail.Clear();
            txtadd.Clear();
            comboBox2.Refresh();
            // focus on name TextBox Name
            txtname.Focus();
        }

        /// <summary>
        /// products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnproducts_Click(object sender, EventArgs e)
        {
            plogin.Visible = false;
            pcustomer.Visible = false;
            pinvoice.Visible = false;
            pcategory.Visible = false;
            pproduct.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            btnimgupd.Enabled = true;
            // sql database connection & open
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();

            // insert data query
            string insert = "insert into Product values(@Name,@Category,@Description,@SellPrice,@CostPrice,@Image,@Unit,@Quantity,@totalWeight,@ExpireDay)";

            int total;
            int qty = System.Convert.ToInt32(txtqty.Text);

            if (cbunit.Text == "Box(50 Item)")
            {
                total = 50 * qty;
                txttotalweight.Text = total.ToString();
            }
            else if (cbunit.Text == "Kattu(50 Kg)")
            {
                total = 50 * qty;
                txttotalweight.Text = total.ToString();
            }
            else if (cbunit.Text == "Dabba(15 ltr)")
            {
                total = 15 * qty;
                txttotalweight.Text = total.ToString();
            }
            else if (cbunit.Text == "Pouch(50 piece)")
            {
                total = 50 * qty;
                txttotalweight.Text = total.ToString();
            }
            // add values into table
            SqlCommand cmd = new SqlCommand(insert, cn);
            cmd.Parameters.AddWithValue("@Name", txtPname.Text);
            cmd.Parameters.AddWithValue("@Description", txtdesc.Text);
            cmd.Parameters.AddWithValue("@Category", cbcat.SelectedValue);
            cmd.Parameters.AddWithValue("@SellPrice", txtsell.Text);
            cmd.Parameters.AddWithValue("@CostPrice", txtpurc.Text);
            cmd.Parameters.AddWithValue("@Image", productimg.ImageLocation);
            cmd.Parameters.AddWithValue("@Unit", cbunit.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtqty.Text);
            cmd.Parameters.AddWithValue("@totalWeight", txttotalweight.Text);
            cmd.Parameters.AddWithValue("@ExpireDay", dtpexp.Text);
            cmd.ExecuteNonQuery();

            // close connection
            cn.Close();

            // clear text
            txtname.Clear();
            cbcat.Text = "";
            txtdesc.Clear();
            txtsell.Clear();
            txtpurc.Clear();
            txtPname.Clear();
            cbunit.Text = "";
            txtqty.Clear();
            txttotalweight.Clear();
            productimg.Refresh();
            cbcat.Text = "--select--";
            cbunit.Text = "--select--";
            dtpexp.Text = "";
            // focus on name TextBox Name
            txtname.Focus();
            MessageBox.Show("Added...");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // sql database connection & open
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();

            // update data query
            int total;
            int qty = System.Convert.ToInt32(txtqty.Text);

            if (cbunit.Text == "Box(50 Item)")
            {
                total = 50 * qty;
                txttotalweight.Text = total.ToString();
            }
            else if (cbunit.Text == "Kattu(50 Kg)")
            {
                total = 50 * qty;
                txttotalweight.Text = total.ToString();
            }
            else if (cbunit.Text == "Dabba(15 ltr)")
            {
                total = 15 * qty;
                txttotalweight.Text = total.ToString();
            }
            else if (cbunit.Text == "Pouch(50 piece)")
            {
                total = 50 * qty;
                txttotalweight.Text = total.ToString();
            }

            string update = "update Product set Name='" + txtPname.Text + "',Category='" + cbcat.SelectedValue + "',Description='" + txtdesc.Text + "',SellPrice='" + txtsell.Text
                            + "',CostPrice='" + txtpurc.Text + "',Image='" + productimg.Location + "',Unit='" + cbunit.Text + "',Quantity='" + txtqty.Text
                            + "',totalWeight='" + txttotalweight.Text + "',ExpireDay='" + dtpexp.Text + "'where ID='" + comboBoxdelete.Text + "'";

            // update values from table
            SqlCommand cmd = new SqlCommand(update, cn);
            cmd.ExecuteNonQuery();

            // close connection
            cn.Close();

            // clear text
            txtPname.Text = "";
            cbcat.Text = "";
            txtdesc.Clear();
            txtsell.Clear();
            txtpurc.Clear();
            cbunit.Text = "";
            txtqty.Clear();
            txttotalweight.Clear();
            productimg.ResetText();
            cbcat.Text = "--select--";
            cbunit.Text = "--select--";
            dtpexp.Text = "";
            // focus on name TextBox Name
            txtname.Focus();
            MessageBox.Show("Updated...");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // sql database connection & open
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();

            // delete data query
            string delet = "delete from Product where ID='" + comboBoxdelete.Text + "'";

            // delete values from table
            SqlCommand cmd = new SqlCommand(delet, cn);
            cmd.ExecuteNonQuery();

            // close connection
            cn.Close();

            // clear text
            comboBoxdelete.Text = "";
            comboBoxname.Text = "";
            // focus on name TextBox Name
            txtname.Focus();
            MessageBox.Show("Your Product is deleted successfully");
        }
        private void comboBoxname_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxname.Visible = true;
        }

        private void cbunit_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblx.Visible = true;
            txtqty.Visible = true;
        }

        private void btnupdate_MouseMove(object sender, MouseEventArgs e)
        {
            btnadd.Enabled = false;
            btnremove.Enabled = false;
            comboBoxdelete.Visible = true;
            label9.Visible = true;
        }

        private void btnremove_MouseMove(object sender, MouseEventArgs e)
        {
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            comboBoxdelete.Visible = true;
            label9.Visible = true;
            comboBoxdelete.Focus();
            // clear text
            txtname.Enabled = false;
            cbcat.Enabled = false;
            txtdesc.Enabled = false;
            txtsell.Enabled = false;
            txtpurc.Enabled = false;
            cbunit.Enabled = false;
            txtqty.Enabled = false;
            txttotalweight.Enabled = false;
            btnimgupd.Enabled = false;
            cbcat.Enabled = false;
            cbunit.Enabled = false;
            dtpexp.Enabled = false;
        }
        private void btnadd_MouseMove(object sender, MouseEventArgs e)
        {
            btnupdate.Enabled = false;
            btnremove.Enabled = false;
        }

        private void btnimgupd_Click(object sender, EventArgs e)
        {
         
        }

        private void btnreports_Click_1(object sender, EventArgs e)
        {
            ReportCard rc = new ReportCard();
            rc.Show();
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            plogin.Visible = false;
            pcustomer.Visible = false;
            pproduct.Visible = false;
            pinvoice.Visible = false;
            pcategory.Visible = true;
        }

        private void btnaddcat_Click(object sender, EventArgs e)
        {
            // sql database connection & open
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();

            // insert data query
            string insert = "insert into Category values(@Category)";

            // add values into table
            SqlCommand cmd = new SqlCommand(insert, cn);
            cmd.Parameters.AddWithValue("@Category", txtaddCat.Text);
            cmd.ExecuteNonQuery();

            // close connection
            cn.Close();

            // clear text
            txtaddCat.Clear();

            // focus on name TextBox Name
            txtaddCat.Focus();
            MessageBox.Show("Added...!");
        }

        private void btninv_Click_1(object sender, EventArgs e)
        {
            plogin.Visible = false;
            pproduct.Visible = false;
            pcustomer.Visible = false;
            pcategory.Visible = false;
            pinvoice.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
           
        }
        private DataTable get()
        {
            DataTable tab = new DataTable();
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            DateTime d = DateTime.Now;
            string dates = d.ToString("MM/dd/yyyy").ToString();
            // insert data query
            //string sel = "select ProductID,ProductName,Price,Quantity,TotalPrice from Invoice where CustID='" + System.Convert.ToInt32(comboBox2.Text) + "'" + "' ORDER BY Price";

            SqlCommand cmd = new SqlCommand("select ProductID,ProductName,Price,Quantity,TotalPrice from Invoice where CustID='" + System.Convert.ToInt32(txtICID.Text) + "' and Date='" + dateTimePicker1.Text + "' ORDER BY Price", cn);
            SqlDataReader dr = cmd.ExecuteReader();

            tab.Load(dr);
            return tab;
        }
        private void comboBox1_MouseMove(object sender, MouseEventArgs e)
        {
            lblmsg.Text = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxpayterm_MouseMove(object sender ,MouseEventArgs e)
        {
            lbldays.Visible = true;
        }

        private void comboBox3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnreports_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p4.Visible = false;
            p5.Visible = true;
        }

        private void btninv_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p5.Visible = false;
            p4.Visible = true;
        }

        private void btncat_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p2.Visible = false;
            p4.Visible = false;
            p5.Visible = false;
            p3.Visible = true;
        }

        private void btncust_MouseMove(object sender, MouseEventArgs e)
        {
            p1.Visible = false;
            p4.Visible = false;
            p3.Visible = false;
            p5.Visible = false;
            p2.Visible = true;
        }

        private void btnproducts_MouseMove(object sender, MouseEventArgs e)
        {
            p4.Visible = false;
            p2.Visible = false;
            p3.Visible = false;
            p5.Visible = false;
            p1.Visible = true;
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            lblidate.Text = dateTimePicker1.Text;
            lblipayterm.Text = comboBoxpayterm.Text;
            lblcid.Text = comboBox2.Text;
            lblcname.Text = txtcname.Text;
            lblcmob.Text = txtmob.Text;
            lblcadd.Text = txtcadd.Text;
            lbltamt.Text = amount.ToString();
            pprocon.Visible = false;
            panelinvoice.Visible = true;
            dataGridViewInvoice.DataSource = get();
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            // sql database connection & open
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();

            // insert data query
            string insert = "insert into Invoice values(@Date,@PayTerm,@ProductID,@ProductName,@ProductDesc,@Price,@Quantity,@Stock,@Image,@TotalPrice,@CustID,@CustName,@Address,@MobileNo,@DeliveryType)";

            // check expire date
            DateTime d = DateTime.Now;
            d.ToString("MM/dd/yyyy");

            if (txtIPExp.Text == d.ToString("dd MMMMM yyyy"))// (String.Format("{0:ddd, MMM d, yyyy}", dt) + "</br>");//output- Thu, Jan 16, 2014
            {
                MessageBox.Show("Your selected Product is going to expire today...!");
            }

            // check stock in it or not
            int qty = System.Convert.ToInt32(txtIPQty.Text);
            int stock = System.Convert.ToInt32(txtinstock.Text);
            if (qty > stock)
            {
                MessageBox.Show("No In Stock...!" + d.ToString("dd MMMMM yyyy"));
                this.Close();
            }
            else
            {
                double price = System.Convert.ToDouble(txtIPPrice.Text);
                int quant = System.Convert.ToInt32(txtIPQty.Text);

                double totalPrice = (price * quant);

                txttotal.Text = totalPrice.ToString();
                amount += System.Convert.ToInt32(txttotal.Text);

                int newQty = System.Convert.ToInt32(txtinstock.Text) - System.Convert.ToInt32(txtIPQty.Text);
                string upd = "update Product set TotalWeight='" + newQty + "'where ID='" + id + "'";
                SqlCommand cmd2 = new SqlCommand(upd, cn);
                cmd2.ExecuteNonQuery();

                // add values into table
                SqlCommand cmd = new SqlCommand(insert, cn);
                cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@PayTerm", comboBoxpayterm.Text);
                cmd.Parameters.AddWithValue("@ProductID", comboBoxIPID.Text);
                cmd.Parameters.AddWithValue("@ProductName", txtIPName.Text);
                cmd.Parameters.AddWithValue("@ProductDesc", txtIPDesc.Text);
                cmd.Parameters.AddWithValue("@Price", txtIPPrice.Text);
                cmd.Parameters.AddWithValue("@Quantity", txtIPQty.Text);
                cmd.Parameters.AddWithValue("@Stock", txtinstock.Text);
                cmd.Parameters.AddWithValue("@Image", pictureBoximg.ImageLocation);
                cmd.Parameters.AddWithValue("@TotalPrice", txttotal.Text);
                cmd.Parameters.AddWithValue("@CustID", txtICID.Text);
                cmd.Parameters.AddWithValue("@CustName", txtcname.Text);
                cmd.Parameters.AddWithValue("@Address", txtcadd.Text);
                cmd.Parameters.AddWithValue("@MobileNo", txtmob.Text);
                cmd.Parameters.AddWithValue("@DeliveryType", ckDelivery.Checked);
                cmd.ExecuteNonQuery();

                // close connection
                cn.Close();

                // clear text
                dateTimePicker1.Enabled = false;
                comboBox1.Refresh();
                txtIPName.Text = "";
                txtIPDesc.Text = "";
                txtIPPrice.Text = "";
                txtIPQty.Text = "";
                txtinstock.Text = "";
                txtIPExp.Text = "";
                pictureBoximg.Refresh();
                lblmsg.Text = "Added Successfully...!";
                txttotal.Text = "";
                txtICID.Enabled = false;
                comboBox2.Enabled = false;
                txtcname.Enabled = false;
                txtcadd.Enabled = false;
                txtmob.Enabled = false;
                comboBoxpayterm.Enabled = false;
                ckDelivery.Enabled = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Product where ID ='" + comboBoxIPID.Text + "'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader rd;
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                id = System.Convert.ToInt32(rd["ID"].ToString());
                txtIPName.Text = (string)rd["Name"].ToString();
                txtIPDesc.Text = (string)rd["Description"].ToString();
                txtIPPrice.Text = (string)rd["CostPrice"].ToString();
                txtinstock.Text = (string)(rd["TotalWeight"].ToString());
                string img = (string)(rd["Image"].ToString());
                pictureBoximg.ImageLocation = img.ToString();
                txtIPExp.Text = (string)rd["ExpireDay"].ToString();
            }
        }

        private void txtICID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=D:\\MCA\\GroceryShop\\GroceryShop\\Grocery.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Customer where ID ='" + txtICID.Text + "'", cn);
            cmd.ExecuteNonQuery();
            SqlDataReader rd;
            rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string name = (string)rd["Name"].ToString();
                txtcname.Text = name;
                string add = (string)rd["Address"].ToString();
                txtcadd.Text = add;
                txtmob.Text = (string)rd["MobileNo"].ToString();
            }
        }

        private void cbunit_MouseMove(object sender, MouseEventArgs e)
        {
            lblx.Visible = true;
            txtqty.Visible = true;
        }

        private void btnimgupd_Click_1(object sender, EventArgs e)
        {
            string imglocation = "";
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imglocation = dialog.FileName;
                productimg.ImageLocation = imglocation;
            }
            MessageBox.Show("file uploaded successfully...!");
            btnimgupd.Enabled = false;
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            lblcbid.Visible = true;
            comboBoxdelete.Visible = true;
            lblcname.Visible = true;
            comboBoxname.Visible = true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            lblcbid.Visible = true;
            comboBoxdelete.Visible = true;
            lblcname.Visible = true;
            comboBoxname.Visible = true;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            lblcbid.Visible = false;
            comboBoxdelete.Visible = false;
            lblcname.Visible = false;
            comboBoxname.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpasswrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            piclogin.ImageLocation = "D:\\MCA\\GroceryShop\\GroceryShop\\Images\\Login\\images (1).jpg";
        }

        private void btnlogin_MouseMove(object sender, MouseEventArgs e)
        {
            piclogin.ImageLocation = "D:\\MCA\\GroceryShop\\GroceryShop\\Images\\Login\\openeye.png";
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            piclogin.ImageLocation = "D:\\MCA\\GroceryShop\\GroceryShop\\Images\\Login\\openeye.png";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
