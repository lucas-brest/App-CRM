using App_CRM.Model;
using Microsoft.AspNetCore.Identity;

namespace App_CRM.Services
{
    public class ServicioService : IServicioService
    {
        private readonly CRMDBContext _context;
        public ServicioService(CRMDBContext db)
        {
            _context = db;   
        }
        public List<Servicio> GetServicios()
        {
            try
            {
                return _context.Servicio.ToList();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }

        public Servicio GetServicioById(int id)
        {
            return _context.Servicio.Find(id);
        }

        public bool AddUpdateServicio(Servicio servicio)
        {
            try
            {
                if(servicio.IdServicio == 0)
                {
                    _context.Servicio.Add(servicio);
                } 
                else
                {
                    _context.Servicio.Update(servicio);
                }
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool DeleteServicio(Servicio servicio)
        {
            try
            {
                _context.Servicio.Remove(servicio);
                _context.SaveChanges();
                return true;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
