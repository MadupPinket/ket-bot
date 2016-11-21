using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetBot.Data.Services
{
    public interface ITableService<T>
    {
        string TableBaseUrl { get; }

        Task CreateTableAsync(string tablename);

        Task AddMessageAsync(string tablename, T message);
    }
}
