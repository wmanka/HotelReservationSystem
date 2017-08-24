namespace HotelReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'27d0c36c-e430-47e0-8d7b-1d77760e806a', N'guest@book.go', 0, N'ANrwvHRSmcwdjI1YR23oo12xSDkr7sArhk3Q4mKLULfg63QpDlMu43Ysu4qt5gsskA==', N'dc8092e7-64f3-4883-b4c4-7431bd554dd9', NULL, 0, 0, NULL, 1, 0, N'guest@book.go')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ab702e38-41ab-4e71-9cab-3f7c98ec5b55', N'admin@book.go', 0, N'AMuwpBatq0YSTCcWrhd4+dZEJ6eycwe3i4YZTxBnOamCZS1EG3pEr+fpAcfzr1r29A==', N'51b5b28e-00b4-4804-af41-c9decd07a1a5', NULL, 0, 0, NULL, 1, 0, N'admin@book.go')
          
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'56999692-99d2-4d6d-b661-c889ca08f2e0', N'CanManageHotels')
      
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ab702e38-41ab-4e71-9cab-3f7c98ec5b55', N'56999692-99d2-4d6d-b661-c889ca08f2e0')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
