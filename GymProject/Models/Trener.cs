using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gymApp.Models
{
    public class Trener : Vraboten
    {
        [Display(Name = "Број на клиенти")]
        public int brojNaKlienti { get; set; }
    }
}