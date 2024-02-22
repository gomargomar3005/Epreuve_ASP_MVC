using BLL_Epreuve.Entities;
using Epreuve_ASP_MVC.Handlers;
using Epreuve_ASP_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared_Epreuve.Repositories;

namespace Epreuve_ASP_MVC.Controllers
{
    public class CategorieController : Controller
    {
        private readonly ICategorieRepository<Categorie> _categorieRepository;
        public CategorieController(ICategorieRepository<Categorie> categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }
        // GET: CategorieController
        public ActionResult Index()
        {
            IEnumerable<CategorieListViewModel> model = _categorieRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: CategorieController/Details/5
        public ActionResult Details(int id)
        {
            CategorieDetailsViewModel model = _categorieRepository.Get(id).ToDetails();
            return View(model);
        }

        // GET: CategorieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategorieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategorieCreateForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas");
                if (!ModelState.IsValid) throw new Exception();
                int id = _categorieRepository.Insert(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View(form);
            
            }
        }

        // GET: CategorieController/Edit/5
        public ActionResult Edit(int id)
        {
            CategorieEditForm model = _categorieRepository.Get(id).ToEditForm();
            return View(model);
        }

        // POST: CategorieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CategorieEditForm form)
        {
            try
            {
                if (form is null) ModelState.AddModelError(nameof(form), "Le formulaire ne correspond pas.");
                if (!ModelState.IsValid) throw new Exception();
                _categorieRepository.Update(form.ToBLL());
                return RedirectToAction(nameof(Details), new { id });
            }
            catch
            {
                return View(form);
            }
        }

        // GET: CategorieController/Delete/5
        public ActionResult Delete(int id)
        {
            CategorieDeleteViewModel model = _categorieRepository.Get(id).ToDelete();
            if (model is null) throw new Exception();
            return View(model);
        }

        // POST: CategorieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, CategorieDeleteViewModel model)
        {
            try
            {
                _categorieRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
    }
}
