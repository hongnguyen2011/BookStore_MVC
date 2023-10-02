using Bulky.Models;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.DataAcess.Data;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}