using System.ComponentModel.DataAnnotations;

namespace App_CRM.Model
{
	public class Contrato
	{
		[Key]
		public int IdContrato { get; set; }
        public int ClienteId { get; set; } 
        public int ServicioId { get; set; }
        public Cliente? Cliente { get; set; }
        public Servicio? Servicio { get; set; }
    }
}
