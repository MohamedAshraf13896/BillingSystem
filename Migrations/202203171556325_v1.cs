namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Units", "UNIT NAME has already existed before");
            AddColumn("dbo.Units", "Unit_Notes", c => c.String(maxLength: 100));
            AlterColumn("dbo.Clients", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Units", "Unit_Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Units", "Unit_Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clients", "Phone", c => c.Int(nullable: false));
            DropColumn("dbo.Units", "Unit_Notes");
            CreateIndex("dbo.Units", "Unit_Name", unique: true, name: "UNIT NAME has already existed before");
        }
    }
}
