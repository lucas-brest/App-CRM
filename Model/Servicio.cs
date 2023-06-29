using System.ComponentModel.DataAnnotations;

namespace App_CRM.Model
{
	public class Servicio
	{
        [Key]
		public int IdServicio { get; set; }
		[Required]
		public string Nombre { get; set; }
    }
}
