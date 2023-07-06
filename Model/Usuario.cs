using System.ComponentModel.DataAnnotations;

namespace App_CRM.Model
{
	public class Usuario
	{
		[Key, Required]
        public string Username { get; set; }

        [Required]
        public string? Nombre { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public bool IsAdminRol { get; set; }

    }
}
