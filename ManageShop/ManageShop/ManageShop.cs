using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ManageShop
{
    public partial class ManageShop : Form
    {
        ShopContext context = new ShopContext();
        List<CartDetails> cart = new List<CartDetails>();
        public Employee em { get; set; }
       
        public ManageShop()
            
        {
           
            InitializeComponent();
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

   

        private void ManageShop_Load(object sender, EventArgs e)
        {

            productLoad();
            billLoad();
            cusLoad();

        }

        public void productLoad() {

            var p = context.Products.ToList();
            dgvProduct.DataSource = p;
            

        }
        public void billLoad() {
            var bill = context.Bills.ToList();
            dgvBill.DataSource = bill;
            dgvBill.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        public void cusLoad() {
            var cus = context.Customers.ToList();
            dgvCustomers.DataSource = cus;

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow x = dgvProduct.Rows[e.RowIndex];
                tbProductID.Text = x.Cells[0].Value.ToString();
                tbProductName.Text = x.Cells[1].Value.ToString();
                tbChip.Text = x.Cells[2].Value.ToString();
                tbOperating.Text = x.Cells[3].Value.ToString();
                tbScreen.Text = x.Cells[4].Value.ToString();
                tbPrice.Text = x.Cells[5].Value.ToString();
            }
            catch (Exception x) {
                MessageBox.Show("Something wrong !!!");
            }
        }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbProductID.Text);
            Product p = context.Products.SingleOrDefault(p => p.ProductId == id);
            context.Entry(p).State = EntityState.Detached;
            p = new Product()
            {
                Chip = tbChip.Text,
                OperatingSystem = tbOperating.Text,
                PhoneScreen = tbScreen.Text,
                Price = float.Parse(tbPrice.Text),
                ProductId = id,
                ProductName = tbProductName.Text
                    
            };
            context.Products.Update(p);
            context.SaveChanges();
            productLoad();
        }

        private void btCreateProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                Chip = tbChip.Text,
                OperatingSystem = tbOperating.Text,
                PhoneScreen = tbScreen.Text,
                Price = float.Parse(tbPrice.Text),
               
                ProductName = tbProductName.Text

            };
            context.Products.Add(p);
            context.SaveChanges();
            productLoad();
        }




        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbProductID.Text);
                Product p = context.Products.SingleOrDefault(p => p.ProductId == id);
                context.Entry(p).State = EntityState.Detached;
                p = new Product()
                {
                    Chip = tbChip.Text,
                    OperatingSystem = tbOperating.Text,
                    PhoneScreen = tbScreen.Text,
                    Price = float.Parse(tbPrice.Text),
                    ProductId = id,
                    ProductName = tbProductName.Text

                };
                context.Products.Remove(p);
                context.SaveChanges();
                productLoad();
            }
            catch (Exception ex) {
                MessageBox.Show("Can't delete this product");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow bd = dgvBill.Rows[e.RowIndex];
            int idBill = int.Parse((bd.Cells[0].Value.ToString()));
            var billDetail = (from a in context.BillDetails
                              join c in context.Products
                              on a.ProductId equals c.ProductId
                              where a.BillId == idBill
                              select new
                              {
                                  a.BillDetailId,
                                  a.BillId,
                                  c.ProductName,
                                  a.Quantity,
                                  Price = a.Quantity * c.Price
                              }
                   ).ToList();
            dgvBillDetails.DataSource = billDetail;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btAddCart_Click(object sender, EventArgs e)
        {
            try
            {
                
                foreach (CartDetails item in cart)
                {
                    if ((Int32) nupProductID.Value ==  item.ProductID) {
                        item.Quantity = item.Quantity + Int32.Parse(nupQuantity.Value.ToString());
                        item.Price = item.Price + (item.Price / item.Quantity) * int.Parse(nupQuantity.Value.ToString());
                        dgvCart.DataSource = null;
                        dgvCart.DataSource = cart;
                        return;
                    }

                }
                
                    var p = (from c in context.Products

                             where c.ProductId == Int32.Parse(nupProductID.Value.ToString())
                             select new
                             {
                                 c.Price,
                                 c.ProductName,
                                 c.ProductId

                             }).FirstOrDefault();

                    CartDetails cartDetail = new CartDetails()
                    {
                        ProductName = p.ProductName,
                        Quantity = Int32.Parse(nupQuantity.Value.ToString()),
                        Price = (float)p.Price * int.Parse(nupQuantity.Value.ToString()),
                        ProductID = p.ProductId
                    };
                    cart.Add(cartDetail);
                    dgvCart.DataSource = null;
                    dgvCart.DataSource = cart;
                
                
            }
            catch (Exception x) {
                MessageBox.Show("Something wrong !!!");
            }


        }

        private void btStartDate_Click(object sender, EventArgs e)
        {
            DateTime time = dtpStartDate.Value;
            var bill = (from a in context.Bills
                        where a.Time >= time
                        select new
                        {
                            a.BillId,
                            a.CustomerId,
                            a.EmployeeId,
                            a.Time
                        }).ToList();
           
            dgvBill.DataSource = null;
            dgvBill.DataSource = bill;
            dgvBill.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void btCreateBill_Click(object sender, EventArgs e)
        {
            var c = (from a in context.Customers

                     where a.CustomerId == Int32.Parse(nupCustomerID.Value.ToString())
                     select new
                     {
                            a

                     }).FirstOrDefault();
            if (c == null)
            {
                MessageBox.Show("The Customer does not exist");
            }
            else if (cart.FirstOrDefault() == null)
            {
                MessageBox.Show("Cart is empty, please add to cart before create bill");
            }
            else {
                Bill b = new Bill() {
                    CustomerId = Int32.Parse(nupCustomerID.Value.ToString()),
                    EmployeeId = em.EmployeeId,
                    
                };
                context.Bills.Add(b);
                context.SaveChanges();
                var listB = context.Bills.OrderBy(b => b.BillId).LastOrDefault();
                int bId = listB.BillId;
                foreach (CartDetails item in cart)
                {
                    BillDetail billDetail = new BillDetail()
                    {
                        ProductId = item.ProductID,
                        Quantity = item.Quantity,
                        BillId = bId
                    };
                    context.BillDetails.Add(billDetail);
                    context.SaveChanges();

                }
                c.a.AmountBuy = c.a.AmountBuy + 1;

                billLoad();

            }
        }

        private void nupCustomerID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            cart = null;
            nupProductID.Value = 0;
            nupQuantity.Value = 0;
            dgvCart.DataSource = null;
            dgvCart.DataSource = cart;

        }

        private void btEditCart_Click(object sender, EventArgs e)
        {
            foreach (CartDetails item in cart)
            {
                if (item.ProductID == (Int32)nupProductID.Value) {
                    item.Price = (item.Price / item.Quantity) * (Int32)nupQuantity.Value;
                    item.Quantity = (Int32) nupQuantity.Value;
                    
                }
                dgvCart.DataSource = null;
                dgvCart.DataSource = cart;
            }
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow c = dgvCart.Rows[e.RowIndex];
            nupProductID.Value = (Int32) c.Cells[1].Value;
            nupQuantity.Value = (Int32) c.Cells[2].Value;

        }

        private void btDeleteCart_Click(object sender, EventArgs e)
        {
            for (int i = cart.Count - 1; i >= 0; i--)
            {
                CartDetails item = cart[i];
                if (item.ProductID == (Int32)nupProductID.Value)
                {
                    cart.RemoveAt(i);
                }
            }
            dgvCart.DataSource = null;
            dgvCart.DataSource = cart;
        }

        private void btSearchProduct_Click(object sender, EventArgs e)
        {
            
            var product = (from a in context.Products
                           where a.ProductName.Contains(tbSearchProduct.Text)
                           select new
                           {
                               a.ProductId,
                               a.ProductName,
                               a.Chip,
                               a.OperatingSystem,
                               a.PhoneScreen,
                               a.Price
                           }).ToList();

            dgvProduct.DataSource = null;
            dgvProduct.DataSource = product;
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow x = dgvCustomers.Rows[e.RowIndex];
                tbCustomerID.Text = x.Cells[0].Value.ToString();
                tbCustomerName.Text= x.Cells[1].Value.ToString();
                tbCustomerAddress.Text= x.Cells[2].Value.ToString();
                nupAmountBuy.Value = (Int32) x.Cells[3].Value;
                tbPhone.Text = x.Cells[0].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show("Something wrong !!!");
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbPhone.Text);
                Customer cus = new Customer
                {
                    CustomerId = id,
                    Address = tbCustomerAddress.Text,
                    AmountBuy = (Int32)nupAmountBuy.Value,
                    Name = tbCustomerName.Text

                };
                context.Customers.Add(cus);
                context.SaveChanges();
                cusLoad();
            }
            catch (Exception ex) {
                MessageBox.Show("This customer existed!!!");
            }
        }

        private void btEditCustomer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tbCustomerID.Text);
            Customer cus_ = context.Customers.SingleOrDefault(p => p.CustomerId == id);
            context.Entry(cus_).State = EntityState.Detached;
            Customer cus = new Customer
            {
                CustomerId = id,
                Address = tbCustomerAddress.Text,
                AmountBuy = (Int32)nupAmountBuy.Value,
                Name = tbCustomerName.Text

            };
            context.Customers.Update(cus);
            context.SaveChanges();
            cusLoad();
        }

        private void btDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbCustomerID.Text);
                Customer cus_ = context.Customers.SingleOrDefault(p => p.CustomerId == id);
                context.Entry(cus_).State = EntityState.Detached;
                Customer cus = new Customer
                {
                    CustomerId = id,
                    Address = tbCustomerAddress.Text,
                    AmountBuy = (Int32)nupAmountBuy.Value,
                    Name = tbCustomerName.Text

                };
                context.Customers.Remove(cus);
                context.SaveChanges();
                cusLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cant delete this Customer");

            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
