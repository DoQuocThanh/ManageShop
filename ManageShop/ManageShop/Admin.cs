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

namespace ManageShop
{
    public partial class Admin : Form
    {
        ShopContext context = new ShopContext();  
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            adminLoad();

        }

        public void adminLoad() {
            var ad = (from a in context.Employees
                      where a.Role == 1
                      select new
                      {
                          a.EmployeeId,
                          a.Name,
                          a.Email,
                          a.Password,
                          a.Address,
                          a.Status

                      }).ToList();
           
            dgvAdmin.DataSource = ad;


        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow x = dgvAdmin.Rows[e.RowIndex];
                tbEmployeeName.Text = x.Cells[1].Value.ToString();
                tbEmployeeAdress.Text = x.Cells[4].Value.ToString();
                tbEmail.Text = x.Cells[2].Value.ToString();
                tbPassword.Text = x.Cells[3].Value.ToString();
                tbEmployeeID.Text = x.Cells[0].Value.ToString();
                if (x.Cells[5].Value.ToString() == "1") {
                    rbActive.Checked = true;

                }
                else
                {
                    rbBaned.Checked = true;
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Something wrong !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var ad = (from a in context.Employees
                          where a.Role == 1 && a.Email == tbEmail.Text
                          select new
                          {
                              a.EmployeeId,
                              a.Name,
                              a.Email,
                              a.Password,
                              a.Address,
                              a.Status

                          }).ToList();
                if (ad.Count!=0) {
                    throw new Exception();
                }
                Employee em = new Employee() { 
                    Email= tbEmail.Text,
                    Address = tbEmployeeAdress.Text,
                    
                    Name=tbEmployeeName.Text,
                    Password=tbPassword.Text,
                    Status  = 1,
                    Role = 1
                };
                context.Employees.Add(em);
                context.SaveChanges();
                adminLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbEmployeeID.Text);
                Employee em_ = context.Employees.SingleOrDefault(p => p.EmployeeId == id);

                var ad = (from a in context.Employees
                          where a.Role == 1 && a.Email != em_.Email
                          select new
                          {
                              a.EmployeeId,
                              a.Name,
                              a.Email,
                              a.Password,
                              a.Address,
                              a.Status

                          }).ToList();


                foreach (var item in ad)
                {
                    if (item.Email == tbEmail.Text)
                    {
                        throw new Exception();
                    }
                }

                
                int status = 0;
                if (rbActive.Checked)
                {
                    status = 1;
                }
                else {
                    status = 2;
                }
                
                context.Entry(em_).State = EntityState.Detached;
                Employee em = new Employee()
                {
                    Email = tbEmail.Text,
                    Address = tbEmployeeAdress.Text,
                    EmployeeId = id,
                    Name = tbEmployeeName.Text,
                    Password = tbPassword.Text,
                    Status = status,
                    Role = 1
                };
                context.Employees.Update(em);
                context.SaveChanges();
                adminLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This email has existed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tbEmployeeID.Text);
                Employee em_ = context.Employees.SingleOrDefault(p => p.EmployeeId == id);
                context.Entry(em_).State = EntityState.Detached;
                Employee em = new Employee()
                {
                    Email = tbEmail.Text,
                    Address = tbEmployeeAdress.Text,
                    EmployeeId= id,
                    Name = tbEmployeeName.Text,
                    Password = tbPassword.Text,
                    Status = 1,
                    Role = 1
                };
                context.Employees.Remove(em);
                context.SaveChanges();
                adminLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong!!!");
            }
        }
    }
}
