namespace ExamPaper2024OOD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedSummaryClasses : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bookings", "Discriminator");
            DropColumn("dbo.Customers", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Bookings", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
    }
}
