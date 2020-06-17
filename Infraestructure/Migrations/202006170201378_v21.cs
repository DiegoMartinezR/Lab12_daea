namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v21 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Students");
            AddColumn("dbo.Students", "StundentID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Students", "Codigo", c => c.String(nullable: false));
            AddColumn("dbo.Students", "LastName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "FechaCreacion", c => c.DateTime());
            AddColumn("dbo.Students", "FechaModificacion", c => c.DateTime());
            AddColumn("dbo.Students", "Activo", c => c.Boolean());
            AddPrimaryKey("dbo.Students", "StundentID");
            DropColumn("dbo.Students", "studentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "studentID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Students");
            DropColumn("dbo.Students", "Activo");
            DropColumn("dbo.Students", "FechaModificacion");
            DropColumn("dbo.Students", "FechaCreacion");
            DropColumn("dbo.Students", "LastName");
            DropColumn("dbo.Students", "Codigo");
            DropColumn("dbo.Students", "StundentID");
            AddPrimaryKey("dbo.Students", "studentID");
        }
    }
}
