using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using razor.Models;

namespace razor.Controllers
{
    public class ExpenditureController : Controller
    {


        private List<Expenditure> Expenditures { get; set; }

        public ExpenditureController()

        {

            Expenditures = new List<Expenditure>();
            Expenditures.Add(new Expenditure("Item 1", "2023, 7, 1  ", "10.99m "));
            Expenditures.Add(new Expenditure("Item 2", "2023, 7, 1  ", "10.99m "));
            Expenditures.Add(new Expenditure("Item 3", "2023, 7, 1  ", "10.99m "));
        }


        // GET: ExpenditureController1
        public ActionResult Index()
        {

            return View();
        }

        // GET: ExpenditureController1/Details/5
        public ActionResult Details(string name)
        {
            Expenditure expenditure = Expenditures.First(Expenditure => name == name);

            return View(expenditure);
        }

        // GET: ExpenditureController1/Creat
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExpenditureController1/Create
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

        // GET: ExpenditureController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExpenditureController1/Edit/5
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

        // GET: ExpenditureController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExpenditureController1/Delete/5
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

    internal record struct NewStruct(string Item1, string Item2, string Item3)
    {
        public static implicit operator (string, string, string)(NewStruct value)
        {
            return (value.Item1, value.Item2, value.Item3);
        }

        public static implicit operator NewStruct((string, string, string) value)
        {
            return new NewStruct(value.Item1, value.Item2, value.Item3);
        }
    }

    internal record struct NewStruct1(int Item1, int Item2, int Item3)
    {
        public static implicit operator (int, int, int)(NewStruct1 value)
        {
            return (value.Item1, value.Item2, value.Item3);
        }

        public static implicit operator NewStruct1((int, int, int) value)
        {
            return new NewStruct1(value.Item1, value.Item2, value.Item3);
        }
    }
}
