using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Manager.Entities
{
    public class BaseEntity
    {
        [Key]
        //Genera una nuevo id cuando se agrega una nueva ciudad
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        //Se agrega un constructor para asegurar que el valor Name siempre tenga valor
        //Si no ponemos signo de interrogacion en Description nos marca una alerta en el constructor
        //public BaseEntity(string name)
        //{
        //    Name = name;
        //}
    }
}
