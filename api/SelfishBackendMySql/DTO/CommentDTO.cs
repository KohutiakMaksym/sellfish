using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfishBackendMySql.DTO
{
    public class CommentDTO
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }
    }
}
