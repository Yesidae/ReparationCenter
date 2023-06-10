using System.ComponentModel.DataAnnotations;

namespace ReparationCenter.Shared.Entities
{
    public class MyReparation
    {
        public string DeviceType { get; set; } = null!; // tipo de equipo

        public string Brand { get; set; } = null!; // Marca

        public string OwnerName { get; set; } = null!; //Nombre den propietario

        public string OwnerLastName { get; set; } = null!; //Nombre den propietario

        public int OwnerPhone { get; set; } //Telefono del propietario

        public string Email { get; set; } = null!; //Correo electronico     

        [Required]
        public string DamageDiagnosis { get; set; } = null!; //Diagnostico del daño

        [Required]
        public string TechnicalComents { get; set; } = null!; //Comentarios del tecnico

        public string RepairStatus { get; set; } = null!; //Comentarios del tecnico

        [Required]
        public decimal RepairValue { get; set; } //Valor de la reparación

        public int Id { get; set; } 

        public DateTime DateStarted { get; set; } //Fecha de ingreso

        public DateTime DateFinished { get; set; } //Fecha de salida
    }
}
