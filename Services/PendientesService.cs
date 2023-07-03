using App_CRM.Model;

namespace App_CRM.Services
{
    public class PendientesService
    {
        private readonly CRMDBContext _context;

        public PendientesService(CRMDBContext db)
        {
            _context = db;
        }

        public List<TareaPendiente> GetAll()
        {
            try
            {
                var tareas = _context.TareaPendiente.ToList();
                tareas.ForEach(tarea =>
                {
                    tarea.Cliente = _context.Cliente.Find(tarea.ClienteId);
                });
                return tareas ;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }

        public bool AddUpdate(TareaPendiente tareaPendiente)
        {
            try
            {
                if (tareaPendiente.Id == 0)
                {
                    _context.TareaPendiente.Add(tareaPendiente);
                }
                else
                {
                    _context.TareaPendiente.Update(tareaPendiente);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Delete(TareaPendiente tareaPendiente)
        {
            try
            {
                _context.TareaPendiente.Remove(tareaPendiente);
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
