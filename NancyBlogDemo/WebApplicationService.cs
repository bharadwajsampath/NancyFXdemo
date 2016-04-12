using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NancyBlogDemo
{
    public class WebApplicationService
    {
        private readonly DateTime _created;
        
        private int _totalRequest;

        public WebApplicationService()
        {
            _created = DateTime.Now;
            _totalRequest = 0;

        }

        public DateTime GetCreationDate()
        {
            _totalRequest++;
            return _created;
        }

        public int TimesRequested()
        {
            return _totalRequest;
        }

    }
}