namespace HotelReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFullPricePropertyToOrderTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "FullPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "FullPrice");
        }
    }
}
