using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebIteraAPI.Models
{
    public class Company
    {
        [Required]
        public int Id_PK { get; set; }
       
        [Required]
        public string Id { get; set; }
        [Required]
        public bool status { get; set; }
        [Required]
        public DateTime date_ingestion { get; set; }
        [Required]
        public DateTime last_update { get; set; }
        [Required]
        public int custos_ano { get; set; }
        [Required]
        public string custos_id_type { get; set; }
        [Required]
        public DateTime custos_last_update { get; set; }
        [Required]
        public decimal custos_valor { get; set; }
 
       
    }
}
