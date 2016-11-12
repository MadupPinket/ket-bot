using KetBot.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KetBot.Data.Services
{
    public class CommentService : ICommentService, IDisposable
    {
        private KetBotContext DbContext;

        public CommentService(KetBotContext dbContext)
        {
            this.DbContext = dbContext;
        }

         public async Task<string> GetCommentAsync(string code)
        {
            string comment;

            var def = await this.DbContext.CommentDefinitions.Include(x => x.Comments)
                .Where(x => x.Code == code)
                .Select(x => x.Comments).FirstOrDefaultAsync();
            if (def != null)
            {
                Random rnd = new Random();
                int r = rnd.Next(def.Count);
                comment = def.ToList()[r].Text;
            }
            else
            {
                comment = "errors: comment is null.";
            }
            return comment;
        }

        public async Task<List<string>> GetFormsAsync(string code)
        {
            var msg = await this.DbContext.SelectiveForms.Where(x => x.Code == code).Select(x => x.Form).FirstOrDefaultAsync();
            List<string> options = msg.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();  
            return options;
        }

        public async Task<List<string>> GetAnswerAsync(string code)
        {
            var answers = await this.DbContext.ExecutiveQuestions.Include(x => x.Answers)
                .Where(x => x.Code == code)
                .Select(x => x.Answers).FirstOrDefaultAsync();
            return answers.Select(x => x.Text).ToList();
        }

        public void Dispose()
        {
            this.DbContext.Dispose();
        }
    }
}
