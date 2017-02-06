using System;
using System.Collections.Generic;
using System.Text;
using CMS.Data.Model.Enum;

namespace CMS.Data.Model.Entity
{
   public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public ArticleType ArticleType { get; set; }

        public string CoverUrl { get; set; }

        public string Contents { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; } = DateTime.Now;

        public User Author { get; set; }

        public int ReadCount { get; set; }

        public bool IsDel { get; set; } = false;
    }
}
