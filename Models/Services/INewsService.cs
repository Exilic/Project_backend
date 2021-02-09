using System;
using System.Collections.Generic;
using CommunityPortal.Models.ViewModels;

namespace CommunityPortal.Models.Services
{
    public interface INewsService
    {
        Post Add(CreatePostViewModel createPostViewModel);
        List<Post> All();
        Post FindBy(int id);
        Post Edit(int id, CreatePostViewModel post);
        Post Remove(int id);
    }
}
