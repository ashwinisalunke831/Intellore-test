using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using intellore_system_test.Models;
using intellore_system_test.Repository;

namespace intellore_system_test.Controllers
{
    public class PostManagerController : ApiController
    {
            TagManagerRepository _tagManager;
            public PostManagerController(TagManagerRepository tagManager)
            {
                _tagManager = tagManager;
            }

            // TagManager.UntagPost
            [HttpDelete]
            public IHttpActionResult UnTagPost(int postId)
            {
                var tagObj = _tagManager.GetTagbyPostId(postId);
                if (tagObj == null)
                {
                    throw new ArgumentException($"tag not exist.");
                }

                var post = _tagManager.GetPostbyId(postId);
                if (post == null)
                {
                    throw new ArgumentException($"post not exist");
                }

                var tag = _tagManager.GetTagbyPostId(postId);
                if (tag == null)
                {
                    throw new ArgumentException($"tag isn't related to post.");
                }

                return Ok(_tagManager.UntagPost(postId));
            }

            // PostManager.Get
            [HttpGet]
            public IHttpActionResult Get(int postId)
            {
                Post post = _tagManager.GetPostbyId(postId);
                if (post == null)
                {
                    throw new ArgumentException($"post not exist");
                }


                //Transform DTO into GameRequest for calling Razer Initiate
                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<PostDto, Post>();
                });

                var iMapper = config.CreateMapper();
                var postRequest = iMapper.Map<Post, PostDto>(post);
                return Ok(postRequest);
            }
        }
    }