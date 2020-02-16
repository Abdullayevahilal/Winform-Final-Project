namespace LIBRARY_MANAGEMENT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeOrder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "OrderTime", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Orders", "ReturnTime", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Orders", "BookPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "BookPrice");
            DropColumn("dbo.Orders", "ReturnTime");
            DropColumn("dbo.Orders", "OrderTime");
            DropColumn("dbo.Orders", "Status");
        }
    }
}
