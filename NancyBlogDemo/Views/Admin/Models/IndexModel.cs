using System;
using Nancy;

namespace NancyBlogDemo.Views.Admin.Models
{
    public class IndexModel
    {
        public DateTime CreationDate { get; set; }
        public int TotalRequests { get; set; }
    }
}