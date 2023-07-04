using Microsoft.AspNetCore.Mvc;
using razor.Models;

namespace razor.Controllers
{
    public class ExpenditureController : Controller
    {
        // GET: ExpenditureController
        public ActionResult Index()
        {
            // Créez une liste de dépenses
            var expenditures = new List<Expenditure>
        {
            new Expenditure { Name = "Achat1", Date = DateTime.Now.AddDays(-1), Price = 20.5m },
            new Expenditure { Name = "Achat2", Date = DateTime.Now.AddDays(-2), Price = 25.25m },
            new Expenditure { Name = "Achat3", Date = DateTime.Now.AddDays(-5), Price = 70.75m }
        };

            return View(expenditures);

        }

        // GET: ExpenditureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExpenditureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpenditureController/Create
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

        // GET: ExpenditureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExpenditureController/Edit/5
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

        // GET: ExpenditureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpenditureController/Delete/5
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