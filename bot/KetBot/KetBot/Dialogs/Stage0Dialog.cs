using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using KetBot.Data.Services;
using KetBot.Data.Models;
using KetBot.Models;

namespace KetBot.Dialogs
{
    [Serializable]
    public class Stage0Dialog : IDialog<string>
    {
        public async Task StartAsync(IDialogContext context)
        {
            // First Question and selection
            using (CommentService service = new CommentService(new KetBotContext()))
            {
                // Question
                await context.PostAsync(await service.GetCommentAsync("RPB01"));
                // Category 1 
                var cat1 = await service.GetFormsAsync("0");

                var cat1numbering = ListNumberingHelper.Numbering(cat1);
                await context.PostAsync(string.Join("\n", cat1numbering.ToArray()));

                context.Done("");
            }
        }
        
    }
}