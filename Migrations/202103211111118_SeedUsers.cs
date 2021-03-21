namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7e134ef4-d62f-452d-a50d-f535cc679a4e', N'admin@vidly.com', 0, N'AB2qr1Wo/X+vka2CVrKaCSyaEVHJbZoVQwtxFZPLeKSwwtSZjEMoFYMHAB9dcFLXOQ==', N'7459005b-7f6f-4093-919a-56474a0efae8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b8019a90-8419-419b-a4fe-fc8c6c4070e4', N'guest@vidly.com', 0, N'ACMiJHcAybNipBGjYLX6NGj2DgZ0VZtG/qqSAAQUCIErgXRIYDH0BouYK8QiILHl8w==', N'b355105a-96ef-451e-9710-dcf641bdd292', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'19d827b6-b544-4c70-ab06-0a05134cd323', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7e134ef4-d62f-452d-a50d-f535cc679a4e', N'19d827b6-b544-4c70-ab06-0a05134cd323')
");
        }
        
        public override void Down()
        {
        }
    }
}
