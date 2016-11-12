using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetBot.Data.Services
{
    public interface ICommentService
    {
        Task<string> GetCommentAsync(string code);

        Task<List<string>> GetFormsAsync(string code);

        Task<List<string>> GetAnswerAsync(string code);
    }
}
