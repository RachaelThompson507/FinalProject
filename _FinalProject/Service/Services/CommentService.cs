using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface ICommentService
    {
        //Create
        Comment Create(Comment newComment);

        //Read
        Comment GetById(int CommentId);
        ICollection<Comment> GetUserById(string userId);
        ICollection<Comment> GetRobinById(int robinId);
        ICollection<Comment> GetPostById(int postId);

        //Update
        Comment Update(Comment updatedComment);

        //Delete
        bool DeleteById(int CommentId);
    }

    public class CommentService : ICommentService
    {
        private readonly ICommentService _commentService;

        public CommentService(ICommentService commentService) =>
            _commentService = commentService;

        public Comment Create(Comment newComment) =>
            _commentService.Create(newComment);

        public bool DeleteById(int CommentId) =>
            _commentService.DeleteById(CommentId);

        public Comment GetById(int CommentId) =>
            _commentService.GetById(CommentId);

        public ICollection<Comment> GetPostById(int postId) =>
            _commentService.GetPostById(postId);

        public ICollection<Comment> GetRobinById(int robinId) =>
            _commentService.GetRobinById(robinId);

        public ICollection<Comment> GetUserById(string userId) =>
            _commentService.GetUserById(userId);

        public Comment Update(Comment updatedComment) =>
            _commentService.Update(updatedComment);
    }
}
