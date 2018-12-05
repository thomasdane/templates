namespace Api.Repositories
{
    public interface IRepository
    {
        string GetAll();
    }

    public class Repository : IRepository
    {
        public string GetAll()
        {
            return "Data from database";
        }
    }
}