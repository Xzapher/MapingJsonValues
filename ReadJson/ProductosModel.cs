using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReadJson.Models
{
    internal class ProductoModel
    {
        //[Key]
        //[Column("ID")]
        [JsonProperty("ID")]
        public int Id { get; set; }

        //[Column("Nombre")]
        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        //[Column("Precio")]
        [JsonProperty("PrecioBase")]
        public decimal PrecioBase { get; set; }

        //[Column("Categoria")]
        [JsonProperty("Categoria")]
        public string Categoria { get; set; }
    }
}