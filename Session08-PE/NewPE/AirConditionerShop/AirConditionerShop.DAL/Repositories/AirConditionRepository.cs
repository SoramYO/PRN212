using AirConditionerShop.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace AirConditionerShop.DAL.Repositories
{
    public class AirConditionRepository
    {
        private AirConditionerShop2024DbContext _context;

        public List<AirConditioner> GetAll()
        {
            _context = new AirConditionerShop2024DbContext();
            return _context.AirConditioners.Include("Supplier").ToList();
        }

        public void Add(AirConditioner airConditioner)
        {
            _context = new AirConditionerShop2024DbContext();
            _context.AirConditioners.Add(airConditioner);
            _context.SaveChanges();
        }
        public void Update(AirConditioner airConditioner)
        {
            _context = new AirConditionerShop2024DbContext();

            var airUpdate = _context.AirConditioners.Where(a => a.AirConditionerId == airConditioner.AirConditionerId).FirstOrDefault();
            airUpdate.AirConditionerName = airConditioner.AirConditionerName;
            airUpdate.Warranty = airConditioner.Warranty;
            airUpdate.SoundPressureLevel = airConditioner.SoundPressureLevel;
            airUpdate.FeatureFunction = airConditioner.FeatureFunction;
            airUpdate.Quantity = airConditioner.Quantity;
            airUpdate.DollarPrice = airConditioner.DollarPrice;
            airUpdate.SupplierId = airConditioner.SupplierId;
            _context.SaveChanges();
        }
        public void Delete(AirConditioner airConditioner)
        {
            _context = new AirConditionerShop2024DbContext();
            _context.AirConditioners.Remove(airConditioner);
            _context.SaveChanges();
        }
    }
}
