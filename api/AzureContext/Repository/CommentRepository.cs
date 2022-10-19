using AzureContext;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public readonly sellfish_dbContext _context;
        public CommentRepository(sellfish_dbContext context)
        {
            _context = context;
        }

        public bool AddComment(Comment Comment)
        {
            _context.Comments.Add(Comment);
            Save();
            return true;
        }

        public ICollection<Comment> GetComments()
        {
            return _context.Comments.ToList();
        }

        public Comment GetComment(int Id)
        {
            return _context.Comments.FirstOrDefault(o => o.Id == Id);
        }

        public bool Save()
        {
            var IsSaved = _context.SaveChanges();

            return IsSaved > 0 ? true : false;
        }

        public bool UpdateComment(Comment Comment)
        {
            _context.Comments.Add(Comment);
            return Save();
        }

        public bool DeleteComment(int Id)
        {
            var comment = _context.Comments.FirstOrDefault(o => o.Id == Id);
            _context.Comments.Remove(comment);
            return Save();
        }
    }
}
