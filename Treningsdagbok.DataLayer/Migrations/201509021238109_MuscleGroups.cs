namespace Treningsdagbok.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MuscleGroups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MuscleGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Exercises", "MuscleGroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.Exercises", "MuscleGroupId");
            AddForeignKey("dbo.Exercises", "MuscleGroupId", "dbo.MuscleGroups", "Id", cascadeDelete: true);
            DropColumn("dbo.Exercises", "MuscleGroup");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exercises", "MuscleGroup", c => c.Int(nullable: false));
            DropForeignKey("dbo.Exercises", "MuscleGroupId", "dbo.MuscleGroups");
            DropIndex("dbo.Exercises", new[] { "MuscleGroupId" });
            DropColumn("dbo.Exercises", "MuscleGroupId");
            DropTable("dbo.MuscleGroups");
        }
    }
}
