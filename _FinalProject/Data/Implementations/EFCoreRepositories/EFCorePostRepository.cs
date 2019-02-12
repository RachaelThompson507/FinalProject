using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCorePostRepository : IPostRepository
    {
        public Post Create(Post newPost)
        {
            using (var db = new FinalProjectDBContext())
            {
                db.Posts.Add(newPost);
                db.SaveChanges();
                return newPost;
            }
        }

        public bool DeleteById(int postId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var post = GetById(postId);
                db.Posts.Remove(post);
                db.SaveChanges();
                return true;
            }
        }

        public Post GetById(int postId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.Posts.Single(p => p.Id == postId);
            }
        }

        public ICollection<Post> GetRobinById(int robinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var robinPost = db.Posts.Where(p => p.RobinId == robinId).ToList() as ICollection<Post>;
                return robinPost;
            }
        }

        public ICollection<Post> GetUserById(string userId)
        {
            var userPost = db.Posts.Where(p => p.UserId == userId).ToList() as ICollection<Post>;
            return userPost;
        }

        public Post Update(Post updatedPost)
        {
            using (var db = new FinalProjectDBContext())
            {
                var update = GetById(updatedPost.Id);
                db.Entry(update).CurrentValues.SetValues(updatedPost);
                db.SaveChanges();
                return update;
            }
        }
    }
}
