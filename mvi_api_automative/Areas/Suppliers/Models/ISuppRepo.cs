using WebApp2.Models;

namespace WebApp2.Areas.Suppliers.Models
    {
    public interface ISuppRepo
        {

        void Enroll(SuppModel model);

        void Update(int id, SuppModel model);


        }
    public class SuppRepo : ISuppRepo
        {
        NorthwindDbContext _context;

        public SuppRepo(NorthwindDbContext context)
            {
            _context = context;

            }
        public void Enroll(SuppModel model)
            {
            _context.Suppliers.Add(model);
            _context.SaveChanges();
            }

        public void Update(int id, SuppModel model)
            {
            SuppModel s = _context.Suppliers.Find(id);
            s.CompanyName = model.CompanyName;
            s.City = model.City;
            _context.SaveChanges();
            }
        }
    }
