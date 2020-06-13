using intellore_system_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intellore_system_test.Repository
{
    public class TagManagerRepository
    {
        private List<Post> posts = new List<Post>();
        private List<Tag> tags = new List<Tag>();

        public TagManagerRepository()
        {
            posts.Add(new Post { PostId = 1, Title = "post 1", Description = "demo" });
            posts.Add(new Post { PostId = 2, Title = "post 2", Description = "demo 2" });
            posts.Add(new Post { PostId = 3, Title = "post 3", Description = "demo 3" });

            tags.Add(new Tag { TagId = 1, Name = "tag 1", PostId = 1 });
            tags.Add(new Tag { TagId = 2, Name = "tag 2", PostId = 2 });
            tags.Add(new Tag { TagId = 2, Name = "tag 3", PostId = 6 });

        }
        // GET api/CRUD  
        public IEnumerable<Post> GetAllPost()
        {
            return posts;
        }

        public IEnumerable<Tag> GetAllTag()
        {
            return tags;
        }

        public Post GetPostbyId(int postId)
        {
            return posts.Where(i => i.PostId == postId).FirstOrDefault();
        }


        public Tag GetTagbytagId(int tagId)
        {
            return tags.Where(i => i.TagId == tagId).FirstOrDefault();
        }

        public Tag GetTagbyPostId(int postId)
        {
            return tags.Where(i => i.PostId == postId).FirstOrDefault();
        }

        public bool UntagPost(int PostId)
        {

            return tags.Remove(tags.First(tag => tag.PostId == PostId));
        }
    }
}