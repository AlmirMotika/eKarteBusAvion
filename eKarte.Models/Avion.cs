using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eKarte.Models
{
    public class Avion
    {
        public int Id { get; set; }
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Proizvodjac { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [DisplayName("Godina Proizvodnje")]
        public int GodinaProizvodnje { get; set; }
        [Required]
        public int Kapacitet { get; set; }
        [Required]
        [DisplayName("Kompanija")]
        public int KompanijaId { get; set; }
        public virtual Kompanija Kompanija { get; set; }

    }
}
