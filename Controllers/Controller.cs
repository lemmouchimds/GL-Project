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

        public static void EditProduct(int id)
        {
            using (var db = new GLprojectDBcontext())
            {
                var newProInfos = db.Products.FirstOrDefault(pro => pro.ID == id);
                if (newProInfos != null)
                {
                    //newProInfos.Referance = 

                    db.SaveChanges();
                }
            }
        }


        public static bool DeleteProduit(int id)
        {

            using (var db = new GLprojectDBcontext())
            {
                var product = db.Products.FirstOrDefault(prod => prod.ID == id);
                if (product == null)
                {
                    return false;
                }

                db.Products.Remove(product);
                db.SaveChanges();
                return true;
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

        public static User UserExicts(string username)
        {
            using (var db = new GLprojectDBcontext())
            {
                var user = db.Users.FirstOrDefault(c => c.Username == username);
                if (user != null)
                {
                    return user;
                }

                return null;
            }
        }

        public static bool DeleteUser(int id)
        {

            using (var db = new GLprojectDBcontext())
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

        #region Document
        public static List<Document> Documents
        {
            get
            {
                using (var db = new GLprojectDBcontext())
                {
                    return db.Documents.ToList();
                }
            }

        }

        public static void AddDocument(Document document)
        {
            using (var db = new GLprojectDBcontext())
            {
                db.Documents.Add(document);
                db.SaveChanges();
            }
        }

        public static bool EditDocument(Document document)
        {
            using (var db = new GLprojectDBcontext())
            {
                var newDocumentInfos = db.Documents.FirstOrDefault(cust => cust.ID == document.ID);
                if (newDocumentInfos != null)
                {
                    newDocumentInfos.Reference = document.Reference;
                    newDocumentInfos.PaymentDate = document.PaymentDate;
                    newDocumentInfos.CustomerID = document.CustomerID;  
                    newDocumentInfos.Customer = document.Customer;
                    newDocumentInfos.Date = document.Date;
                    newDocumentInfos.Payed = document.Payed;

                    db.SaveChanges();
                    return true;
                }

                return false;
            }
        }

        public static bool DeleteDocument(int id)
        {

            using (var db = new GLprojectDBcontext())
            {
                var doc = db.Documents.FirstOrDefault(c => c.ID == id);
                if (doc == null)
                {
                    return false;
                }

                db.Documents.Remove(doc);
                db.SaveChanges();
                return true;
            }
        }
        #endregion
    }
}
