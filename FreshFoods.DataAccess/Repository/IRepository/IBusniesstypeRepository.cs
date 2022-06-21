using FreshFoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFoods.DataAccess.Repository.IRepository
{
    public interface IBusniesstypeRepository: IRepository<BusinessType>
    {
        void Update(BusinessType businessType);
        void Save();
    }
}
