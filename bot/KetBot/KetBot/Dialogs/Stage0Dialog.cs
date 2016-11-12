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
            // Init state here
            KetBotState state = null;
            context.ConversationData.TryGetValue("KetBotState", out state);

            // if null, 
            if (state == null || state.CurrentStage != 0)
            {
                state = new KetBotState();
                context.ConversationData.SetValue("KetBotState", state);
            }

            // Greeting and First selection
            using (CommentService service = new CommentService(new KetBotContext()))
            {
                // Greeting
                await context.PostAsync(await service.GetCommentAsync("RGB01"));
                await context.PostAsync(await service.GetCommentAsync("RIB01"));
                // Question
                await context.PostAsync(await service.GetCommentAsync("RPB01"));
                // Category 1 
                var cat1 = await service.GetFormsAsync("0");
                await context.PostAsync(string.Join("\n", cat1.ToArray()));

                context.Done("");
            }
        }
        
    }
}