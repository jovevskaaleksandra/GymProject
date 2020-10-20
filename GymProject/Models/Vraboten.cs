using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gymApp.Models
{
    public class Vraboten
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Име и презиме")]
        public string nameVraboten { get; set; }
        [Required]
        [Display(Name = "Е-маил")]
        public string emailVraboten { get; set; }
        [Display(Name = "Код на вработен")]
        public int kodVraboten { get; set; }

        [Required]
        [Display(Name = "Телефонски број")]
        public int telefonskiBrojVraboten { get; set; }

        public List<Klient>klienti { get; set; }
        public Vraboten()
        {
            klienti = new List<Klient>();
        }
    }
}