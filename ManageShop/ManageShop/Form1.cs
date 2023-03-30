namespace ManageShop
{
    public partial class Form1 : Form
    {
        ShopContext context = new ShopContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
          var em = (from a in context.Employees
                   where a.Email == tbEmail.Text && a.Password == tbPass.Text
                   select new {
                    a
                   }
                   ).FirstOrDefault();

            if (em == null)
            {
                MessageBox.Show("Email or Password isnt correct !!!");
            }
            else if (em.a.Role == 1 && em.a.Status == 1)
            {
                Employee abc = new Employee
                {
                    Role = 1,
                    Address = em.a.Address,
                    Email = tbEmail.Text,
                    Password = tbPass.Text,
                    Name = em.a.Name,
                    Status = em.a.Status,
                    EmployeeId = em.a.EmployeeId

                };
                this.Hide();
                ManageShop m = new ManageShop()
                {
                    em = abc



                };
                m.ShowDialog();
                this.Show();

            }
            else if (em.a.Role == 2) {
                Admin ad = new Admin();
                this.Hide();
                ad.ShowDialog();
                this.Show();

            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure to close this system?", "Mess", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}