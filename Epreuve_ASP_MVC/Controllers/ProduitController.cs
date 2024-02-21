using BLL_Epreuve.Entities;
using Epreuve_ASP_MVC.Handlers;
using Epreuve_ASP_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Shared_Epreuve.Repositories;

namespace Epreuve_ASP_MVC.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitRepository<Produit> _produitRepository;
        public ProduitController(IProduitRepository<Produit> produitRepository)
        {
            _produitRepository = produitRepository;
        }

        // GET: ProduitController
        public ActionResult Index()
        {
            IEnumerable<ProduitListViewModel> model = _produitRepository.Get().Select(d => d.ToListItem());
            return View(model);
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
