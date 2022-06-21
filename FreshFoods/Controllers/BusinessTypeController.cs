using FreshFoods.DataAccess.Repository;
using FreshFoods.DataAccess.Repository.IRepository;
using FreshFoods.Models;
using Microsoft.AspNetCore.Mvc;

namespace FreshFoods.Controllers
{
    public class BusinessTypeController : Controller
    {
        private readonly IBusniesstypeRepository _db;
        public BusinessTypeController(IBusniesstypeRepository db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<BusinessType> obj = _db.GetAll();
            return View(obj);
        }
    }
}
