using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using KetBot.Models;
using KetBot.Data.Services;
using KetBot.Data.Models;

namespace KetBot.Dialogs
{
    [Serializable]
    public class Stage1Dialog : IDialog<string>
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

                // Check here the right value of the Stage 0
                var cat1 = await service.GetFormsAsync("0");

                bool checkflag = false;
                int selected;
                if (int.TryParse(activity.Text, out selected) && selected > 0 && selected <= cat1.Count)
                {
                    checkflag = true;
                }

                if (checkflag == true)
                {
                    // The result of stage 0
                    // Get Current State.
                    KetBotState state = null;
                    context.ConversationData.TryGetValue("KetBotState", out state);

                    // save Stage0 selection
                    state.Stage0Selection = activity.Text;

                    // save state
                    context.ConversationData.SetValue("KetBotState", state);

                    // stage 1 question
                    var cat2 = await service.GetCommentAsync("RCB01");
                    var q = string.Format(cat2, cat1[selected - 1]);

                    List<string> yesno = new List<string>() { "네, 맞아요!", "아닌데요?" };

                    PromptDialog.Choice(context, AfterChoiceAsync, yesno, q, promptStyle: PromptStyle.Keyboard);
                }
                else
                {
                    // Go back to stage 0
                    // How to go back?
                    await context.PostAsync(await service.GetCommentAsync("REB01"));
                    await context.PostAsync(string.Join("\n", cat1.ToArray()));
                    context.Wait(MessageReceivedAsync);
                }
            }
        }
        private async Task AfterChoiceAsync(IDialogContext context, IAwaitable<string> result)
        {
            var selection = await result;

            if (selection == "네, 맞아요!")
            {
                using (CommentService service = new CommentService(new KetBotContext()))
                {
                    await context.PostAsync(await service.GetCommentAsync("RPB02"));
                    // get state
                    KetBotState state = null;
                    // category 2 question
                    context.ConversationData.TryGetValue("KetBotState", out state);
                    // category 2 list
                    var cat2 = await service.GetFormsAsync(state.Stage0Selection);
                    var cat2numbering = ListNumberingHelper.Numbering(cat2);
                    await context.PostAsync(string.Join("\n", cat2numbering.ToArray()));

                    // go next
                    context.Done("");
                }
            }
            else if (selection == "아닌데요?")
            {
                // go back
                context.Call(new Stage0Dialog(), async (c, r) => 
                {
                    var s = await r;
                    //context.Done("");
                    context.Wait(MessageReceivedAsync);
                });
            }
        }
    }
}