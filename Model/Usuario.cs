using System.ComponentModel.DataAnnotations;

namespace App_CRM.Model
{
	public class Usuario
	{
		[Key]
        public string Username { get; set; }
        public string? Nombre { get; set; }
        public string? Password { get; set; }
        public bool IsAdminRol { get; set; }

    }
}
