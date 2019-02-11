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
        ICollection<Comment> GetUserById(string userId);
        ICollection<Comment> GetRobinById(int robinId);
        ICollection<Comment> GetPostById(int postId);

        //Update
        Comment Update(Comment updatedComment);

        //Delete
        bool DeleteById(int CommentId);
    }
}
