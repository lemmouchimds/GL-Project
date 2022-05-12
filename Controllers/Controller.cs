﻿using System;
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
                    return db.Client.ToList();
                }
            }
                
        }
        //public static List<Client> GetClient()
        public static void AddClient(Customer client)
        {
            using(var db = new GLprojectDBcontext())
            {
                db.Client.Add(client);
                db.SaveChanges();
            }
        }

        public static void DeleteClient(Customer client)
        {
            using( var db = new GLprojectDBcontext())
            {
                db.Client.Remove(client);
                db.SaveChanges ();
            }
        }

        public static void EditClient(Customer oldClient, Customer newClient)
        {
            //todo: edit from database
            //DeleteClient(oldClient);
            //AddClient(newClient);   
        }
        #endregion

        #region produit
        public static List<Product> Produits
        {
            get
            {
                using (var db = new GLprojectDBcontext())
                {
                    return db.Produit.ToList();
                }
            }
        }

        public static void AddProduit(Product produit)
        {
            using(var db = new GLprojectDBcontext())
            {
                db.Produit.Add(produit);
                db.SaveChanges();
            }

        }
        #endregion



    }
}
