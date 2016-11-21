using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetBot.Data.ViewModels
{
    public class TranslatorEntity : TableEntity
    {
        public TranslatorEntity(string channelId, string conversationId, string replyId)
        {
            this.PartitionKey = channelId + "-" + conversationId;
            this.RowKey = replyId;
        }

        public TranslatorEntity() { }

        public string OriginText { get; set; }

        public string TranlateText { get; set; }

        public string Intent { get; set; }

        public string Entity { get; set; }
    }
}
