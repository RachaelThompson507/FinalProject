using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
   public interface IPostRepository
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
}
