using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using BlogWEBAPI.Models.ViewModels;
using System;

namespace BlogWEBAPI.EFUtilities
{
    public sealed class BlogDBRepository
    {
        private static BlogDBContext dbcontext = new BlogDBContext();
        private static BlogDBRepository BlogdbRepository = null;
        private BlogDBRepository() {}
        public static BlogDBRepository BlogRepositorInstance
        {
            get
            {
                if (BlogdbRepository == null)
                {
                    return new BlogDBRepository();
                }
                return BlogdbRepository;
            }
        }
        public PostViewModel GetPost(int id) {
            return AutoMapper.Mapper.Map<blog_post,PostViewModel>(dbcontext.blog_post.FirstOrDefault(post => post.id == id));
        }

        public Boolean WritePost(PostViewModel postViewModel)
        {
            try {
                var postModel = AutoMapper.Mapper.Map<PostViewModel, blog_post>(postViewModel);
                dbcontext.blog_post.Add(postModel);

                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        ////////////////////////Methods////////////////////////////////
        public List<PostViewModel> GetPosts() {
            return AutoMapper.Mapper.Map<List<blog_post>,List<PostViewModel>>(dbcontext.blog_post.ToList());
        }
    }
}