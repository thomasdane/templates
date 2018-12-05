using Api.Repositories;

namespace Api.Services
{
    public interface IService
    {
        string GetAllValues();
    }

    public class Service : IService
    {
        private IRepository _repository;

        public Service(IRepository repository) {
            _repository = repository;
        }
        public string GetAllValues()
        {
            var data = _repository.GetAll();
            var json = TransformData(data);
            return json;
        }

        private string TransformData(string data){
            return $"Add service data. {data}";
        }
    }
}