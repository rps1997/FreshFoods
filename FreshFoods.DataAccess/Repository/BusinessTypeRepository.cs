using FreshFoods.Data;
using FreshFoods.DataAccess.Repository.IRepository;
using FreshFoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFoods.DataAccess.Repository
{
    public class BusinessTypeRepository : Repository<BusinessType>, IBusniesstypeRepository 
    {
        private readonly ApplicationDbContext _db;
        public BusinessTypeRepository(ApplicationDbContext db):base(db)
        {
            _db = db;
        }
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(BusinessType businessType)
        {
            throw new NotImplementedException();
        }
    }
}
