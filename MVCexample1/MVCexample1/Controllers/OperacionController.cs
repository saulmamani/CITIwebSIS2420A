using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCexample1.Controllers
{
    public class OperacionController : Controller
    {
        // GET: OperacionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OperacionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OperacionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OperacionController/Create
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

        // GET: OperacionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OperacionController/Edit/5
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

        // GET: OperacionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OperacionController/Delete/5
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
