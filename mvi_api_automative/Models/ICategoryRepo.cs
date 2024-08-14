namespace WebApp2.Models
    {
    public interface ICategoryRepo
        {
        List<CategoryModel> GetAll();
        public string FetchDescription(int id);

        public CategoryModel FindByCategoryID(int id);
        public CategoryModel FindByIdAndName(int id, string name);

        void AddCategory(CategoryModel category);
        void UpdateCategory(int id, CategoryModel category);
        void DeleteCategory(int id);
        
        }

    }
