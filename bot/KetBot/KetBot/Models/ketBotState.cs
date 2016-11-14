using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KetBot.Models
{
    public class KetBotState
    {
        /// <summary>
        /// 현재 스탭/상황/Depth
        /// </summary>
        public string Stage0Selection { get; set; }

        public string Stage1Selection { get; set; }

        public string Stage2Selection { get; set; }
    }
}