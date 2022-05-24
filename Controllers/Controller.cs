using GLMainProject.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public static List<CustomerDto> ListAllCusts()
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Customers.ToList()
                    .Select(cust => new CustomerDto
                    {
                        ID = cust.ID,
                        Designation = cust.Designation,
                        Email = cust.Email,
                        Adress = cust.Adress,
                        Responsable = cust.Responsable,
                        IsRevendeur = cust.IsRevendeur.ToString()
                    })
                    .ToList();
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

        public static Customer GetCustById(int ID)
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Customers.FirstOrDefault(u => u.ID == ID);
            }
        }

        public static List<string> GetCustomerNames()
        {
            var result = new List<string>();

            using( var db = new GLprojectDBcontext())
            {
                foreach(var customer in db.Customers)
                {
                    result.Add($"{customer.ID} - {customer.Designation}");
                }
            }

            return result;
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
        public static void EditProduct(Product product)
        {
            using (var db = new GLprojectDBcontext())
            {
                var newProductInfos = db.Products.FirstOrDefault(use => use.ID == product.ID);
                if (newProductInfos != null)
                {
                    newProductInfos.Referance = product.Referance;
                    newProductInfos.Designation = product.Designation;
                    newProductInfos.ValNutritionnelle = product.ValNutritionnelle;
                    newProductInfos.PoidsNet = product.PoidsNet;
                    newProductInfos.CoutRevient = product.CoutRevient;
                    newProductInfos.GainSouaite = product.GainSouaite;

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
        public static List<ProductDto> ListAllProducts()
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Products.ToList()
                    .Select(u => new ProductDto
                    {
                        ID = u.ID,
                        Referance = u.Referance,
                        Designation = u.Designation,
                        ValNutritionnelle = u.ValNutritionnelle,
                        PoidsNet = u.PoidsNet,
                        CoutRevient = u.CoutRevient,
                        GainSouaite = u.GainSouaite,
                        TotalQuantity = u.TotalQuantity
                    })
                    .ToList();
            }
        }
        public static List<ProductDto> ListDispoProducts()
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Products.Where(p=> p.TotalQuantity > 0).ToList()
                    .Select(u => new ProductDto
                    {
                        ID = u.ID,
                        Referance = u.Referance,
                        Designation = u.Designation,
                        ValNutritionnelle = u.ValNutritionnelle,
                        PoidsNet = u.PoidsNet,
                        CoutRevient = u.CoutRevient,
                        GainSouaite = u.GainSouaite,
                        TotalQuantity = u.TotalQuantity
                    })
                    .ToList();
            }
        }
        public static Product GetProductById(int id)
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Products.FirstOrDefault(u => u.ID == id);
            }

        }
        public static List<ProductDto> Search(string keyWord)
        {
            var list = ListAllProducts();
            var q = from e in list
                    where   e.Designation.Contains(keyWord) || 
                            e.Referance.Contains(keyWord)
                    select e;

            return q.ToList();
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
        public static List<UserDto> ListAllUsers()
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Users.ToList()
                    .Select(u => new UserDto
                    {
                        Id = u.Id,
                        Username = u.Username,
                        Type = u.UserType.FriendlyName()
                    })
                    .ToList();
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
        public static User GetUserById(int id)
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Users.FirstOrDefault(u=> u.Id == id);
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
        public static User UserExist(string username)
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
                foreach (var item in document.DocumentDetails)
                {
                    db.DocumentDetails.Add(item);
                }
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
                    db.DocumentDetails.RemoveRange(newDocumentInfos.DocumentDetails);
                    foreach (var item in document.DocumentDetails)
                    {
                        db.DocumentDetails.Add(item);
                    }
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

        public static List<DocsDto> ListAllDocs()
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Documents.ToList()
                    .Select(u => new DocsDto
                    {
                        ID = u.ID,
                        Reference = u.Reference,
                        CustIdName = $"{u.ID} - {u.Customer.Designation}",
                        Date = u.Date,
                        PayementDate = u.PaymentDate,
                        Payed = u.Payed.ToString()
                    })
                    .ToList();
            }
        }
        public static Document GetDocById(int ID)
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Documents.FirstOrDefault(u => u.ID == ID);
            }

        }
        #endregion

        #region DetailDoc
        public static List<DocumentDetail> DetailDocs
        {
            get
            {
                using (var db = new GLprojectDBcontext())
                {
                    return db.DocumentDetails.ToList();
                }
            }
        }
        public static List<DocsDetailDto> ListAllDetailDocs(int DocumentID)
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.DocumentDetails.Where(a => a.DocumentID == DocumentID).ToList()
                    .Select(u => new DocsDetailDto
                    {
                        ID = u.ID,
                        Produit = u.Produit.Designation,
                        Quantity = u.Quantity,
                        UnitPrice = u.UnitPrice,
                        Label = u.Label
                    }).ToList();
            }
        }
        public static void AddDocDetail(DocumentDetail documentDetail)
        {
            using (var db = new GLprojectDBcontext())
            {
                db.DocumentDetails.Add(documentDetail);
                db.SaveChanges();
            }
        }
        internal static DocumentDetail GetDetailDocById(int id)
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.DocumentDetails.FirstOrDefault(u => u.ID == id);
            }

        }
        public static void EditDetailDoc(DocumentDetail documentDetail)
        {
            using (var db = new GLprojectDBcontext())
            {
                var newDetailDocInfos = db.DocumentDetails.FirstOrDefault(use => use.ID == documentDetail.ID);
                if (newDetailDocInfos != null)
                {
                    newDetailDocInfos.Produit = documentDetail.Produit;
                    newDetailDocInfos.Quantity = documentDetail.Quantity;
                    newDetailDocInfos.Label = documentDetail.Label;
                                       

                    db.SaveChanges();
                }
            }
        }
        public static bool DeleteDetailDoc(int id)
        {

            using (var db = new GLprojectDBcontext())
            {
                var detailDoc = db.DocumentDetails.FirstOrDefault(c => c.ID == id);
                if (detailDoc == null)
                {
                    return false;
                }

                db.DocumentDetails.Remove(detailDoc);
                db.SaveChanges();
                return true;
            }
        }

        public static List<string> InventoryNameID()
        {
            var result = new List<string>();

            foreach (var item in ListAllInventories())
            {
                result.Add($"{item.ID} - {GetProductById(item.ID).Designation} " +
                    $"- date:{item.DateProduction} to {item.DatePeremption}");
            }

            return result;
        }
        #endregion

        #region Inventory
        public static List<Inventory> Inventory
        {
            get
            {
                using (var db = new GLprojectDBcontext())
                {
                    return db.Inventory.ToList();
                }
            }
        }
        public static List<StockDto> ListAllInventories()
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Inventory.ToList()
                    .Select(u => new StockDto
                    {
                        ID = u.ID,
                        Product = $"{u.ProductID} - {u.Product.Designation}",
                        Quantitie = u.InStock,
                        DateProduction = u.DateProduction.ToShortDateString(),
                        DatePeremption = u.DatePeremption.ToShortDateString()
                    })
                    .ToList();
            }
        }
        public static void AddStock(Inventory inventory)
        {
            using (var db = new GLprojectDBcontext())
            {
                db.Inventory.Add(inventory);
                inventory.Product = db.Products.FirstOrDefault(c => c.ID == inventory.ProductID);
                inventory.Product.TotalQuantity += inventory.InStock;
                db.SaveChanges();
            }
        }
        public static Inventory GetStockById(int id)
        {
            using (var db = new GLprojectDBcontext())
            {
                return db.Inventory.FirstOrDefault(u => u.ID == id);
            }

        }
        public static void EditInventory(Inventory inventory)
        {
            using (var db = new GLprojectDBcontext())
            {
                var newInventoryInfos = db.Inventory.FirstOrDefault(use => use.ID == inventory.ID);
                if (newInventoryInfos != null)
                {
                    inventory.Product.TotalQuantity += (newInventoryInfos.InStock - inventory.InStock);
                    newInventoryInfos.Product = inventory.Product;
                    newInventoryInfos.DateProduction = inventory.DateProduction;
                    newInventoryInfos.DatePeremption = inventory.DatePeremption;
                    newInventoryInfos.InStock = inventory.InStock;
                    db.SaveChanges();
                }
            }
        }
        public static bool DeleteInventory(int id)
        {

            using (var db = new GLprojectDBcontext())
            {
                var inventory = db.Inventory.FirstOrDefault(c => c.ID == id);
                if (inventory == null)
                {
                    return false;
                }
                inventory.Product.TotalQuantity -= inventory.InStock;
                db.Inventory.Remove(inventory);
                db.SaveChanges();
                return true;
            }
        }

        public static List<string> ProductNamesID()
        {
            var result = new List<string>();

            foreach(var item in ListAllProducts())
            {
                result.Add($"{item.ID} - {item.Designation}");
            }

            return result;
        }

        #endregion
    }

    public static class Extensions
    {
        public static string FriendlyName(this UserType type)
        {
            switch (type)
            {
                default:
                case UserType.AgentVente:
                    return "Agent de vente";
                case UserType.AgentCommercial:
                    return "Agent Commercial";
                case UserType.Directeur:
                    return "Directeur";

            }
        }

        public static UserType ToUserType(this string txt)
        {
            switch (txt)
            {
                default:
                case "Agent de vente":
                    return UserType.AgentVente;
                case "Agent Commercial":
                    return UserType.AgentCommercial;
                case "Directeur":
                    return UserType.Directeur;

            }
        }
    }
}
