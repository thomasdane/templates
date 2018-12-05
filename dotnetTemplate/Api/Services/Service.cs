namespace Api.Services
{
    public interface IService
    {
        string GetAllValues();
    }

    public class Service : IService
    {
        public string GetAllValues()
        {
            return "Data from database";
        }
    }
}