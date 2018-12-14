namespace CodeFirstDesign.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VideosNameChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Classification", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "Classification", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String());
            DropColumn("dbo.Videos", "GenreId");
        }
    }
}
