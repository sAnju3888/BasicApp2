namespace NorthwindDemoEFCoreDependencyInjection2.Models
    {

    public interface IRegistrationRepo
        {

        List<RegisterationModel> GetCategories();
        void Add(RegisterationModel register);
        void Update(RegisterationModel register);
        void Delete(RegisterationModel register);
        public RegisterationModel GetById(int id);



        }
    public class RegisterService : IRegistrationRepo
        {
        FormDBContext _dbContextform;
        public RegisterService(FormDBContext context)
            {
            _dbContextform = context;

            }
        public void Add(RegisterationModel register)
            {
            //throw new NotImplementedException();
            _dbContextform.Registers.Add(register);
            _dbContextform.SaveChanges();
            }

        public void Delete(RegisterationModel register)
            {
            //throw new NotImplementedException();
            RegisterationModel m = _dbContextform.Registers.Single(x => x.regid == register.regid);

            _dbContextform.Registers.Remove(m);
            _dbContextform.SaveChanges();

            }

        public RegisterationModel GetById(int id)
            {
            //throw new NotImplementedException();
            RegisterationModel model = _dbContextform.Registers.Find(id);
            return model;
            }

        public List<RegisterationModel> GetCategories()
            {
            //throw new NotImplementedException();
            List<RegisterationModel> registeries = _dbContextform.Registers.ToList();
            return registeries;
            }

        public void Update(RegisterationModel register)
            {
            _dbContextform.Registers.Update(register);
            _dbContextform.SaveChanges();
            }

        }
    }
