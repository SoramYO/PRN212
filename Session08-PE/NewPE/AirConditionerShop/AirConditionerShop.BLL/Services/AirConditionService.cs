using AirConditionerShop.DAL.Models;
using AirConditionerShop.DAL.Repositories;

namespace AirConditionerShop.BLL.Services
{
    public class AirConditionService
    {
        private AirConditionRepository _repo = new();

        public List<AirConditioner> GetAll()
        {
            return _repo.GetAll();
        }

        public List<AirConditioner> SearchAirConditioner(string quantity, string feature)
        {
            string quantitySearch = quantity.ToLower();
            string featureSearch = feature.ToLower();
            return _repo.GetAll().Where(x => x.Quantity.ToString().ToLower().Contains(quantitySearch) && x.FeatureFunction.ToLower().Contains(featureSearch)).ToList();
        }

        public void Add(AirConditioner airConditioner)
        {
            _repo.Add(airConditioner);
        }
        public void Update(AirConditioner airConditioner)
        {
            _repo.Update(airConditioner);
        }
        public void Delete(AirConditioner airConditioner)
        {
            _repo.Delete(airConditioner);
        }
    }
}
