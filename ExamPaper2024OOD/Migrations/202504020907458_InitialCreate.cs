namespace ExamPaper2024OOD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        BookingsDate = c.DateTime(nullable: false),
                        NumberOfParticipants = c.Int(nullable: false),
                        Customer_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID)
                .Index(t => t.Customer_CustomerID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ContactNumber = c.String(),
                    })
                .PrimaryKey(t => t.CustomerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "Customer_CustomerID", "dbo.Customers");
            DropIndex("dbo.Bookings", new[] { "Customer_CustomerID" });
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
