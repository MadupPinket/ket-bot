using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using KetBot.Models;
using Microsoft.Rest;
using System.Configuration;
using KetBot.Data.Models;
using KetBot.Data.Services;

namespace KetBot.Dialogs
{
    [Serializable]
    public class KetBotDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> argument)
        {
            using (CommentService service = new CommentService(new KetBotContext()))
            {
                var activity = await argument;

                // Get Current State.
                KetBotState state = null;
                context.ConversationData.TryGetValue("KetBotState", out state);

                // if null, make state and set
                if (state == null)
                {
                    state = new KetBotState();
                    context.ConversationData.SetValue("KetBotState", state);
                }

                switch (state.CurrentStage)
                {
                    case 0:
                        // Greeting
                        await context.PostAsync(await service.GetCommentAsync("RGB01"));
                        await context.PostAsync(await service.GetCommentAsync("RIB01"));
                        // Question
                        await context.PostAsync(await service.GetCommentAsync("RPB01"));
                        // Category 1 
                        var cat1 = await service.GetFormsAsync("0");
                        await context.PostAsync(string.Join("\n", cat1.ToArray()));
                        state.CurrentStage = 1;
                        context.Done("");
                        break;

                    case 1:
                        // prev list
                        var cat1list = await service.GetFormsAsync("0");
                        // check right selection 
                        var s2text = activity.Text.Trim();
                        int s2select;
                        if (int.TryParse(s2text, out s2select))
                        {
                            if(s2select >= cat1list.Count || s2select <= 0)
                            {

                            }
                        }
                        else
                        {

                        }

                        // stage 1 question
                        var cat2 = await service.GetCommentAsync("RCB01");

                        break;
                    default:
                        break;
                }
            }
        }

        private async Task AfterResetAsync(IDialogContext context, IAwaitable<string> result)
        {
            var selection = await result;

            var state = context.ConversationData.Get<KetBotState>("KetBotState");

            state.CurrentStage += 1;
            state.Stage1Selection = selection;

            context.ConversationData.SetValue("KetBotState", state);


            //context.Wait(MessageReceivedAsync);
        }

    }
}