using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebIteraAPI.Models
{
    public class Group
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public DateTime date_ingestion { get; set; }

        [Required]
        public string Id_Company { get; set; }

    }
}
