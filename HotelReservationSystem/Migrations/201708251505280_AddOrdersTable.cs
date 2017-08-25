namespace HotelReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrdersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOrdered = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        NumberOfDays = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                        Hotel_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Hotels", t => t.Hotel_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Hotel_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Hotel_Id", "dbo.Hotels");
            DropForeignKey("dbo.Orders", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "Hotel_Id" });
            DropIndex("dbo.Orders", new[] { "Customer_Id" });
            DropTable("dbo.Orders");
        }
    }
}
