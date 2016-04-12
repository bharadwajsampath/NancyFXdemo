using System;
using Nancy;
using Nancy.ModelBinding;
using Nancy.Responses.Negotiation;
using NancyBlogDemo.Models;

namespace NancyBlogDemo.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => GetAllBlogs();
            Get["/New/"] = _ => PostBlog();
            Post["/New/"] = _ => PostBlog(this.Bind<BlogPost>());
        }




        public Negotiator PostBlog()
        {
            return View["New", new BlogPost()];
        }

        public dynamic GetAllBlogs()
        {
            var blogPost = new BlogPost
            {
                Id = 1,
                Title = "From ASP.NET MVC to Nancy - Part 2",
                Content = "Lorem ipsum...",
                Tags = { "c#", "aspnetmvc", "nancy" }
            };
            return Negotiate.WithView("Index").WithModel(blogPost);
        }


        public Response PostBlog(BlogPost bp)
        {
            var blogPost = this.Bind<BlogPost>();
            // Redirects the user to our Index action with a "status" value as a querystring.
            return Response.AsRedirect("/?status=added&title=" + blogPost.Title);
        }
    }
}