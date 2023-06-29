using System.ComponentModel.DataAnnotations;

namespace App_CRM.Model
{
	public class Usuario
	{
		[Key]
		public int IdUsuario { get; set; }
        public bool IsAdminRol { get; set; }
        public string? Nombre { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool Estado { get; set; }
        public DateTime? UltimoLogin { get; set; }

    }
}
