using App_CRM.Model;

namespace App_CRM.Services
{
    public class ClienteService
    {
        private readonly CRMDBContext _context;
        public ClienteService(CRMDBContext db)
        {
            _context = db;
        }
        public List<Cliente> GetCliente()
        {
            try
            {
                return _context.Cliente.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }
        public Cliente GetClienteById(int id)
        {
            try
            {
                return _context.Cliente.Find(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }

        public bool AddUpdateCliente(Cliente cliente)
        {
            try
            {
                if(cliente.DNI == 0)
                {
                    _context.Cliente.Add(cliente);
                }
                else
                {
                    _context.Cliente.Update(cliente);
                }
                _context.SaveChanges();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool DeleteCliente(Cliente cliente)
        {
            try
            {
                _context.Cliente.Remove(cliente);
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
