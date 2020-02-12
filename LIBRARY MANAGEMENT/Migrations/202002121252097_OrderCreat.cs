namespace LIBRARY_MANAGEMENT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OrderCreat : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrderBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.OrderBooks", "OrdersId", "dbo.Orders");
            DropIndex("dbo.OrderBooks", new[] { "BookId" });
            DropIndex("dbo.OrderBooks", new[] { "OrdersId" });
            AddColumn("dbo.Orders", "BookId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "BookId");
            AddForeignKey("dbo.Orders", "BookId", "dbo.Books", "Id", cascadeDelete: true);
            DropTable("dbo.OrderBooks");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OrderBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(),
                        OrdersId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Orders", "BookId", "dbo.Books");
            DropIndex("dbo.Orders", new[] { "BookId" });
            DropColumn("dbo.Orders", "BookId");
            CreateIndex("dbo.OrderBooks", "OrdersId");
            CreateIndex("dbo.OrderBooks", "BookId");
            AddForeignKey("dbo.OrderBooks", "OrdersId", "dbo.Orders", "Id");
            AddForeignKey("dbo.OrderBooks", "BookId", "dbo.Books", "Id");
        }
    }
}
