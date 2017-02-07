using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMS.Data;
using CMS.Data.Model.Entity;
using CMS.Data.Model.Enum;



namespace CMS.Backend.Controllers
{
    public class ArticleController : Controller
    {
        private readonly CMSDBContext _context;


        public ArticleController(CMSDBContext context) {
            _context = context;
        }
        public IActionResult List()
        {


            return View();
        }

        public IActionResult Add()
        {
            for (int i = 1; i < 10; i++)
            {
                Article o = new Article()
                {
                    Title = $"这是第{i}个标题",
                    Summary= $"这是第{i}个描述信息",
                    
                };
                _context.Article.Add(o);

            }

            _context.SaveChanges();

            return null;
        }

    }
}
