namespace ExamPaper2024OOD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSummaryClasses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Customers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Discriminator");
            DropColumn("dbo.Bookings", "Discriminator");
        }
    }
}
