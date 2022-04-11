using Newtonsoft.Json;
using System.Collections.Generic;

namespace MyBlog.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Article> Articles { get; set; }
    }
}