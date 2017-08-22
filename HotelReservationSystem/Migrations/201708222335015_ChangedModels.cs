namespace HotelReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Hotels", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Hotels", "City", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hotels", "City", c => c.String());
            AlterColumn("dbo.Hotels", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false));
        }
    }
}
