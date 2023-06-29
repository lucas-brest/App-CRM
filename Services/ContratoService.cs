using App_CRM.Model;

namespace App_CRM.Services
{
    public class ContratoService
    {
        private readonly CRMDBContext _context;
        public ContratoService(CRMDBContext db)
        {
            _context = db;
        }
        public List<Contrato> GetContrato()
        {
            try
            {
                var Contratos = _context.Contrato.ToList();
                Contratos.ForEach(contrato =>
                {
                    contrato.Cliente = _context.Cliente.Find(contrato.ClienteId);
                    contrato.Servicio = _context.Servicio.Find(contrato.ServicioId);
                });
                return Contratos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public bool AddUpdateContrato(Contrato contrato)
        {
            try
            {
                if(contrato.IdContrato == 0)
                {
                    _context.Contrato.Add(contrato);
                }
                else
                {
                    _context.Contrato.Update(contrato);
                }
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool DeleteContrato(Contrato contrato) { 
            try
            {
                _context.Contrato.Remove(contrato);
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
