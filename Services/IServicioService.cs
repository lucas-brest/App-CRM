using App_CRM.Model;

namespace App_CRM.Services
{
    public interface IServicioService
    {
        public List<Servicio> GetServicios();
        public Servicio GetServicioById(int id);
        public bool AddUpdateServicio(Servicio servicio);
        public bool DeleteServicio(Servicio servicio);
    }
}
