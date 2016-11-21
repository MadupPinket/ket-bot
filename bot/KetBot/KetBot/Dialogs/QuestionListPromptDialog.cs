using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using KetBot.Data.Models;
using KetBot.Data.Services;
using KetBot.ViewModels;
using Microsoft.Bot.Connector;

namespace KetBot.Dialogs
{
    public class QuestionListPromptDialog : IDialog<string>
    {
        public List<string> Codes;
        public List<QuestionCode> QuestionCodes;
        public QuestionListPromptDialog(List<string> codes)
        {
            Codes = codes;
        }

        public async Task StartAsync(IDialogContext context)
        {
            using (CommentService service = new CommentService(new KetBotContext()))
            {
                // questions 
                QuestionCodes = await service.GetQuestionsByCode(Codes);
                await context.PostAsync(string.Join("\n", QuestionCodes.Select(x => x.Question)));

                context.Wait(MessageReceivedAsync);
            }
        }
        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> argument)
        {
            using (CommentService service = new CommentService(new KetBotContext()))
            {
                var activity = await argument;

                bool checkflag = false;
                int selected;
                if (int.TryParse(activity.Text, out selected) && selected > 0 && selected <= QuestionCodes.Count)
                {
                    checkflag = true;
                }

                // right selection
                if (checkflag == true)
                {
                    // final answers 
                    var answers = await service.GetAnswerAsync(QuestionCodes.Where(x => x.Number == selected).Select(x => x.Code).FirstOrDefault());
                    await context.PostAsync(string.Join("\n", answers.ToArray()));

                    context.Done("");
                }
                else
                {
                    await context.PostAsync("숫자로 선택해주세요.");
                    await context.PostAsync(string.Join("\n", QuestionCodes.Select(x => x.Question)));

                    context.Wait(MessageReceivedAsync);
                }
            }
        }
    }
}