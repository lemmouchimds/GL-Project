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

        

        public static List<Client> Clients 
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
        public static void AddClient(Client client)
        {
            using(var db = new GLprojectDBcontext())
            {
                db.Client.Add(client);
                db.SaveChanges();
            }
        }

        public static void DeleteClient(int IDD)
        {
            using( var db = new GLprojectDBcontext())
            {
                Client client = db.Client.FirstOrDefault(cl => cl.ID == IDD);
                if( client == null )
                    return;

                db.Client.Remove(client);
                db.SaveChanges ();
            }
        }

        public static void EditClient(Client oldClient, Client newClient)
        {
            //todo: edit from database
            //DeleteClient(oldClient);
            //AddClient(newClient);   
        }
        #endregion

        #region produit
        public static List<Produit> Produits
        {
            get
            {
                using (var db = new GLprojectDBcontext())
                {
                    return db.Produit.ToList();
                }
            }
        }

        public static void AddProduit(Produit produit)
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
