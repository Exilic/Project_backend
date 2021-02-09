using System;
using System.Collections.Generic;

namespace CommunityPortal.Models.Data
{
    public class DatabaseNewsRepo : INewsRepo
    {

        public Post Create(string body, string title)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post> Read()
        {
            throw new NotImplementedException();
        }

        public Post Read(int id)
        {
            throw new NotImplementedException();
        }

        public Post Update(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
