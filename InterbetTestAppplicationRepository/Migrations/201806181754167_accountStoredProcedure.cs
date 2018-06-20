namespace InterbetTestAppplicationRepository.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class accountStoredProcedure : DbMigration
    {
        public override void Up()
        {
            Sql("CREATE PROCEDURE transactionFilterProc  " +
                "@trasactiondate datetime " +
                "AS  begin " +
                "SELECT * " +
                "FROM dbo.CorporatePayments " +
                "WHERE TransactionDate > @trasactiondate " +
                "end");
        }

        public override void Down()
        {
            Sql("drop procedure transactionFilterProc");
        }
    }
}