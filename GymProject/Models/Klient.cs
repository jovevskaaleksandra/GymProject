using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gymApp.Models
{
    public class Klient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Име и презиме")]
        public string nameKlient { get; set; }
        [Required]
        [Display(Name = "Висина")]
        public int heightKlient { get; set; }
        [Required]
        [Display(Name = "Тежина")]
        public int weightKlient { get; set; }
        [Required]
        [Display(Name = "Број на тренинзи на месечно ниво")]
        public int kolkuPatiMesecno { get; set; }
        [Required]
        [StringLength(9, MinimumLength = 9)]
        [Display(Name = "Телефон")]
        public string telefonskiBrojKlient { get; set; }
        [Required]
        [Display(Name = "Адреса на живеење")]
        public string  addressKlient { get; set; }

        [Required]
        [Display(Name = "Тип на тренинг")]
        public Trening tiptrening { get; set; }

        [Required]
        [Display(Name = "Тренер")]
        public Trener trenerZaKlient { get; set; }
        [Required]
        [Display(Name = "Членска карта")]
        public int clenskaKartaKlient { get; set; }

    }
    public enum Trening
    {
        Кросфит,
        Аеробик,
        Пилатес
    }
}