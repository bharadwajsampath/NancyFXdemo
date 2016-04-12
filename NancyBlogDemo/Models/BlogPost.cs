using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyBlogDemo.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }

        public BlogPost()
        {
            Tags = new List<string>();
        }
    }
}