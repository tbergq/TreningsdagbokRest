namespace Treningsdagbok.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProgramEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Days",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        WeekId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Weeks", t => t.WeekId, cascadeDelete: true)
                .Index(t => t.WeekId);
            
            CreateTable(
                "dbo.Weeks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ProgramId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Programs", t => t.ProgramId, cascadeDelete: true)
                .Index(t => t.ProgramId);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DayExercises",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExerciseId = c.Int(nullable: false),
                        MinimumRepetitions = c.Int(nullable: false),
                        MaximumRepetitions = c.Int(),
                        MinimumSets = c.Int(nullable: false),
                        MaximumSets = c.Int(),
                        Pause = c.Int(nullable: false),
                        Description = c.String(),
                        DayId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Days", t => t.DayId, cascadeDelete: true)
                .ForeignKey("dbo.Exercises", t => t.ExerciseId, cascadeDelete: true)
                .Index(t => t.ExerciseId)
                .Index(t => t.DayId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DayExercises", "ExerciseId", "dbo.Exercises");
            DropForeignKey("dbo.DayExercises", "DayId", "dbo.Days");
            DropForeignKey("dbo.Days", "WeekId", "dbo.Weeks");
            DropForeignKey("dbo.Weeks", "ProgramId", "dbo.Programs");
            DropIndex("dbo.DayExercises", new[] { "DayId" });
            DropIndex("dbo.DayExercises", new[] { "ExerciseId" });
            DropIndex("dbo.Weeks", new[] { "ProgramId" });
            DropIndex("dbo.Days", new[] { "WeekId" });
            DropTable("dbo.DayExercises");
            DropTable("dbo.Programs");
            DropTable("dbo.Weeks");
            DropTable("dbo.Days");
        }
    }
}
