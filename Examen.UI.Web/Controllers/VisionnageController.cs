using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.UI.Web.Controllers
{
    public class VisionnageController : Controller
    {
        IServiceVisionnage svision;
        IServiceUtilisateur suser;
        IServiceProgramme sprog;

        public VisionnageController(IServiceUtilisateur suser, IServiceProgramme sprog, IServiceVisionnage svision)
        {
            this.suser = suser;
            this.sprog = sprog;
            this.svision = svision;
        }



        // GET: VisionnageController
        public ActionResult Index()
        {
            return View(svision.GetMany());
        }

        // GET: VisionnageController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VisionnageController/Create
        public ActionResult Create()
        {
            ViewBag.lsUtilisateur = new SelectList(suser.GetMany(), "UtilisateurId", "NomUtilisateur");
            ViewBag.lsProgramme = new SelectList(sprog.GetMany(), "ProgrammeId", "NomProgramme");
            return View();
        }

        // POST: VisionnageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Visionnage collection)
        {
            svision.Add(collection);
            svision.Commit();
            return RedirectToAction(nameof(Index));
        }

        // GET: VisionnageController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VisionnageController/Edit/5
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

        // GET: VisionnageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VisionnageController/Delete/5
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
