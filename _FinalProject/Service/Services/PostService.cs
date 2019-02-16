using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface IPostService
    {
        //Create
        Post Create(Post newPost);

        //Read
        Post GetById(int postId);
        ICollection<Post> GetUserById(string userId);
        ICollection<Post> GetRobinById(int robinId);

        //Update
        Post Update(Post updatedPost);

        //Delete
        bool DeleteById(int postId);
    }

    public class PostService : IPostService
    {
        private readonly IPostService _postService;

        public PostService(IPostService postService) =>
            _postService = postService;

        public Post Create(Post newPost) =>
            _postService.Create(newPost);

        public bool DeleteById(int postId) =>
            _postService.DeleteById(postId);

        public Post GetById(int postId) =>
            _postService.GetById(postId);

        public ICollection<Post> GetRobinById(int robinId) =>
            _postService.GetRobinById(robinId);

        public ICollection<Post> GetUserById(string userId) =>
            _postService.GetUserById(userId);

        public Post Update(Post updatedPost) =>
            _postService.Update(updatedPost);
    }
}
