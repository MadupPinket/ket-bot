using KetBot.Data.Models;
using KetBot.Data.Services;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace KetBot.Dialogs
{
    [LuisModel("53dd7fe5-809f-49b4-96ac-42e9645bcff8", "4052566a176a42f6ad3b88d4e86c243f")]
    [Serializable]
    public class KetBotLuisDialog: LuisDialog<string>
    {
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("말씀하신 내용을 잘 못알아 들었습니다. \"처음부터\"를 입력하시면 궁금하신 내용에 대해서 차근차근 물어볼께요.");
            context.Wait(MessageReceived);
        }

        //protected override async Task MessageReceived(IDialogContext context, IAwaitable<IMessageActivity> item)
        //{
        //    // TODO: Tranlator Text API 

        //    base.MessageReceived(context, item);
        //}

        [LuisIntent("Point")]
        public async Task Point(IDialogContext context, LuisResult result)
        {
            if (result.Entities == null || result.Entities.Count == 0)
            {
                await QueriesAboutQuestionAsync(context);
            }
            else
            {
                switch (result.Entities.OrderByDescending(x => x.Score).Select(x => x.Entity).FirstOrDefault())
                {
                    case "Error":
                        await GetAnswersAsync(context, "114");
                        break;
                    case "accidentally integration":
                        await GetAnswersAsync(context, "121");
                        break;
                    case "Cancel":
                        await GetAnswersAsync(context, "122");
                        break;
                    case "credit card":
                        await GetAnswersAsync(context, "131");
                        break;
                    case "move":
                        await GetAnswersAsync(context, "132");
                        break;
                    case "opt out":
                        await GetAnswersAsync(context, "141");
                        break;
                    case "how to use":
                        await GetAnswersAsync(context, "211");
                        break;
                    case "gone":
                        await GetAnswersAsync(context, "142");
                        break;
                    case "saving":
                        await GetAnswersAsync(context, "311");
                        break;
                    case "too small":
                        await GetAnswersAsync(context, "321");
                        break;
                    case "Lock Screen":
                        await GetAnswersAsync(context, "748");
                        break;
                    default:
                        await QueriesAboutQuestionAsync(context);
                        break;
                }
            }
        }

        private async Task QueriesAboutQuestionAsync(IDialogContext context)
        {
            await context.PostAsync("포인트 관련 질문을 하셨는데 잘 알아듣지 못했습니다.");
            await context.PostAsync("아래 질문 중에 있으면 선택해 주세요.");
            List<string> codes = new List<string> { "114", "121", "122", "131", "132", "141", "211", "142", "311", "321", "748"};

            if (!context.ConversationData.ContainsKey("PointsQuestionCodes"))
                    context.ConversationData.SetValue("PointsQuestionCodes", codes);

            using (CommentService service = new CommentService(new KetBotContext()))
            {
                // questions 
                var quesitons = await service.GetQuestionsByCode(codes);

                PromptDialog.Number(context, SelectComplete, string.Join("\n", ListNumberingHelper.Numbering(quesitons.Select(x => x.Question).ToList())));
            }
        }

        private async Task SelectComplete(IDialogContext context, IAwaitable<long> result)
        {
            using (CommentService service = new CommentService(new KetBotContext()))
            {
                var selected = await result;

                List<string> codes = null;
                context.ConversationData.TryGetValue("PointsQuestionCodes", out codes);

                // questions 
                var quesitons = await service.GetQuestionsByCode(codes);

                // final answers 
                var answers = await service.GetAnswerAsync(quesitons.Where(x => x.Number == selected).Select(x => x.Code).FirstOrDefault());
                await context.PostAsync(string.Join("\n", answers.ToArray()));
            }

            context.Wait(MessageReceived);
        }

        [LuisIntent("Indentity Verification")]
        public async Task IdentityVerification(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "112");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Membership Card")]
        public async Task MembershipCard(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "411");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Credit Card")]
        public async Task CreditCard(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "412");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Bar Code")]
        public async Task BarCode(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "413");
            context.Wait(MessageReceived);
        }


        //[LuisIntent("Goods")]
        //public async Task Goods(IDialogContext context, LuisResult result)
        //{
        //    switch (result.Entities.OrderByDescending(x => x.Score).Select(x => x.Entity).FirstOrDefault())
        //    {
        //        case "How to use":
        //            await GetAnswersAsync(context, "511");
        //            break;
        //        case "exchange":
        //            await GetAnswersAsync(context, "513");
        //            break;
        //        default:
        //            // TODO : Question Again

        //            break;
        //    }
        //    context.Wait(MessageReceived);
        //}

        //[LuisIntent("History")]
        //public async Task History(IDialogContext context, LuisResult result)
        //{
        //    await GetAnswersAsync(context, "512");
        //    context.Wait(MessageReceived);
        //}

        //[LuisIntent("Store")]
        //public async Task Store(IDialogContext context, LuisResult result)
        //{
        //    await GetAnswersAsync(context, "514");
        //    context.Wait(MessageReceived);
        //}

        [LuisIntent("Gift Card")]
        public async Task GiftCard(IDialogContext context, LuisResult result)
        {
            switch (result.Entities.OrderByDescending(x => x.Score).Select(x => x.Entity).FirstOrDefault())
            {
                case "Happy money":
                    await GetAnswersAsync(context, "515");
                    break;
                case "How to use":
                    await GetAnswersAsync(context, "521");
                    break;
                case "How to receive":
                    await GetAnswersAsync(context, "522");
                    break;
                case "Expired":
                    await GetAnswersAsync(context, "523");
                    break;
                default:
                    // TODO : Question Again

                    break;
            }
            context.Wait(MessageReceived);
        }

        [LuisIntent("Mobile Voucher")]
        public async Task MobileVoucher(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "524");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Application Error")]
        public async Task ApplicationError(IDialogContext context, LuisResult result)
        {
            switch (result.Entities.OrderByDescending(x => x.Score).Select(x => x.Entity).FirstOrDefault())
            {
                case "Screen Stop":
                    await GetAnswersAsync(context, "611");
                    break;
                case "toggle button":
                    await GetAnswersAsync(context, "111");
                    break;
                case "Lock Screen":
                    await GetAnswersAsync(context, "747");
                    break;
                default:
                    // TODO : Question Again

                    break;
            }
            context.Wait(MessageReceived);
        }

        //[LuisIntent("Suggestion")]
        //public async Task Suggestion(IDialogContext context, LuisResult result)
        //{
        //    await GetAnswersAsync(context, "711");
        //    context.Wait(MessageReceived);
        //}

        [LuisIntent("Unsubscribe")]
        public async Task Unsubscribe(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "721");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Membership Point")]
        public async Task MembershipPoint(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "414");
            context.Wait(MessageReceived);
        }

        [LuisIntent("CAPTCHA")]
        public async Task CAPTCHA(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "113");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Change Phone")]
        public async Task ChangePhone(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "722");
            context.Wait(MessageReceived);
        }

        [LuisIntent("Account")]
        public async Task Account(IDialogContext context, LuisResult result)
        {
            switch (result.Entities.OrderByDescending(x => x.Score).Select(x => x.Entity).FirstOrDefault())
            {
                case "Log in":
                    await GetAnswersAsync(context, "741");
                    break;
                case "Log out":
                    await GetAnswersAsync(context, "742");
                    break;
                case "Forgot Password":
                    await GetAnswersAsync(context, "743");
                    break;
                case "Chage ID":
                    await GetAnswersAsync(context, "744");
                    break;
                case "Change Password":
                    await GetAnswersAsync(context, "745");
                    break;
                case "Change Name":
                    await GetAnswersAsync(context, "746");
                    break;
                default:
                    // TODO : Question Again

                    break;
            }
            context.Wait(MessageReceived);
        }

        //[LuisIntent("How to use")]
        //public async Task HowToUse(IDialogContext context, LuisResult result)
        //{
        //    await GetAnswersAsync(context, "749");
        //    context.Wait(MessageReceived);
        //}

        [LuisIntent("CS center")]
        public async Task CScenter(IDialogContext context, LuisResult result)
        {
            await GetAnswersAsync(context, "751");
            context.Wait(MessageReceived);
        }

        private async Task GetAnswersAsync(IDialogContext context, string code)
        {
            using (CommentService service = new CommentService(new KetBotContext()))
            {
                var answers = await service.GetAnswerAsync(code);
                await context.PostAsync(string.Join("\n", answers.ToArray()));
                context.Wait(MessageReceived);
            }
        }
    }
}