using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockCommentRepository : ICommentRepository
    {
        public Comment Create(Comment newComment)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int CommentId)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int CommentId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Comment> GetPostById(string postId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Comment> GetRobinById(int robinId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Comment> GetUserById(string userId)
        {
            throw new NotImplementedException();
        }

        public Comment Update(Comment updatedComment)
        {
            throw new NotImplementedException();
        }
    }
}
