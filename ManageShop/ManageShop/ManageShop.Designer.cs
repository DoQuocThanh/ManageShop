namespace ManageShop
{
    partial class ManageShop
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbChip = new System.Windows.Forms.TextBox();
            this.tbOperating = new System.Windows.Forms.TextBox();
            this.tbScreen = new System.Windows.Forms.TextBox();
            this.btDeleteProduct = new System.Windows.Forms.Button();
            this.btCreateProduct = new System.Windows.Forms.Button();
            this.btEditProduct = new System.Windows.Forms.Button();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btSearchProduct = new System.Windows.Forms.Button();
            this.tbSearchProduct = new System.Windows.Forms.TextBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.nupCustomerID = new System.Windows.Forms.NumericUpDown();
            this.nupProductID = new System.Windows.Forms.NumericUpDown();
            this.nupQuantity = new System.Windows.Forms.NumericUpDown();
            this.btCreateBill = new System.Windows.Forms.Button();
            this.btDeleteCart = new System.Windows.Forms.Button();
            this.btEditCart = new System.Windows.Forms.Button();
            this.btAddCart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btStartDate = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.label21 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbCustomerID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.btDeleteCustomer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btEditCustomer = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.nupAmountBuy = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmountBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 678);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 645);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Linen;
            this.panel6.Controls.Add(this.tbProductID);
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.tbPrice);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.tbChip);
            this.panel6.Controls.Add(this.tbOperating);
            this.panel6.Controls.Add(this.tbScreen);
            this.panel6.Controls.Add(this.btDeleteProduct);
            this.panel6.Controls.Add(this.btCreateProduct);
            this.panel6.Controls.Add(this.btEditProduct);
            this.panel6.Controls.Add(this.tbProductName);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(628, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(476, 616);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // tbProductID
            // 
            this.tbProductID.Location = new System.Drawing.Point(206, 62);
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.ReadOnly = true;
            this.tbProductID.Size = new System.Drawing.Size(237, 27);
            this.tbProductID.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(59, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 20);
            this.label18.TabIndex = 24;
            this.label18.Text = "ProductID";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(206, 355);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(237, 27);
            this.tbPrice.TabIndex = 23;
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "ProductDetail";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Chip";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "OperatingSystem";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "PhoneScreen";
            // 
            // tbChip
            // 
            this.tbChip.Location = new System.Drawing.Point(206, 180);
            this.tbChip.Name = "tbChip";
            this.tbChip.Size = new System.Drawing.Size(237, 27);
            this.tbChip.TabIndex = 19;
            // 
            // tbOperating
            // 
            this.tbOperating.Location = new System.Drawing.Point(206, 233);
            this.tbOperating.Name = "tbOperating";
            this.tbOperating.Size = new System.Drawing.Size(237, 27);
            this.tbOperating.TabIndex = 18;
            // 
            // tbScreen
            // 
            this.tbScreen.Location = new System.Drawing.Point(206, 296);
            this.tbScreen.Name = "tbScreen";
            this.tbScreen.Size = new System.Drawing.Size(237, 27);
            this.tbScreen.TabIndex = 16;
            // 
            // btDeleteProduct
            // 
            this.btDeleteProduct.Location = new System.Drawing.Point(349, 463);
            this.btDeleteProduct.Name = "btDeleteProduct";
            this.btDeleteProduct.Size = new System.Drawing.Size(94, 29);
            this.btDeleteProduct.TabIndex = 15;
            this.btDeleteProduct.Text = "Delete";
            this.btDeleteProduct.UseVisualStyleBackColor = true;
            this.btDeleteProduct.Click += new System.EventHandler(this.btDeleteProduct_Click);
            // 
            // btCreateProduct
            // 
            this.btCreateProduct.Location = new System.Drawing.Point(206, 463);
            this.btCreateProduct.Name = "btCreateProduct";
            this.btCreateProduct.Size = new System.Drawing.Size(94, 29);
            this.btCreateProduct.TabIndex = 14;
            this.btCreateProduct.Text = "Create";
            this.btCreateProduct.UseVisualStyleBackColor = true;
            this.btCreateProduct.Click += new System.EventHandler(this.btCreateProduct_Click);
            // 
            // btEditProduct
            // 
            this.btEditProduct.Location = new System.Drawing.Point(59, 463);
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(94, 29);
            this.btEditProduct.TabIndex = 13;
            this.btEditProduct.Text = "Edit";
            this.btEditProduct.UseVisualStyleBackColor = true;
            this.btEditProduct.Click += new System.EventHandler(this.btEditProduct_Click);
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(206, 122);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(237, 27);
            this.tbProductName.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "ProductName";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel5.Controls.Add(this.btSearchProduct);
            this.panel5.Controls.Add(this.tbSearchProduct);
            this.panel5.Controls.Add(this.dgvProduct);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(-16, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(668, 613);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btSearchProduct
            // 
            this.btSearchProduct.BackColor = System.Drawing.Color.Tomato;
            this.btSearchProduct.Location = new System.Drawing.Point(330, 22);
            this.btSearchProduct.Name = "btSearchProduct";
            this.btSearchProduct.Size = new System.Drawing.Size(94, 29);
            this.btSearchProduct.TabIndex = 3;
            this.btSearchProduct.Text = "Search";
            this.btSearchProduct.UseVisualStyleBackColor = false;
            this.btSearchProduct.Click += new System.EventHandler(this.btSearchProduct_Click);
            // 
            // tbSearchProduct
            // 
            this.tbSearchProduct.Location = new System.Drawing.Point(441, 22);
            this.tbSearchProduct.Name = "tbSearchProduct";
            this.tbSearchProduct.Size = new System.Drawing.Size(197, 27);
            this.tbSearchProduct.TabIndex = 2;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(22, 55);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(616, 555);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(22, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Products";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btRefresh);
            this.panel2.Controls.Add(this.nupCustomerID);
            this.panel2.Controls.Add(this.nupProductID);
            this.panel2.Controls.Add(this.nupQuantity);
            this.panel2.Controls.Add(this.btCreateBill);
            this.panel2.Controls.Add(this.btDeleteCart);
            this.panel2.Controls.Add(this.btEditCart);
            this.panel2.Controls.Add(this.btAddCart);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvCart);
            this.panel2.Location = new System.Drawing.Point(565, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 649);
            this.panel2.TabIndex = 4;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(385, 523);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(134, 29);
            this.btRefresh.TabIndex = 16;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // nupCustomerID
            // 
            this.nupCustomerID.Location = new System.Drawing.Point(190, 477);
            this.nupCustomerID.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nupCustomerID.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupCustomerID.Name = "nupCustomerID";
            this.nupCustomerID.Size = new System.Drawing.Size(327, 27);
            this.nupCustomerID.TabIndex = 15;
            this.nupCustomerID.Value = new decimal(new int[] {
            374827187,
            0,
            0,
            0});
            this.nupCustomerID.ValueChanged += new System.EventHandler(this.nupCustomerID_ValueChanged);
            // 
            // nupProductID
            // 
            this.nupProductID.Location = new System.Drawing.Point(190, 44);
            this.nupProductID.Name = "nupProductID";
            this.nupProductID.Size = new System.Drawing.Size(327, 27);
            this.nupProductID.TabIndex = 14;
            // 
            // nupQuantity
            // 
            this.nupQuantity.Location = new System.Drawing.Point(190, 99);
            this.nupQuantity.Name = "nupQuantity";
            this.nupQuantity.Size = new System.Drawing.Size(327, 27);
            this.nupQuantity.TabIndex = 13;
            // 
            // btCreateBill
            // 
            this.btCreateBill.Location = new System.Drawing.Point(188, 523);
            this.btCreateBill.Name = "btCreateBill";
            this.btCreateBill.Size = new System.Drawing.Size(147, 29);
            this.btCreateBill.TabIndex = 12;
            this.btCreateBill.Text = "Create Bill";
            this.btCreateBill.UseVisualStyleBackColor = true;
            this.btCreateBill.Click += new System.EventHandler(this.btCreateBill_Click);
            // 
            // btDeleteCart
            // 
            this.btDeleteCart.Location = new System.Drawing.Point(425, 154);
            this.btDeleteCart.Name = "btDeleteCart";
            this.btDeleteCart.Size = new System.Drawing.Size(94, 29);
            this.btDeleteCart.TabIndex = 11;
            this.btDeleteCart.Text = "Delete";
            this.btDeleteCart.UseVisualStyleBackColor = true;
            this.btDeleteCart.Click += new System.EventHandler(this.btDeleteCart_Click);
            // 
            // btEditCart
            // 
            this.btEditCart.Location = new System.Drawing.Point(310, 154);
            this.btEditCart.Name = "btEditCart";
            this.btEditCart.Size = new System.Drawing.Size(94, 29);
            this.btEditCart.TabIndex = 10;
            this.btEditCart.Text = "Edit";
            this.btEditCart.UseVisualStyleBackColor = true;
            this.btEditCart.Click += new System.EventHandler(this.btEditCart_Click);
            // 
            // btAddCart
            // 
            this.btAddCart.Location = new System.Drawing.Point(190, 154);
            this.btAddCart.Name = "btAddCart";
            this.btAddCart.Size = new System.Drawing.Size(94, 29);
            this.btAddCart.TabIndex = 9;
            this.btAddCart.Text = "Add";
            this.btAddCart.UseVisualStyleBackColor = true;
            this.btAddCart.Click += new System.EventHandler(this.btAddCart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "ProductID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "CustomerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cart";
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(6, 211);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 29;
            this.dgvCart.Size = new System.Drawing.Size(514, 247);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 626);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.dgvBillDetails);
            this.panel4.Location = new System.Drawing.Point(-3, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(662, 316);
            this.panel4.TabIndex = 4;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(5, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 28);
            this.label22.TabIndex = 4;
            this.label22.Text = "Bill Details";
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Location = new System.Drawing.Point(7, 33);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.RowHeadersWidth = 51;
            this.dgvBillDetails.RowTemplate.Height = 29;
            this.dgvBillDetails.Size = new System.Drawing.Size(552, 211);
            this.dgvBillDetails.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.btStartDate);
            this.panel3.Controls.Add(this.dtpStartDate);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dgvBill);
            this.panel3.Location = new System.Drawing.Point(-1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 350);
            this.panel3.TabIndex = 3;
            // 
            // btStartDate
            // 
            this.btStartDate.BackColor = System.Drawing.Color.Tomato;
            this.btStartDate.Location = new System.Drawing.Point(207, 9);
            this.btStartDate.Name = "btStartDate";
            this.btStartDate.Size = new System.Drawing.Size(94, 27);
            this.btStartDate.TabIndex = 6;
            this.btStartDate.Text = "StartDate";
            this.btStartDate.UseVisualStyleBackColor = false;
            this.btStartDate.Click += new System.EventHandler(this.btStartDate_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(307, 9);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 27);
            this.dtpStartDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bills";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bill Details";
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(5, 39);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 29;
            this.dgvBill.Size = new System.Drawing.Size(552, 286);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1100, 645);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel8.Controls.Add(this.dgvCustomers);
            this.panel8.Controls.Add(this.label21);
            this.panel8.Location = new System.Drawing.Point(3, -7);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(612, 623);
            this.panel8.TabIndex = 3;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(13, 62);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 29;
            this.dgvCustomers.Size = new System.Drawing.Size(590, 555);
            this.dgvCustomers.TabIndex = 1;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(13, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 28);
            this.label21.TabIndex = 0;
            this.label21.Text = "Customers";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Linen;
            this.panel7.Controls.Add(this.tbCustomerID);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.tbPhone);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.tbCustomerAddress);
            this.panel7.Controls.Add(this.btDeleteCustomer);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.btEditCustomer);
            this.panel7.Controls.Add(this.tbCustomerName);
            this.panel7.Controls.Add(this.nupAmountBuy);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Location = new System.Drawing.Point(612, -7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(485, 626);
            this.panel7.TabIndex = 2;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // tbCustomerID
            // 
            this.tbCustomerID.Location = new System.Drawing.Point(206, 81);
            this.tbCustomerID.Name = "tbCustomerID";
            this.tbCustomerID.ReadOnly = true;
            this.tbCustomerID.Size = new System.Drawing.Size(237, 27);
            this.tbCustomerID.TabIndex = 26;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(59, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(87, 20);
            this.label23.TabIndex = 25;
            this.label23.Text = "CustomerID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(59, 307);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Phone";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(206, 300);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(237, 27);
            this.tbPhone.TabIndex = 23;
            this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(9, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 28);
            this.label15.TabIndex = 1;
            this.label15.Text = "CustomerDetail";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(59, 218);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 20);
            this.label16.TabIndex = 22;
            this.label16.Text = "Address";
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(206, 215);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(237, 27);
            this.tbCustomerAddress.TabIndex = 19;
            // 
            // btDeleteCustomer
            // 
            this.btDeleteCustomer.Location = new System.Drawing.Point(349, 463);
            this.btDeleteCustomer.Name = "btDeleteCustomer";
            this.btDeleteCustomer.Size = new System.Drawing.Size(94, 29);
            this.btDeleteCustomer.TabIndex = 15;
            this.btDeleteCustomer.Text = "Delete";
            this.btDeleteCustomer.UseVisualStyleBackColor = true;
            this.btDeleteCustomer.Click += new System.EventHandler(this.btDeleteCustomer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Create";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btEditCustomer
            // 
            this.btEditCustomer.Location = new System.Drawing.Point(59, 463);
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Size = new System.Drawing.Size(94, 29);
            this.btEditCustomer.TabIndex = 13;
            this.btEditCustomer.Text = "Edit";
            this.btEditCustomer.UseVisualStyleBackColor = true;
            this.btEditCustomer.Click += new System.EventHandler(this.btEditCustomer_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(206, 147);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(237, 27);
            this.tbCustomerName.TabIndex = 12;
            // 
            // nupAmountBuy
            // 
            this.nupAmountBuy.Location = new System.Drawing.Point(206, 381);
            this.nupAmountBuy.Name = "nupAmountBuy";
            this.nupAmountBuy.Size = new System.Drawing.Size(237, 27);
            this.nupAmountBuy.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(59, 381);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 20);
            this.label19.TabIndex = 9;
            this.label19.Text = "AmountBuy";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(59, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 20);
            this.label20.TabIndex = 8;
            this.label20.Text = "Customer Name";
            // 
            // ManageShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManageShop";
            this.Text = "ManageShop";
            this.Load += new System.EventHandler(this.ManageShop_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupProductID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupAmountBuy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Panel panel6;
        private Label label9;
        private Label label14;
        private Label label13;
        private Label label12;
        private TextBox tbChip;
        private TextBox tbOperating;
        private TextBox tbScreen;
        private Button btDeleteProduct;
        private Button btCreateProduct;
        private Button btEditProduct;
        private TextBox tbProductName;
        private Label label11;
        private Label label10;
        private Panel panel5;
        private DataGridView dgvProduct;
        private Label label8;
        private TabPage tabPage2;
        private Panel panel2;
        private NumericUpDown nupCustomerID;
        private NumericUpDown nupProductID;
        private NumericUpDown nupQuantity;
        private Button btCreateBill;
        private Button btDeleteCart;
        private Button btEditCart;
        private Button btAddCart;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvCart;
        private Panel panel1;
        private Panel panel4;
        private DataGridView dgvBillDetails;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private DataGridView dgvBill;
        private TabPage tabPage3;
        private Panel panel8;
        private DataGridView dgvCustomers;
        private Label label21;
        private Panel panel7;
        private Label label15;
        private Label label16;
        private TextBox tbCustomerAddress;
        private Button btDeleteCustomer;
        private Button button2;
        private Button btEditCustomer;
        private TextBox tbCustomerName;
        private NumericUpDown nupAmountBuy;
        private Label label19;
        private Label label20;
        private TextBox tbPrice;
        private TextBox tbProductID;
        private Label label18;
        private Label label22;
        private DateTimePicker dtpStartDate;
        private Button btStartDate;
        private Button btRefresh;
        private Button btSearchProduct;
        private TextBox tbSearchProduct;
        private TextBox tbCustomerID;
        private Label label23;
        private Label label17;
        private TextBox tbPhone;
    }
}