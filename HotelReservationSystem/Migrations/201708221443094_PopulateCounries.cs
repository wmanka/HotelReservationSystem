namespace HotelReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCounries : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Countries (Name) VALUES ('Egypt')");
            Sql("INSERT INTO Countries (Name) VALUES ('Poland')");
            Sql("INSERT INTO Countries (Name) VALUES ('Germany')");
            Sql("INSERT INTO Countries (Name) VALUES ('Spain')");
            Sql("INSERT INTO Countries (Name) VALUES ('Greece')");
            Sql("INSERT INTO Countries (Name) VALUES ('Turkey')");
            Sql("INSERT INTO Countries (Name) VALUES ('Malta')");
            Sql("INSERT INTO Countries (Name) VALUES ('France')");
            Sql("INSERT INTO Countries (Name) VALUES ('Portual')");
            Sql("INSERT INTO Countries (Name) VALUES ('England')");
        }
        
        public override void Down()
        {
        }
    }
}
