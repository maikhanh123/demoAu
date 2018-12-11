namespace AuthDemo01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShippingAddressToUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ShippingAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ShippingAddress");
        }
    }
}
