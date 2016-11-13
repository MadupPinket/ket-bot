using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using KetBot.Data.Services;
using Microsoft.Bot.Connector;
using KetBot.Data.Models;
using KetBot.Models;

namespace KetBot.Dialogs
{
    [Serializable]
    public class Stage2Dialog : IDialog<string>
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

                var cat2 = await service.GetFormsAsync(state.Stage0Selection);

                bool checkflag = false;
                int selected;
                if (int.TryParse(activity.Text, out selected) && selected > 0 && selected <= cat2.Count)
                {
                    checkflag = true;
                }

                if (checkflag == true)
                {
                    // save Stage1 selection
                    state.Stage1Selection = activity.Text;
                    // save state
                    context.ConversationData.SetValue("KetBotState", state);

                    // stage 2 question
                    var q = await service.GetCommentAsync("RCB01");
                    q = string.Format(q, cat2[selected - 1]);
                    var cat3 = await service.GetFormsAsync(state.Stage0Selection + state.Stage1Selection);
                    var cat3numbering = ListNumberingHelper.Numbering(cat3);
                    await context.PostAsync(q);
                    await context.PostAsync(string.Join("\n", cat3numbering.ToArray()));

                    context.Done("");

                }
                else
                {
                    // Go back to stage 0
                    // TODO : How to go back?
                    context.Call(new Stage1Dialog(), async (c, r) => { var s = await r; context.Done(""); });
                }
            }
        }
    }
}