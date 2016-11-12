using Microsoft.Bot.Builder.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.Bot.Connector;
using Microsoft.Rest;
using System.Configuration;
using KetBot.Models;
using System.Text.RegularExpressions;
using KetBot.Data.Services;
using KetBot.Data.Models;

namespace KetBot.Dialogs
{
    [Serializable]
    public class KetBotChainDialog 
    {
        public static readonly IDialog<string> dialog = Chain
            .PostToChain()
            //.Select(p => p.Text)
            .Switch(
                new Case<IMessageActivity, IDialog<string>>((msg) =>
                {
                    var regex = new Regex("^start", RegexOptions.IgnoreCase);
                    return regex.IsMatch(msg.Text);
                }, (ctx, msg) =>
                {
                    // User wants to login, send the message to Facebook Auth Dialog
                    return Chain.From(() => new Stage0Dialog())
                            .ContinueWith<string,string>(async (context, result) =>
                            {
                                var s0result = await result;
                                return Chain.ContinueWith(new Stage1Dialog(), async (c1, r1) =>
                                {
                                    var s1result = await r1;
                                    return Chain.ContinueWith(new Stage2Dialog(), async (c2, r2) =>
                                    {
                                        var s2result = await r2;
                                        return Chain.ContinueWith(new Stage3Dialog(), async (c3, r3) =>
                                        {
                                            var s3resutl = await r3;
                                            return Chain.Return(s3resutl); // good bye
                                        });
                                    });
                                });
                            });

                }),
                new DefaultCase<IMessageActivity, IDialog<string>>((ctx, msg) =>
                {
                    return Chain.Return("어떤 말씀이신지?");
                }
            ))
            .Unwrap()
            .PostToUser();
    }
}