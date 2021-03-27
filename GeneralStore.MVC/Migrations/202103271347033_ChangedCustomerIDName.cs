namespace GeneralStore.MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedCustomerIDName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Transactions", new[] { "CustomerId" });
            CreateIndex("dbo.Transactions", "CustomerID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Transactions", new[] { "CustomerID" });
            CreateIndex("dbo.Transactions", "CustomerId");
        }
    }
}
