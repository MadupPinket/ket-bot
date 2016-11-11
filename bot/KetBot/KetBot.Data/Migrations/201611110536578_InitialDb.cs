namespace KetBot.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        Text = c.String(),
                        QuestionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExecutiveQuestions", t => t.QuestionId, cascadeDelete: true)
                .Index(t => t.Order)
                .Index(t => t.QuestionId);
            
            CreateTable(
                "dbo.ExecutiveQuestions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 20),
                        Keyword = c.String(),
                        Question = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.CommentDefinitions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 20),
                        Definition = c.String(),
                        Owner = c.String(),
                        Catetory = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Text = c.String(),
                        DefinitionId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CommentDefinitions", t => t.DefinitionId, cascadeDelete: true)
                .Index(t => t.DefinitionId);
            
            CreateTable(
                "dbo.SelectiveForms",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 20),
                        Form = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Code, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "DefinitionId", "dbo.CommentDefinitions");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.ExecutiveQuestions");
            DropIndex("dbo.SelectiveForms", new[] { "Code" });
            DropIndex("dbo.Comments", new[] { "DefinitionId" });
            DropIndex("dbo.CommentDefinitions", new[] { "Code" });
            DropIndex("dbo.ExecutiveQuestions", new[] { "Code" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropIndex("dbo.Answers", new[] { "Order" });
            DropTable("dbo.SelectiveForms");
            DropTable("dbo.Comments");
            DropTable("dbo.CommentDefinitions");
            DropTable("dbo.ExecutiveQuestions");
            DropTable("dbo.Answers");
        }
    }
}
