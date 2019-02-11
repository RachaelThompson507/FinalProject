using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreCommentRepository : ICommentRepository
    {
        public Comment Create(Comment newComment)
        {
            using (var db = new FinalProjectDBContext())
            {
                db.Comments.Add(newComment);
                db.SaveChanges();
                return newComment;
            }
        }

        public bool DeleteById(int CommentId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var comment = GetById(CommentId);
                db.Comments.Remove(comment);
                db.SaveChanges();
                return true;
            }
        }

        public Comment GetById(int CommentId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.Comments.Single(c => c.Id == CommentId);
            }
        }

        public ICollection<Comment> GetPostById(int postId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var posts = db.Comments.Where(c => c.PostId == postId).ToList() as ICollection<Comment>;
                return posts;
            }
        }

        public ICollection<Comment> GetRobinById(int robinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var robinPost = db.Comments.Where(c => c.RobinId == robinId).ToList() as ICollection<Comment>;
                return robinPost;
            }
        }

        public ICollection<Comment> GetUserById(string userId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var userPost = db.Comments.Where(c => c.UserId == userId).ToList() as ICollection<Comment>;
                return userPost;
            }
        }

        public Comment Update(Comment updatedComment)
        {
            using (var db = new FinalProjectDBContext())
            {
                var update = GetById(updatedComment.Id);
                db.Entry(update).CurrentValues.SetValues(updatedComment);
                db.SaveChanges();
                return update;
            }
        }
    }
}
