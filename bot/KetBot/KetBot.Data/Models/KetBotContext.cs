using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KetBot.Data.Models
{
    public class KetBotContext : DbContext
    {
        public KetBotContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<ExecutiveQuestion> ExecutiveQuestions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<CommentDefinition> CommentDefinitions { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<SelectiveForm> SelectiveForm { get; set; }

        public static KetBotContext Create()
        {
            return new KetBotContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ExecutiveQuestion>().ToTable("ExecutiveQuestions");
            modelBuilder.Entity<ExecutiveQuestion>().Property(t => t.Code).IsRequired();

            modelBuilder.Entity<Answer>().ToTable("Answers");
            modelBuilder.Entity<Answer>().Property(t => t.Order).IsRequired();
            modelBuilder.Entity<Answer>().HasRequired(t => t.Question).WithMany(t => t.Answers).HasForeignKey(t => t.QuestionId).WillCascadeOnDelete(true);

            modelBuilder.Entity<CommentDefinition>().ToTable("CommentDefinitions");
            modelBuilder.Entity<CommentDefinition>().Property(t => t.Code).IsRequired();

            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Comment>().HasRequired(t => t.Definition).WithMany(t => t.Comments).HasForeignKey(t => t.DefinitionId).WillCascadeOnDelete(true);

            modelBuilder.Entity<SelectiveForm>().ToTable("SelectiveForms");
            modelBuilder.Entity<SelectiveForm>().Property(t => t.Code).IsRequired();
        }

    }
}
