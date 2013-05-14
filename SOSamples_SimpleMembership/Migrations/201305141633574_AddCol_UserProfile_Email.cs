namespace SOSamples_SimpleMembership.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCol_UserProfile_Email : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfile", "Email", c => c.String(maxLength: 256));
        }

        public override void Down()
        {
            DropColumn("dbo.UserProfile", "Email");
        }
    }
}
