using System.ComponentModel.DataAnnotations;

namespace App_CRM.Model
{
	public class Usuario
	{
        public bool IsAdminRol { get; set; }
        public string? Nombre { get; set; }
		[Key]
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool Estado { get; set; }
        public DateTime? UltimoLogin { get; set; }

    }
}
