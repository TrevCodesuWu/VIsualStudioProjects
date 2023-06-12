namespace RolesApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class popshi : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd4374c1e-08b3-408a-89f5-8eb53badc51f', N'Pam@gmail.com', 0, N'AJ9KHQfODiFycmckVaLQKVIC4vak8w1GotilRp8wRiHXPIQjO//KzwGzB89f20Tx1A==', N'54dd3981-5201-4c37-9eec-c2cb751626c9', NULL, 0, 0, NULL, 1, 0, N'Pam@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'525fb51b-995c-4259-92af-bc7eb2e437a1', N'Jay@gmail.com', 0, N'AMHG+RJ8y/4xU3f5O+EIo500lYrwmtxNR9IdUaSAiT1KO4htQ2hyYjT+YjwjuYnY/Q==', N'9c6b6b7d-2a4f-4e3e-a378-ed231adcaff4', NULL, 0, 0, NULL, 1, 0, N'Jay@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7e933a1f-cedf-410a-9c84-5cfca8b1a1b0', N'DriverRole')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'525fb51b-995c-4259-92af-bc7eb2e437a1', N'7e933a1f-cedf-410a-9c84-5cfca8b1a1b0')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd4374c1e-08b3-408a-89f5-8eb53badc51f', N'7e933a1f-cedf-410a-9c84-5cfca8b1a1b0')

");
        }
        
        public override void Down()
        {
        }
    }
}
