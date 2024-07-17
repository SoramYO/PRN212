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
            _context.AirConditioners.Update(airConditioner);
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
