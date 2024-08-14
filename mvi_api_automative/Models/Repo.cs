namespace WebApp2.Models
    {
    public class CategoryRepo : ICategoryRepo

        {
        NorthwindDbContext _context;
        public CategoryRepo(NorthwindDbContext context)
            {
            _context = context;
            }

        public List<CategoryModel> GetAll()
            {
            List<CategoryModel> cac = _context.Categories.ToList();
            return cac;
            }

        public string FetchDescription(int id)
            {
            return "okay";
            }

        public CategoryModel FindCategoryById(int id)
            {
            return _context.Categories.Find(id);
            }

        public CategoryModel FindByIdAndName(int id, string name)
            {
            CategoryModel cat = _context.Categories.Where(c => c.CategoryID == id && c.CategoryName == name).FirstOrDefault();
            return cat;
            }

        public void AddCategory(CategoryModel category)
            {
            _context.Categories.Add(category);
            _context.SaveChanges();
            }
        public void UpdateCategory(int id, CategoryModel category)
            {
            CategoryModel cm = FindCategoryById(id);
            cm.CategoryName = category.CategoryName;
            cm.Description = category.Description;
            _context.SaveChanges();
            }

        public void DeleteCategory(int id)
            {
            if (id > 0)
                {
                CategoryModel c_obj = FindCategoryById(id);
                _context.Categories.Remove(c_obj);
                _context.SaveChanges();
                }



            }

        public CategoryModel FindByCategoryID(int id)
            {
            throw new NotImplementedException();
            }
        }
    }
