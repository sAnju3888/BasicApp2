namespace NorthwindDemoEFCoreDependencyInjection2.Models
    {


        public interface ICategoryRepository
            {
            List<CategoryModel> GetCategories();
            void Add(CategoryModel category);
            void Update(CategoryModel category);
            void Delete(CategoryModel category);
            public  CategoryModel GetById(int id);
            }

        public class CategoryService : ICategoryRepository
        {
            NorthwindDBContext _dbContext;
            public CategoryService(NorthwindDBContext context)
                {
                _dbContext = context;

                }
            public void Add(CategoryModel category)
                {
                //throw new NotImplementedException();
                _dbContext.Categories.Add(category);
                _dbContext.SaveChanges();
                }

            public void Delete(CategoryModel category)
                {
                //throw new NotImplementedException();
                CategoryModel m = _dbContext.Categories.Single(x => x.CategoryId == category.CategoryId);
            
                _dbContext.Categories.Remove(category);
                _dbContext.SaveChanges();

                }

            public CategoryModel GetById(int id)
                {
                //throw new NotImplementedException();
                CategoryModel model = _dbContext.Categories.Find(id);
                return model;
                }

            public List<CategoryModel> GetCategories()
                {
                //throw new NotImplementedException();
                List<CategoryModel> categories = _dbContext.Categories.ToList();
                return categories;
                }

            public void Update(CategoryModel category)
                {
                 _dbContext.Categories.Update(category);
                  _dbContext.SaveChanges();
                }
            }

        }
    
