using BLL_Epreuve.Entities;
using Epreuve_ASP_MVC.Handlers;
using Epreuve_ASP_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Shared_Epreuve.Repositories;

namespace Epreuve_ASP_MVC.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageRepository<Image> _imagerepository;
        public ImageController(IImageRepository<Image> imagerepository)
        {
            _imagerepository = imagerepository;
        }

        // GET: ImageController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ImageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ImageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ImageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ImageCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                int id = _imagerepository.Insert(form.ToBLL());
                await form.Url.SaveFile();
                return RedirectToAction("Index","Produit");
            }
            catch
            {
                return View(form);
            }
        }

        // GET: ImageController/Edit/5
        public ActionResult Edit(int id)
        {
            ImageEditForm model = _imagerepository.Get(id).ToEditForm();
            return View(model);
        }

        // POST: ImageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ImageController/Delete/5
        public ActionResult Delete(int id)
        {
            ImageDeleteViewModel model = _imagerepository.Get(id).ToDelete();
            if (model is null) throw new Exception();
            return View(model);
        }

        // POST: ImageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, ImageDeleteViewModel model)
        {
            try
            {
                _imagerepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
