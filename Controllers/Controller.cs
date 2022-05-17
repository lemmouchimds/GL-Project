using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLMainProject
{
    public static class Controller
    {
        #region client

        public static List<Customer> Clients 
        { 
            get
            {
                using (var db = new GLprojectDBcontext())
                {
                    return db.Customers.ToList();
                }
            }
                
        }

        public static void AddClient(Customer client)
        {
            using(var db = new GLprojectDBcontext())
            {
                db.Customers.Add(client);
                db.SaveChanges();
            }
        }

        public static bool EditClient(Customer customer)
        {
            using(var db = new GLprojectDBcontext())
            {
                var newCustomerInfos = db.Customers.FirstOrDefault(cust => cust.ID == customer.ID);
                if (newCustomerInfos != null)
                {
                    newCustomerInfos.Designation = customer.Designation;
                    newCustomerInfos.Email = customer.Email;
                    newCustomerInfos.IsRevendeur = customer.IsRevendeur;
                    newCustomerInfos.Responsable = customer.Responsable;
                    newCustomerInfos.Adress = customer.Adress;

                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public static bool DeleteClient(int id)
        {

            using( var db = new GLprojectDBcontext())
            {
                var cust = db.Customers.FirstOrDefault(c => c.ID == id);
                if (cust == null)
                {
                    return false;
                }

                db.Customers.Remove(cust);
                db.SaveChanges ();
                return true;
            }
        }

        #endregion

        #region produit
        public static List<Product> Produits
        {
            get
            {
                using (var db = new GLprojectDBcontext())
                {
                    return db.Products.ToList();
                }
            }
        }

        public static void AddProduit(Product produit)
        {
            using(var db = new GLprojectDBcontext())
            {
                db.Products.Add(produit);
                db.SaveChanges();
            }
        }
        #endregion

        #region user

        public static List<User> Users
        {
            get
            {
                using (var db = new GLprojectDBcontext())
                {
                    return db.Users.ToList();
                }
            }

        }

        public static void AddUser(User user)
        {
            using (var db = new GLprojectDBcontext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public static void EditUser(User user)
        {
            using (var db = new GLprojectDBcontext())
            {
                var newUserInfos = db.Users.FirstOrDefault(use => use.Id == user.Id);
                if (newUserInfos != null)
                {
                    newUserInfos.Username = user.Username;
                    newUserInfos.Password = user.Password;
                    newUserInfos.UserType = user.UserType;

                    db.SaveChanges();
                }
            }
        }

        
        public static bool DeleteUser(int id)
        {

            using( var db = new GLprojectDBcontext())
            {
                var user = db.Users.FirstOrDefault(c => c.Id == id);
                if (user == null)
                {
                    return false;
                }

                db.Users.Remove(user);
                db.SaveChanges();
                return true;
            }
        }

        #endregion

    }
}
