namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNumbersInMoviesType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "NumbersInStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "NumbersAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "NumbersAvailable", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "NumbersInStock", c => c.Int(nullable: false));
        }
    }
}
