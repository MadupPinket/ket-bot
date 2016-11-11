using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetBot.Data.Models
{
    public class Answer
    {
        [Key]
        public long Id { get; set; }

        [Index]
        [Required]
        public int Order { get; set; }

        public string Text { get; set; }

        public ExecutiveQuestion Question { get; set; }

        public long QuestionId { get; set; }
    }
}
