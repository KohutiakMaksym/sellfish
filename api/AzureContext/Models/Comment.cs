using System;
using System.Collections.Generic;

#nullable disable

namespace AzureContext
{
    public partial class Comment
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentText { get; set; }

        public virtual User User { get; set; }
    }
}
