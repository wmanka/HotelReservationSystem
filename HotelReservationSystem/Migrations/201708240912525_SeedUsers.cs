namespace HotelReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8a191f4e-89e2-4323-9ecc-be913b73f2d5', N'guest@book.go', 0, N'AJ8kfBrz/VmjpPq9uGi07crUQY4QG7ZreX9PXJHPAbo6LIfwXcB92O9RmxO0Wc2pjA==', N'13066154-eae6-4773-b374-b53ae2369798', NULL, 0, 0, NULL, 1, 0, N'guest@book.go')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'91146fca-8a4e-446f-913f-7edf81efc26e', N'admin@book.go', 0, N'ADpgNaTderP0F+UIU4hT3nT30wumNEi9g+SuTgne7XX2kFF1QXVwrpa5ojMtNAZvaA==', N'6b111cff-d82d-4bf5-ae80-e73078c0cbfa', NULL, 0, 0, NULL, 1, 0, N'admin@book.go')
                
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f8ed9e96-8181-4232-b7ad-2bbe9d552cbc', N'CanManageBooks')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'91146fca-8a4e-446f-913f-7edf81efc26e', N'f8ed9e96-8181-4232-b7ad-2bbe9d552cbc')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
