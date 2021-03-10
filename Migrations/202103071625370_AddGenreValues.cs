namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenreValues : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres(Name) Values ('Fiction')");
            Sql("Insert Into Genres(Name) Values ('Series')");
        }
        
        public override void Down()
        {
        }
    }
}
