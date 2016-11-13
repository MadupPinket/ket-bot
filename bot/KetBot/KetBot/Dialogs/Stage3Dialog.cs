using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using KetBot.Data.Services;
using KetBot.Data.Models;
using Microsoft.Bot.Connector;
using KetBot.Models;

namespace KetBot.Dialogs
{
    [Serializable]
    public class Stage3Dialog : IDialog<string>
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

                // get state 
                KetBotState state = null;
                context.ConversationData.TryGetValue("KetBotState", out state);

                var cat3 = await service.GetFormsAsync(state.Stage1Selection);

                bool checkflag = false;
                int selected;
                if (int.TryParse(activity.Text, out selected) && selected > 0 && selected <= cat3.Count)
                {
                    checkflag = true;
                }

                if (checkflag == true)
                {
                    // save Stage1 selection
                    state.Stage2Selection = activity.Text;
                    // save state
                    context.ConversationData.SetValue("KetBotState", state);

                    // final answers 
                    var answers = await service.GetAnswerAsync(state.Stage0Selection + state.Stage1Selection + state.Stage2Selection);
                    await context.PostAsync(string.Join("\n", answers.ToArray()));

                    var q = await service.GetCommentAsync("RCB02");
                    List<string> yesno = new List<string>() { "네, 맞아요!", "아닌데요?" };

                    PromptDialog.Choice(context, AfterChoiceAsync, yesno, q, promptStyle: PromptStyle.Keyboard);


                }
                else
                {
                    // Go back to stage 2
                    await context.PostAsync(await service.GetCommentAsync("REB01"));
                    await context.PostAsync(string.Join("\n", cat3.ToArray()));
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
                    // good bye RBB01
                    var bye = await service.GetCommentAsync("RBB01");

                    // go next
                    context.Done(bye);
                }
            }
            else if (selection == "아닌데요?")
            {
                // go back
                //context.Call(new Stage0Dialog(), null);
                await context.PostAsync("처음으로 갈께요.");
            }
        }

        //private async Task AfterGoBackAsync(IDialogContext context, IAwaitable<string> result)
        //{

        //    var s = await result;
        //    context.Wait(MessageReceivedAsync);
        //}

    }
}