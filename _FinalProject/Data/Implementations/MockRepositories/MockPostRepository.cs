using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockPostRepository : IPostRepository
    {
        private List<Post> Posts = new List<Post>();
        public Post Create(Post newPost)
        {
            newPost.Id = Posts.OrderByDescending(c => c.Id).Single().Id + 1;
            return newPost;
        }

        public bool DeleteById(int postId)
        {
            var post = GetById(postId);
            Posts.Remove(post);
            return true;
        }

        public Post GetById(int postId)
        {
            return Posts.Single(p => p.Id == postId);
        }

        public ICollection<Post> GetRobinById(int robinId)
        {
            return Posts.FindAll(p => p.RobinId == robinId);
        }

        public ICollection<Post> GetUserById(string userId)
        {
            return Posts.FindAll(p => p.UserId == userId);
        }

        public Post Update(Post updatedPost)
        {
            DeleteById(updatedPost.Id);
            Posts.Add(updatedPost);
            return updatedPost;
        }
    }
}
