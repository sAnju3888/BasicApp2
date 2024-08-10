namespace NorthwindDemoEFCoreDependencyInjection2.Models
    {

    public interface IProductRepository
        {

        List<ProductModel> GetCategories();
        void Add(ProductModel product);
        void Update(ProductModel product);
        void Delete(ProductModel product);
        public ProductModel GetById(int id);



        }
    public class ProductService : IProductRepository
        {
        NorthwindDBContext _dbContext;
        public ProductService(NorthwindDBContext context)
            {
            _dbContext = context;

            }
        public void Add(ProductModel product)
            {
            //throw new NotImplementedException();
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            }

        public void Delete(ProductModel product)
            {
            //throw new NotImplementedException();
            ProductModel m = _dbContext.Products.Single(x => x.ProductID == product.ProductID);

            _dbContext.Products.Remove(m);
            _dbContext.SaveChanges();

            }

        public ProductModel GetById(int id)
            {
            //throw new NotImplementedException();
            ProductModel model = _dbContext.Products.Find(id);
            return model;
            }

        public List<ProductModel> GetCategories()
            {
            //throw new NotImplementedException();
            List<ProductModel> categories = _dbContext.Products.ToList();
            return categories;
            }

        public void Update(ProductModel product)
            {
            _dbContext.Products.Update(product);
            _dbContext.SaveChanges();
            }

        }
    }
