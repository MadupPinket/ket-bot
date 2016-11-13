using KetBot.Data.Models;
using KetBot.Data.Services;
using KetBot.Models;
using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace KetBot.Dialogs
{
    [Serializable]
    public class StageDialog : IDialog<string>
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

            using (CommentService service = new CommentService(new KetBotContext()))
            {
                // Greeting
                await context.PostAsync(await service.GetCommentAsync("RGB01"));
                await context.PostAsync(await service.GetCommentAsync("RIB01"));
                context.Done("");
            }
        }
    }
}