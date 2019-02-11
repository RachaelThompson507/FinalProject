using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockCommentRepository : ICommentRepository
    {
        private List<Comment> Comments = new List<Comment>();
        public Comment Create(Comment newComment)
        {
            newComment.Id = Comments.OrderByDescending(c => c.Id).Single().Id + 1;
            return newComment;
        }

        public bool DeleteById(int CommentId)
        {
            var calendar = GetById(CommentId);
            Comments.Remove(calendar);
            return true;
        }

        public Comment GetById(int CommentId)
        {
            return Comments.Single(c => c.Id == CommentId);
        }

        public ICollection<Comment> GetPostById(int postId)
        {
            return Comments.FindAll(c => c.PostId == postId);
        }

        public ICollection<Comment> GetRobinById(int robinId)
        {
            return Comments.FindAll(c => c.RobinId == robinId);
        }

        public ICollection<Comment> GetUserById(string userId)
        {
            return Comments.FindAll(c => c.UserId == userId);
        }

        public Comment Update(Comment updatedComment)
        {
            DeleteById(updatedComment.Id);
            Comments.Add(updatedComment);
            return updatedComment;
        }
    }
}
