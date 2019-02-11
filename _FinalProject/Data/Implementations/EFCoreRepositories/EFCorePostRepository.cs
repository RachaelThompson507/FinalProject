using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCorePostRepository : IPostRepository
    {
        public Post Create(Post newPost)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int postId)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int postId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Post> GetRobinById(int robinId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Post> GetUserById(string userId)
        {
            throw new NotImplementedException();
        }

        public Post Update(Post updatedPost)
        {
            throw new NotImplementedException();
        }
    }
}
