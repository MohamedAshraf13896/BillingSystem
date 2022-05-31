namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Client_ID = c.Int(nullable: false, identity: true),
                        Client_Name = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false),
                        Address = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Client_ID)
                .Index(t => t.Client_ID, unique: true, name: "CLIENT ID has already existed before");
            
            CreateTable(
                "dbo.Sales_Invoices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Total_Price = c.Int(nullable: false),
                        Client_ID = c.Int(nullable: false),
                        Employee_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.Client_ID, cascadeDelete: true)
                .ForeignKey("dbo.Employes", t => t.Employee_ID, cascadeDelete: true)
                .Index(t => t.Client_ID)
                .Index(t => t.Employee_ID);
            
            CreateTable(
                "dbo.Employes",
                c => new
                    {
                        Employe_ID = c.Int(nullable: false, identity: true),
                        Employe_Name = c.String(maxLength: 100),
                        Employe_Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Employe_ID)
                .Index(t => t.Employe_ID, unique: true, name: "Employe_ID has already existed before");
            
            CreateTable(
                "dbo.Invoice_Items",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        Invoice_ID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.Invoice_ID })
                .ForeignKey("dbo.Sales_Invoices", t => t.Invoice_ID, cascadeDelete: true)
                .ForeignKey("dbo.Items", t => t.Item_ID, cascadeDelete: true)
                .Index(t => t.Item_ID)
                .Index(t => t.Invoice_ID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Item_ID = c.Int(nullable: false, identity: true),
                        Item_Name = c.String(nullable: false, maxLength: 50),
                        Selling_Price = c.Int(nullable: false),
                        Buying_Price = c.Int(nullable: false),
                        notes_item = c.String(),
                        Unit_ID = c.Int(nullable: false),
                        Type_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Item_ID)
                .ForeignKey("dbo.Types", t => t.Type_ID, cascadeDelete: true)
                .ForeignKey("dbo.Units", t => t.Unit_ID, cascadeDelete: true)
                .Index(t => t.Item_Name, unique: true, name: "ITEM NAME has already existed before")
                .Index(t => t.Unit_ID)
                .Index(t => t.Type_ID);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Type_ID = c.Int(nullable: false, identity: true),
                        Type_Name = c.String(nullable: false, maxLength: 50),
                        Type_Notes = c.String(maxLength: 100),
                        Company_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Type_ID)
                .ForeignKey("dbo.Companies", t => t.Company_ID, cascadeDelete: true)
                .Index(t => t.Type_Name, unique: true, name: "TYPE NAME has already existed before")
                .Index(t => t.Company_ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Company_ID = c.Int(nullable: false, identity: true),
                        Company_Name = c.String(nullable: false, maxLength: 50),
                        Company_Notes = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Company_ID)
                .Index(t => t.Company_Name, unique: true, name: "UniqueConstraint");
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Unit_ID = c.Int(nullable: false, identity: true),
                        Unit_Name = c.String(nullable: false, maxLength: 50),
                        Unit_Notes = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Unit_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Invoice_Items", "Item_ID", "dbo.Items");
            DropForeignKey("dbo.Items", "Unit_ID", "dbo.Units");
            DropForeignKey("dbo.Items", "Type_ID", "dbo.Types");
            DropForeignKey("dbo.Types", "Company_ID", "dbo.Companies");
            DropForeignKey("dbo.Invoice_Items", "Invoice_ID", "dbo.Sales_Invoices");
            DropForeignKey("dbo.Sales_Invoices", "Employee_ID", "dbo.Employes");
            DropForeignKey("dbo.Sales_Invoices", "Client_ID", "dbo.Clients");
            DropIndex("dbo.Companies", "UniqueConstraint");
            DropIndex("dbo.Types", new[] { "Company_ID" });
            DropIndex("dbo.Types", "TYPE NAME has already existed before");
            DropIndex("dbo.Items", new[] { "Type_ID" });
            DropIndex("dbo.Items", new[] { "Unit_ID" });
            DropIndex("dbo.Items", "ITEM NAME has already existed before");
            DropIndex("dbo.Invoice_Items", new[] { "Invoice_ID" });
            DropIndex("dbo.Invoice_Items", new[] { "Item_ID" });
            DropIndex("dbo.Employes", "Employe_ID has already existed before");
            DropIndex("dbo.Sales_Invoices", new[] { "Employee_ID" });
            DropIndex("dbo.Sales_Invoices", new[] { "Client_ID" });
            DropIndex("dbo.Clients", "CLIENT ID has already existed before");
            DropTable("dbo.Units");
            DropTable("dbo.Companies");
            DropTable("dbo.Types");
            DropTable("dbo.Items");
            DropTable("dbo.Invoice_Items");
            DropTable("dbo.Employes");
            DropTable("dbo.Sales_Invoices");
            DropTable("dbo.Clients");
        }
    }
}
