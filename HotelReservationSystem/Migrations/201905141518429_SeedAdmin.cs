namespace HotelReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdmin : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES ('9aeb4c43-f032-42e4-a23b-09d5080026f3', 'admin@admin.com', 0, 'AHF6J5KC7PlT6tPWIeXka92xfancIGNQioIDMWAQ5sZPm2TcwUSkQS22E6N319krGQ==', 'd8465485-0a5e-4736-b605-1b9804f4d5f7', NULL, 0, 0, NULL, 1, 0, 'admin@admin.com')
           
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES ('9aeb4c43-f032-42e4-a23b-09d5080026f3', N'56999692-99d2-4d6d-b661-c889ca08f2e0')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
