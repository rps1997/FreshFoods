using FreshFoods.Data;
using FreshFoods.DataAccess.Repository.IRepository;
using FreshFoods.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreshFoods.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _db;
        //public IEnumerable<Category> category { get; set; }
        public CategoryController(ICategoryRepository db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> obj= _db.GetAll();
            return View(obj);
        }
        //GET
        public IActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if(ModelState.IsValid)
            {
                _db.Add(obj);
                _db.Save();
                return RedirectToAction(nameof(Index)); 
            }
            return View();
        }
        //GET
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.GetFirstOrDefault(u => u.Id == id);
            return View(CategoryFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Update(obj);
                _db.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var CategoryFromDb = _db.GetFirstOrDefault(u => u.Id == id);
            return View(CategoryFromDb);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var obj = _db.GetFirstOrDefault(i => i.Id == id);
            if(obj != null)
            { 
                _db.Remove(obj);
                _db.Save();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
