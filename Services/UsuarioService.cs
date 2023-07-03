using App_CRM.Model;

namespace App_CRM.Services
{
    public class UsuarioService
    {
        private readonly CRMDBContext _context;

        public UsuarioService(CRMDBContext db)
        {
            _context = db;
        }

        public Usuario GetByUsername(string username)
        {
            try
            {
                return _context.Usuario.Find(username);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
