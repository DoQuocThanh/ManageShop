using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Text.Json;


namespace ManageShopWeb.Controllers
{
	public class ShopController : Controller
	{

		ShopContext context = new ShopContext();
		// GET: ShopController
		public ActionResult Login()
		{

            return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(string email, string pass)
		{
			var em = (from a in context.Employees
					  where a.Email == email && a.Password == pass
					  select new
					  {
						  a
					  }
				   ).FirstOrDefault();

			if (em == null)
			{
				ViewBag.msg = "Email or Password isn't correct !!!";
				return View();
			}
			else if (em.a.Role == 1 && em.a.Status == 1)
			{


                HttpContext.Session.SetInt32("employeeId", em.a.EmployeeId);
                return RedirectToAction("Product");
                


            }
			else if (em.a.Role == 2)
			{
                HttpContext.Session.SetInt32("admin", 1);
                return RedirectToAction("Employee");
            }
			return null;
		}

      
        public ActionResult Product()
		{


            if (HttpContext.Session.GetInt32("employeeId") == null) {
                return RedirectToAction("Login");
            }
			ViewBag.p = context.Products.ToList();
			return View();
		}
        public ActionResult Customer()
        {


            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            ViewBag.c = context.Customers.ToList();
            return View();
        }
        public ActionResult Bills()
        {


            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            ViewBag.b = context.Bills.ToList();
            return View();
        }
        public ActionResult Employee()
        {

            if (HttpContext.Session.GetInt32("admin") == null)
            {
                return RedirectToAction("Login");
            }

            ViewBag.em =  (from a in context.Employees
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
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BillDetail(int billId)
        {
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            ViewBag.bd = (from a in context.BillDetails
                              join c in context.Products
                              on a.ProductId equals c.ProductId
                              where a.BillId == billId
                              select new
                              {
                                  a.BillDetailId,
                                  a.BillId,
                                  c.ProductName,
                                  a.Quantity,
                                  Price = a.Quantity * c.Price
                              }
                   ).ToList();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmployee(int EmployeeId)
        {
            if (HttpContext.Session.GetInt32("admin") == null)
                {
                    return RedirectToAction("Login");
                }
          
            Employee em_ = context.Employees.SingleOrDefault(p => p.EmployeeId == EmployeeId);
            ViewBag.em = em_;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmployee1(int EmployeeId,String Email,String Address,int Status,String Password,String Name)
        {
            if (HttpContext.Session.GetInt32("admin") == null)
            {
                return RedirectToAction("Login");
            }
            Employee em = new Employee()
            {
                Email = Email,
                Address = Address,
                EmployeeId = EmployeeId,
                Name = Name,
                Password = Password,
                Status = Status,
                Role = 1
            };
            context.Employees.Update(em);
            context.SaveChanges();
            return RedirectToAction("Employee");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            if (HttpContext.Session.GetInt32("admin") == null)
            {
                return RedirectToAction("Login");
            }
            Employee em_ = context.Employees.SingleOrDefault(p => p.EmployeeId == EmployeeId);
            context.Employees.Remove(em_);
            context.SaveChanges();
            return RedirectToAction("Employee");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateEmployee( String Email, String Address, int Status, String Password, String Name)
        {
            if (HttpContext.Session.GetInt32("admin") == null)
            {
                return RedirectToAction("Login");
            }
            Employee em = new Employee()
            {
                Email = Email,
                Address = Address,
                
                Name = Name,
                Password = Password,
                Status = Status,
                Role = 1
            };
            context.Employees.Add(em);
            context.SaveChanges();
            return RedirectToAction("Employee");

        }
        public ActionResult CreateEmployee()
        {
            if (HttpContext.Session.GetInt32("admin") == null)
            {
                return RedirectToAction("Login");
            }
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct(int productID)
		{
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            Product p = context.Products.SingleOrDefault(p => p.ProductId == productID);
			ViewBag.p = p;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProduct1(int productID,String ProductName,String Chip,String OperatingSystem,String PhoneScreen, float Price)
        {
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            Product p = new Product()
			{
				Chip = Chip,
				OperatingSystem = OperatingSystem,
				PhoneScreen = PhoneScreen,
				Price = Price,
				ProductId = productID,
				ProductName = ProductName

			};
            context.Products.Update(p);
            context.SaveChanges();


            return RedirectToAction("Product");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCustomer(int CustomerId)
        {
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            Customer cus_ = context.Customers.SingleOrDefault(p => p.CustomerId == CustomerId);
            ViewBag.c = cus_;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCustomer1(int CustomerId, String Name, String Address, int Amountbuy)
        {

            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            Customer cus = new Customer
            {
                CustomerId = CustomerId,
                Address = Address,
                AmountBuy = Amountbuy,
                Name = Name

            };
            context.Customers.Update(cus);
            context.SaveChanges();

            return RedirectToAction("Customer");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCustomer(int CustomerId)
        {

            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            Customer cus = context.Customers.SingleOrDefault(p => p.CustomerId == CustomerId);
            context.Customers.Remove(cus);
            context.SaveChanges();

            return RedirectToAction("Customer");
        }

        public ActionResult CreateCustomer()
        {

            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer(int CustomerId, String Name, String Address, int Amountbuy)
        {
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            Customer cus = new Customer
            {
                CustomerId = CustomerId,
                Address = Address,
                AmountBuy = Amountbuy,
                Name = Name

            };

            context.Customers.Add(cus);
            context.SaveChanges();
            return RedirectToAction("Customer");
        }
        // GET: ShopController/Create
        public ActionResult CreateProduct()
		{
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult CreateProduct(String ProductName, String Chip, String OperatingSystem, String PhoneScreen, float Price)
		{
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            Product p = new Product()
            {
                Chip = Chip,
                OperatingSystem = OperatingSystem,
                PhoneScreen = PhoneScreen,
				Price = Price,
              
                ProductName = ProductName

            };
            context.Products.Add(p);
            context.SaveChanges();
            return RedirectToAction("Product");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(int productID)
        {
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            Product p = context.Products.SingleOrDefault(p => p.ProductId == productID);
         
     
            context.Products.Remove(p);
            context.SaveChanges();
          
            return RedirectToAction("Product");
        }

       
        public ActionResult Cart()
        {
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            List<CartDetails> cart = new List<CartDetails>();

            byte[] byteArray = HttpContext.Session.Get("cart");
            if (byteArray != null)
            {
                cart = JsonSerializer.Deserialize<List<CartDetails>>(byteArray);
            }
            else {
                byte[] byteArray1 = JsonSerializer.SerializeToUtf8Bytes(cart);
                HttpContext.Session.Set("cart", byteArray1);
            }

           

         

             
            ViewBag.c = cart;
            return View();
        }

        // POST: ShopController/Edit/5
        [HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Cart(int ProductID, int Quantity)
		{
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            byte[] byteArray = HttpContext.Session.Get("cart");
           
            List<CartDetails> cart = JsonSerializer.Deserialize<List<CartDetails>>(byteArray);
            
            foreach (CartDetails item in cart)
                {
                if (ProductID == item.ProductID)
                {
                    item.Quantity = item.Quantity + Quantity;
                    item.Price = item.Price + (item.Price / item.Quantity) * Quantity;

                    byteArray = JsonSerializer.SerializeToUtf8Bytes(cart);
                    HttpContext.Session.Set("cart", byteArray);
                    return RedirectToAction("Cart");
                }

            }
            
            var p = (from c in context.Products

                     where c.ProductId == ProductID
                     select new
                     {
                         c.Price,
                         c.ProductName,
                         c.ProductId

                     }).FirstOrDefault();

            CartDetails cartDetail = new CartDetails()
            {
                ProductName = p.ProductName,
                Quantity = Quantity,
                Price = (float)p.Price * Quantity,
                ProductID = p.ProductId
            };
            cart.Add(cartDetail);
            byteArray = JsonSerializer.SerializeToUtf8Bytes(cart);
            HttpContext.Session.Set("cart", byteArray);
          
            return RedirectToAction("Cart");
        }

		// GET: ShopController/Delete/5
		public ActionResult Delete(int id)
		{
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            return View();
		}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateBill(int CustomerId)
        {
            if (HttpContext.Session.GetInt32("employeeId") == null)
            {
                return RedirectToAction("Login");
            }
            byte[] byteArray = HttpContext.Session.Get("cart");
            List<CartDetails> cart = JsonSerializer.Deserialize<List<CartDetails>>(byteArray);

            var c = (from a in context.Customers

                     where a.CustomerId == CustomerId
                     select new
                     {
                         a

                     }).FirstOrDefault();

            Bill b = new Bill()
            {
                CustomerId = CustomerId,
                EmployeeId = (int)HttpContext.Session.GetInt32("employeeId")

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



            return RedirectToAction("Bills");
        }
	}
}
