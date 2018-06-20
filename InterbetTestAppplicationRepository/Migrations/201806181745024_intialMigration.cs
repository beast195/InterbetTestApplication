namespace InterbetTestAppplicationRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CorporatePayments",
                c => new
                    {
                        UniqueInstanceID = c.Guid(nullable: false),
                        EffectiveDate = c.DateTime(nullable: false),
                        TransactionCode = c.Int(nullable: false),
                        TransactionAmount = c.Double(nullable: false),
                        TransactionDate = c.DateTime(nullable: false),
                        TransactionTime = c.Int(nullable: false),
                        ChequeNumber = c.String(),
                        DrCrIndicator = c.String(),
                        BankName = c.String(),
                        BranchCode = c.String(),
                        ReferenceNumber = c.String(),
                        AccountNumber = c.Int(nullable: false),
                        Identifier = c.String(),
                    })
                .PrimaryKey(t => t.UniqueInstanceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CorporatePayments");
        }
    }
}
