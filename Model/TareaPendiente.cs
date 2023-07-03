using System.ComponentModel.DataAnnotations;

namespace App_CRM.Model
{
    public class TareaPendiente
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public string Descripcion { get; set; }
    }
}
