using AzureContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ICommentRepository
    {
        public ICollection<Comment> GetComments();

        public Comment GetComment(int Id);

        public bool AddComment(Comment Comment);
        public bool UpdateComment(Comment Comment); 
        public bool DeleteComment(int Id);

        public bool Save();
    }
}
