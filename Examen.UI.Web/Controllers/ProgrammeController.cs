using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.UI.Web.Controllers
{
    
    public class ProgrammeController : Controller
    {
        IServiceProgramme sprog;
        
        public ProgrammeController(IServiceProgramme sprog)
        {
            this.sprog = sprog;
        }

        // GET: ProgrammeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProgrammeController/Details/5
        public ActionResult Details(int id)
        {
            return View(sprog.GetById(id));
        }

        // GET: ProgrammeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProgrammeController/Create
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

        // GET: ProgrammeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProgrammeController/Edit/5
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

        // GET: ProgrammeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProgrammeController/Delete/5
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
