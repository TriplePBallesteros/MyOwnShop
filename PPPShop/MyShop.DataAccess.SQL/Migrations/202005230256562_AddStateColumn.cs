namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStateColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "State", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "State");
        }
    }
}
