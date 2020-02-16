namespace LIBRARY_MANAGEMENT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "OrderTime", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.Orders", "TotalPrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Orders", "ReturnTime", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Orders", "DeadLine", c => c.DateTime(nullable: false, storeType: "date"));
            DropColumn("dbo.Orders", "GivingTime");
            DropColumn("dbo.Orders", "LastMoney");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "LastMoney", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Orders", "GivingTime", c => c.DateTime());
            AlterColumn("dbo.Orders", "DeadLine", c => c.DateTime());
            AlterColumn("dbo.Orders", "ReturnTime", c => c.DateTime());
            DropColumn("dbo.Orders", "TotalPrice");
            DropColumn("dbo.Orders", "OrderTime");
        }
    }
}
