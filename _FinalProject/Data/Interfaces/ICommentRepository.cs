using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
   public interface ICommentRepository
    {
        //Create
        Comment Create(Comment newComment);

        //Read
         Comment GetById(int CommentId);
        ICollection<User> GetUserById(string userId);
        ICollection<Robin> GetRobinById(int robinId);
        ICollection<Post> GetPostById(string postId);

        //Update
        Comment Update(Comment updatedComment);

        //Delete
        bool DeleteById(int CommentId);
    }
}
