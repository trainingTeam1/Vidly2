namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies Set NumbersAvailable = NumbersInStock");
        }
        
        public override void Down()
        {
        }
    }
}
