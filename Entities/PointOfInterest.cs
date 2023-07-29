using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Manager.Entities
{
    public class PointOfInterest : BaseEntity
    {
        //Se comenta porque se hereda de baseEntity y esta clase ya tiene todas esta propiedades 
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }

        //[Required]
        //[MaxLength(50)]
        //public string Name { get; set; }

        //[MaxLength(200)]
        //public string? Description { get; set; }

        //Para navegar a la entidad City
        [ForeignKey("CityId")]
        //Propiedad de navegacion 
        public City? City { get; set; }
        public int CityId { get; set; }
        public PointOfInterest(string name)
        {
            Name = name;
        }
    }
}
