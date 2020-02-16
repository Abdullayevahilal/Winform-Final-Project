namespace LIBRARY_MANAGEMENT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrders : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "OrderTime");
            DropColumn("dbo.Orders", "ReturnTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ReturnTime", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Orders", "OrderTime", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
