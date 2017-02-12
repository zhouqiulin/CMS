using System;
using System.Collections.Generic;
using System.Text;
using CMS.Data.Model.Enum;
using System.ComponentModel.DataAnnotations;





namespace CMS.Data.Model.Entity
{
   public class Article
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20,ErrorMessage ="标题不能为空")]
        [Display(Name ="标题")]
        public string Title { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "描述内不能为空")]
        [Display(Name = "摘要")]
        public string Summary { get; set; }

        [Display(Name = "分类")]
        public ArticleType ArticleType { get; set; }

        [Display(Name = "封面")]
        public string CoverUrl { get; set; }

       
        public string Contents { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; } = DateTime.Now;

        public User Author { get; set; }

        public int ReadCount { get; set; }

        public bool IsDel { get; set; } = false;
    }
}
