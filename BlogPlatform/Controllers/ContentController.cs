using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_template_practice.Models;
using blog_template_practice.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace blog_template_practice.Controllers
{
    public class ContentController : Controller
    {
        IRepository<Content> contentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.contentRepo = contentRepo;
        }

        public ViewResult Index()
        {
            var contentList = contentRepo.GetAll();
            return View(contentList);
        }

        public ViewResult Details(int id)
        {
            var content = contentRepo.GetById(id);
            return View(content);
        }

        public ViewResult Create()
        {
            SetupCategoryViewBag();

             return View(new Content());
        }

        [HttpPost]
        public ActionResult Create(Content model)
        {
            SetupCategoryViewBag();
            model.PublishDate = DateTime.Now;
            contentRepo.Create(model);
            ViewBag.Result = "Your post has been submitted.";
            return RedirectToAction("Index");
        }


        public ViewResult CreateByCategoryId(int id)
        {
            SetupCategoryViewBag();
            return View(new Content() { CategoryId = id });
        }

        public ViewResult Update(int id)
        {
            var content = contentRepo.GetById(id);
            SetupCategoryViewBag();
            return View(content);
        }
        [HttpPost]
        public ActionResult Update(Content model)
        {
            SetupCategoryViewBag();
            model.PublishDate = DateTime.Now;

            contentRepo.Update(model);
            ViewBag.Result = "You have successfully updated this post";
            return RedirectToAction("Index");
        }

        public ViewResult Delete(int id)
        {
            var content = contentRepo.GetById(id);
            SetupCategoryViewBag();
            return View(content);
        }

        [HttpPost]
        public ActionResult Delete(Content model)
        {
            SetupCategoryViewBag();
            contentRepo.Delete(model);

            return RedirectToAction("Index");
        }

        private void SetupCategoryViewBag()
        {
            var categories = contentRepo.PopulateCategoryList();
            ViewBag.Categories = categories;
        }
    }
}
