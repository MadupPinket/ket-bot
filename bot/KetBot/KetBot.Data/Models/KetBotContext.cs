using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KetBot.Data.Models
{
    public class KetBotContext : DbContext
    {
        public KetBotContext()
            : base("DefaultConnection")
        {
        }

        public static KetBotContext Create()
        {
            return new KetBotContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

    }
}
