using System;
using System.Collections.Generic;

namespace CommunityPortal.Models.Data
{
    public interface INewsRepo
    {
        Post Create(string body, string title);
        List<Post> Read();
        Post Read(int id);
        Post Update(Post post);
        bool Delete(Post post);
    }
}
