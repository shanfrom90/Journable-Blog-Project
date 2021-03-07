using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Content

    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public virtual Category Category { get; set; }
        //may need to add Display Annotation-select Category
        public int CategoryId { get; set; }

        public Content(int id, string title, string body, string author, string publishDate)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
        }

        public Content()
        {
        }

    }
}
