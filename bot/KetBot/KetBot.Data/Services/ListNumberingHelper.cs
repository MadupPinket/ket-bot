using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetBot.Data.Services
{
    public static class ListNumberingHelper
    {
        public static List<string> Numbering(List<string> list)
        {
            if (list == null || list.Count == 0) return list;

            for(int i = 1; i <= list.Count; i++)
            {
                list[i - 1] = i.ToString() + ". " + list[i - 1];
            }
            return list;
        }
    }
}
