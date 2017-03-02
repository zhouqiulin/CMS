using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMS.Data;
using CMS.Data.Model.Entity;
using CMS.Data.Model.Enum;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CMS.Backend.Controllers
{
    public class ArticleController : Controller
    {
        private readonly CMSDBContext _context;
        private readonly IHostingEnvironment _env;


        public ArticleController(CMSDBContext context, IHostingEnvironment env) {
            _context = context;
            _env = env;
        }
        public IActionResult List()
        {
            List<Article> model = _context.Article.ToList();

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit() {

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Article model) {

            return View();
        }

        [HttpGet]
        public IActionResult FileUploadTest() {
            return View();
        }
        [HttpPost]
        public IActionResult FileUploadTest(IFormFile zqlfile)
        {


            var fullFileName = Path.GetRandomFileName() + Path.GetExtension(zqlfile.FileName);


            var fileDir= Path.Combine(_env.WebRootPath, "UploadFiles");

            Directory.CreateDirectory(fileDir);

            var filePath = Path.Combine(fileDir,fullFileName);



            using (var stream = new FileStream(filePath, FileMode.CreateNew))
            {
                zqlfile.CopyTo(stream);
            }

            return View();
        }

        public IActionResult Seed()
        {
            for (int i = 1; i < 10; i++)
            {
                Article o = new Article()
                {
                    Title = $"这是第{i}个标题",
                    Summary = $"这是第{i}个描述信息",

                };
                _context.Article.Add(o);

            }

            _context.SaveChanges();

            return null;
        }

    }

}
