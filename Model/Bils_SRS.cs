using System;
using System.Data.Entity;
using System.Linq;

namespace Project.Model
{
    public class Bils_SRS : DbContext
    {
        // Your context has been configured to use a 'Bils_SRS' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Project.Model.Bils_SRS' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Bils_SRS' 
        // connection string in the application configuration file.
        public Bils_SRS()
            : base("name=Bils_SRS")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Sales_Invoices> Sales_Invoices { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<Invoice_Items> Invoice_Items { get; set; }
        public virtual DbSet<Employe> Employes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

}