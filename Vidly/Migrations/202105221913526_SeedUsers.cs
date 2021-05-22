namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6a3a3469-b539-43df-b9a5-8fcb2bc56bdd', N'admin@vidly.com', 0, N'ANkEVe4xJIJtObEx7mCb94gavjGJR36JWr1Oe+BV0V0pilVOpTlmvuknokTlLzar1A==', N'fd0563d9-cc7a-4ee0-a47f-0a4e6fb301c7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b32b457b-7255-4c87-8acd-c2eebcc5e699', N'CanManageMovies')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6a3a3469-b539-43df-b9a5-8fcb2bc56bdd', N'b32b457b-7255-4c87-8acd-c2eebcc5e699')
            
            ");
        }
        
        public override void Down()
        {

        }
    }
}
