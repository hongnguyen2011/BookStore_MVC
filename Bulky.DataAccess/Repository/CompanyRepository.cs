using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using BulkyBook.DataAccess.Repository;
using BulkyBook.DataAcess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            //throw new NotImplementedException();
            _db.Companies.Update(company);
        }
    }
}
